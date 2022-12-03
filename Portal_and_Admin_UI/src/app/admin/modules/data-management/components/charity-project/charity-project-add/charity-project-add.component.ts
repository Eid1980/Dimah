import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { CreateCharityProjectDto } from '@shared/proxy/charity-projects/models';
import { CharityProjectService } from '@shared/proxy/charity-projects/charity-project.service';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { ProjectTypeService } from '@shared/proxy/project-types/project-type.service';
import { CharityService } from '@shared/proxy/charities/charity.service';
import { environment } from 'src/environments/environment';
import { FileManagerService } from '@shared/services/file-manager.service';
import { FileCateguery } from '@shared/enums/file-categuery.enum';

@Component({
  selector: 'app-charity-project-add',
  templateUrl: './charity-project-add.component.html'
})
export class CharityProjectAddComponent implements OnInit {
  createCharityProjectForm: FormGroup;
  isFormSubmitted: boolean;
  createCharityProjectDto = {} as CreateCharityProjectDto;
  charities = [] as LookupDto<number>[];
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
    private charityService: CharityService, private projectTypeService: ProjectTypeService,
    private fileManagerService: FileManagerService, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة مشروع جديد');
    this.buildForm();
    this.fillCharities();
    this.fillProjectTypes();
  }

  buildForm() {
    this.createCharityProjectForm = this.formBuilder.group({
      nameAr: [this.createCharityProjectDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createCharityProjectDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      charityId: [this.createCharityProjectDto.charityId || null, [Validators.required]],
      projectTypeId: [this.createCharityProjectDto.projectTypeId || null, [Validators.required]],
      descriptionAr: [this.createCharityProjectDto.descriptionAr || ''],
      descriptionEn: [this.createCharityProjectDto.descriptionEn || ''],
      projectCost: [this.createCharityProjectDto.projectCost || null, [Validators.required]],
      projectLocation: [this.createCharityProjectDto.projectLocation || ''],
      image: [this.createCharityProjectDto.image || null, Validators.required],
      isActive: [this.createCharityProjectDto.isActive || true, Validators.required]
    });
  }
  fillCharities() {
    this.charityService.getLookupList().subscribe((response) => {
      this.charities = response.data;
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
      this.charityProjectService.create(this.createCharityProjectDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            if (imageContent) {
              this.fileManagerService.uploadFile(FileCateguery.Projects, response.data.fileName, [imageContent]).subscribe(res => {
                this.globalService.navigate("/admin/data-management/charity-project-list");
              });
            }
            else {
              this.globalService.navigate("/admin/data-management/charity-project-list");
            }
          }
        });
    }
  }
}
