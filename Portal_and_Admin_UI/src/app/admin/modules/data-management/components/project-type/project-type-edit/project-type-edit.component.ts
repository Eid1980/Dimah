import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { UpdateProjectTypeDto } from '@shared/proxy/project-types/models';
import { ProjectTypeService } from '@shared/proxy/project-types/project-type.service';
import { environment } from 'src/environments/environment';
import { FileCateguery } from '@shared/enums/file-categuery.enum';
import { FileManagerService } from '@shared/services/file-manager.service';

@Component({
  selector: 'app-project-type-edit',
  templateUrl: './project-type-edit.component.html'
})
export class ProjectTypeEditComponent implements OnInit {
  id: string;
  updateForm: FormGroup;
  isFormSubmitted: boolean;
  updateDto = {} as UpdateProjectTypeDto;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = environment.projectfileSize ? environment.projectfileSize : environment.fileSize;
  acceptType: string = environment.projectallowedExtensions ? environment.projectallowedExtensions : environment.allowedExtensions;
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(private formBuilder: FormBuilder, private projectTypeService: ProjectTypeService,
    private fileManagerService: FileManagerService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle(this.globalService.translate('project-type.editTitle'));
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/project-type-list");
    }
  }

  buildForm() {
    this.updateForm = this.formBuilder.group({
      nameAr: [this.updateDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      image: [null],
      isActive: [this.updateDto.isActive, Validators.required]
    });
  }

  onUpload(event: any) {
    this.updateForm.get('image').setValue(event.files[0]);
  }

  onRemove(event) {
    this.updateForm.get('image').setValue(null);
  }

  getDetails() {
    this.projectTypeService.getById(this.id).subscribe((response) => {
      this.updateDto = response.data as UpdateProjectTypeDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateForm.valid) {
      this.updateDto = { ...this.updateForm.value } as UpdateProjectTypeDto;
      this.updateDto.id = this.id;
      let imageContent = this.updateForm.get('image').value;
      if (imageContent) {
        this.updateDto.imageName = imageContent.name;
      }
      this.projectTypeService.update(this.updateDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            if (imageContent) {
              this.fileManagerService.uploadFile(FileCateguery.ProjectTypes, response.data.fileName, [imageContent]).subscribe(res => {
                this.globalService.navigate("/admin/data-management/project-type-list");
              });
            }
            else {
              this.globalService.navigate("/admin/data-management/project-type-list");
            }
          }
        });
    }
  }
}
