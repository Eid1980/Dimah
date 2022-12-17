import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { CreateProjectTypeDto } from '@shared/proxy/project-types/models';
import { ProjectTypeService } from '@shared/proxy/project-types/project-type.service';
import { environment } from 'src/environments/environment';
import { FileCateguery } from '@shared/enums/file-categuery.enum';
import { FileManagerService } from '@shared/services/file-manager.service';

@Component({
  selector: 'app-project-type-add',
  templateUrl: './project-type-add.component.html'
})
export class ProjectTypeAddComponent implements OnInit {
  createForm: FormGroup;
  isFormSubmitted: boolean;
  createDto = {} as CreateProjectTypeDto;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = environment.projectfileSize ? environment.projectfileSize : environment.fileSize;
  acceptType: string = environment.projectallowedExtensions ? environment.projectallowedExtensions : environment.allowedExtensions;
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(private formBuilder: FormBuilder, private projectTypeService: ProjectTypeService,
    private fileManagerService: FileManagerService, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle(this.globalService.translate('project-type.addTitle'));
    this.buildForm();
  }

  buildForm() {
    this.createForm = this.formBuilder.group({
      nameAr: [this.createDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      image: [this.createDto.image || null, Validators.required],
      isActive: [this.createDto.isActive || true, Validators.required]
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
      this.createDto = { ...this.createForm.value } as CreateProjectTypeDto;
      let imageContent = this.createForm.get('image').value;
      if (imageContent) {
        this.createDto.imageName = imageContent.name;
      }
      this.projectTypeService.create(this.createDto).subscribe((response) => {
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
