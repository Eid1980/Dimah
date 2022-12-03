import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { UpdateCharityProjectDto } from '@shared/proxy/charity-projects/models';
import { CharityProjectService } from '@shared/proxy/charity-projects/charity-project.service';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { environment } from 'src/environments/environment';
import { FileManagerService } from '@shared/services/file-manager.service';
import { FileCateguery } from '@shared/enums/file-categuery.enum';
import { CharityService } from '@shared/proxy/charities/charity.service';
import { ProjectTypeService } from '@shared/proxy/project-types/project-type.service';

@Component({
  selector: 'app-charity-project-edit',
  templateUrl: './charity-project-edit.component.html'
})
export class CharityProjectEditComponent implements OnInit {
  id: number;
  updateCharityProjectForm: FormGroup;
  isFormSubmitted: boolean;
  updateCharityProjectDto = {} as UpdateCharityProjectDto;
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
    private fileManagerService: FileManagerService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل بيانات المشروع');
    this.buildForm();
    this.fillCharities();
    this.fillProjectTypes();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/charity-project-list");
    }
  }

  buildForm() {
    this.updateCharityProjectForm = this.formBuilder.group({
      nameAr: [this.updateCharityProjectDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateCharityProjectDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      charityId: [this.updateCharityProjectDto.charityId || null, [Validators.required]],
      projectTypeId: [this.updateCharityProjectDto.projectTypeId || null, [Validators.required]],
      descriptionAr: [this.updateCharityProjectDto.descriptionAr || ''],
      descriptionEn: [this.updateCharityProjectDto.descriptionEn || ''],
      projectCost: [this.updateCharityProjectDto.projectCost || null, [Validators.required]],
      projectLocation: [this.updateCharityProjectDto.projectLocation || ''],
      image: [null],
      isActive: [this.updateCharityProjectDto.isActive, Validators.required]
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
    this.updateCharityProjectForm.get('image').setValue(event.files[0]);
  }
  onRemove(event) {
    this.updateCharityProjectForm.get('image').setValue(null);
  }

  getDetails() {
    this.charityProjectService.getById(this.id).subscribe((response) => {
      this.updateCharityProjectDto = response.data as UpdateCharityProjectDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateCharityProjectForm.valid) {
      this.updateCharityProjectDto = { ...this.updateCharityProjectForm.value } as UpdateCharityProjectDto;
      this.updateCharityProjectDto.id = this.id;
      let imageContent = this.updateCharityProjectForm.get('image').value;
      if (imageContent) {
        this.updateCharityProjectDto.image = imageContent.name;
      }
      this.charityProjectService.update(this.updateCharityProjectDto)
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
