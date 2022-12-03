import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { CreateProjectTypeDto } from '@shared/proxy/project-types/models';
import { ProjectTypeService } from '@shared/proxy/project-types/project-type.service';

@Component({
  selector: 'app-project-type-add',
  templateUrl: './project-type-add.component.html'
})
export class ProjectTypeAddComponent implements OnInit {
  createProjectTypeForm: FormGroup;
  isFormSubmitted: boolean;
  createProjectTypeDto = {} as CreateProjectTypeDto;

  constructor(private formBuilder: FormBuilder, private projectTypeService: ProjectTypeService,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة نوع مشروع جديد');
    this.buildForm();
  }

  buildForm() {
    this.createProjectTypeForm = this.formBuilder.group({
      nameAr: [this.createProjectTypeDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createProjectTypeDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      isActive: [this.createProjectTypeDto.isActive || true, Validators.required]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createProjectTypeForm.valid) {
      this.createProjectTypeDto = { ...this.createProjectTypeForm.value } as CreateProjectTypeDto;
      this.projectTypeService.create(this.createProjectTypeDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/project-type-list");
          }
        });
    }
  }
}
