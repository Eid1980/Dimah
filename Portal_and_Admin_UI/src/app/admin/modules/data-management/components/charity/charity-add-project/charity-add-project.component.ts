import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { CreateCharityProjectDto } from '@shared/proxy/charity-projects/models';
import { CharityProjectService } from '@shared/proxy/charity-projects/charity-project.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { ProjectTypeService } from '@shared/proxy/project-types/project-type.service';
import { environment } from 'src/environments/environment';
import { FileManagerService } from '@shared/services/file-manager.service';
import { FileCateguery } from '@shared/enums/file-categuery.enum';

@Component({
  selector: 'app-charity-add-project',
  templateUrl: './charity-add-project.component.html'
})
export class CharityAddProjectComponent implements OnInit {
  id: number;
  createCharityProjectForm: FormGroup;
  isFormSubmitted: boolean;
  createCharityProjectDto = {} as CreateCharityProjectDto;
  projectTypes = [] as LookupDto<number>[];

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = environment.charityProjectfileSize ? environment.charityProjectfileSize : environment.fileSize;
  acceptType: string = environment.charityProjectallowedExtensions ? environment.charityProjectallowedExtensions : environment.allowedExtensions;
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(private formBuilder: FormBuilder, private charityProjectService: CharityProjectService,
    private projectTypeService: ProjectTypeService, private globalService: GlobalService,
    private fileManagerService: FileManagerService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة مشروع على الجهة');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (!this.id) {
      this.globalService.navigate("/admin/data-management/charity-list");
    }
    this.buildForm();
    this.fillProjectTypes();
  }

  buildForm() {
    this.createCharityProjectForm = this.formBuilder.group({
      nameAr: [this.createCharityProjectDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createCharityProjectDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      projectTypeId: [this.createCharityProjectDto.projectTypeId || null, [Validators.required]],
      descriptionAr: [this.createCharityProjectDto.descriptionAr || ''],
      descriptionEn: [this.createCharityProjectDto.descriptionEn || ''],
      projectCost: [this.createCharityProjectDto.projectCost || null, [Validators.required]],
      projectLocation: [this.createCharityProjectDto.projectLocation || ''],
      image: [this.createCharityProjectDto.image || null, Validators.required],
      isActive: [this.createCharityProjectDto.isActive || true, Validators.required]
    });
  }
  fillProjectTypes() {
    this.projectTypeService.getLookupList().subscribe((response) => {
      this.projectTypes = response.data;
    });
  }
  onUpload(event: any) {
    this.createCharityProjectForm.get('image').setValue(event.files[0]);
  }
  onRemove(event) {
    this.createCharityProjectForm.get('image').setValue(null);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createCharityProjectForm.valid) {
      this.createCharityProjectDto = { ...this.createCharityProjectForm.value } as CreateCharityProjectDto;
      let imageContent = this.createCharityProjectForm.get('image').value;
      if (imageContent) {
        this.createCharityProjectDto.image = imageContent.name;
      }
      this.createCharityProjectDto.charityId = this.id;
      this.charityProjectService.create(this.createCharityProjectDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            if (imageContent) {
              this.fileManagerService.uploadFile(FileCateguery.Projects, response.data.fileName, [imageContent]).subscribe(res => {
                this.globalService.navigate("/admin/data-management/charity-list");
              });
            }
            else {
              this.globalService.navigate("/admin/data-management/charity-list");
            }
          }
        });
    }
  }

}
