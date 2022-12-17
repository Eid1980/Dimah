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
  id: string;
  createForm: FormGroup;
  isFormSubmitted: boolean;
  createDto = {} as CreateCharityProjectDto;
  projectTypes = [] as LookupDto<string>[];

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
    this.createForm = this.formBuilder.group({
      nameAr: [this.createDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      projectTypeId: [this.createDto.projectTypeId || null, [Validators.required]],
      descriptionAr: [this.createDto.descriptionAr || ''],
      descriptionEn: [this.createDto.descriptionEn || ''],
      projectCost: [this.createDto.projectCost || null, [Validators.required]],
      projectLocation: [this.createDto.projectLocation || ''],
      image: [this.createDto.image || null, Validators.required],
      isActive: [this.createDto.isActive || true, Validators.required]
    });
  }
  fillProjectTypes() {
    this.projectTypeService.getLookupList().subscribe((response) => {
      this.projectTypes = response.data;
    });
  }
  onUpload(event: any) {
    this.createForm.get('image').setValue(event.files[0]);
  }
  onRemove(event) {
    this.createForm.get('image').setValue(null);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createForm.valid) {
      this.createDto = { ...this.createForm.value } as CreateCharityProjectDto;
      let imageContent = this.createForm.get('image').value;
      if (imageContent) {
        this.createDto.image = imageContent.name;
      }
      this.createDto.charityId = this.id;
      this.charityProjectService.create(this.createDto).subscribe((response) => {
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
