import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { UpdateProjectTypeDto } from '@shared/proxy/project-types/models';
import { ProjectTypeService } from '@shared/proxy/project-types/project-type.service';

@Component({
  selector: 'app-project-type-edit',
  templateUrl: './project-type-edit.component.html'
})
export class ProjectTypeEditComponent implements OnInit {
  id: number;
  updateProjectTypeForm: FormGroup;
  isFormSubmitted: boolean;
  updateProjectTypeDto = {} as UpdateProjectTypeDto;

  constructor(private formBuilder: FormBuilder, private projectTypeService: ProjectTypeService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل نوع المشروع');
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
    this.updateProjectTypeForm = this.formBuilder.group({
      nameAr: [this.updateProjectTypeDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateProjectTypeDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      isActive: [this.updateProjectTypeDto.isActive, Validators.required]
    });
  }

  getDetails() {
    this.projectTypeService.getById(this.id).subscribe((response) => {
      this.updateProjectTypeDto = response.data as UpdateProjectTypeDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateProjectTypeForm.valid) {
      this.updateProjectTypeDto = { ...this.updateProjectTypeForm.value } as UpdateProjectTypeDto;
      this.updateProjectTypeDto.id = this.id;
      this.projectTypeService.update(this.updateProjectTypeDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/project-type-list");
          }
        });
    }
  }
}
