import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { UpdateRoleDto } from '@shared/proxy/roles/models';
import { RoleService } from '@shared/proxy/roles/role.service';

@Component({
  selector: 'app-role-edit',
  templateUrl: './role-edit.component.html'
})
export class RoleEditComponent implements OnInit {
  id: number;
  updateRoleForm: FormGroup;
  isFormSubmitted: boolean;
  updateRoleDto = {} as UpdateRoleDto;

  constructor(private formBuilder: FormBuilder, private roleService: RoleService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل الصلاحية');
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/home/role-list");
    }
  }

  buildForm() {
    this.updateRoleForm = this.formBuilder.group({
      nameAr: [this.updateRoleDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateRoleDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      isActive: [this.updateRoleDto.isActive, Validators.required]
    });
  }

  getDetails() {
    this.roleService.getById(this.id).subscribe((response) => {
      this.updateRoleDto = response.data as UpdateRoleDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateRoleForm.valid) {
      this.updateRoleDto = { ...this.updateRoleForm.value } as UpdateRoleDto;
      this.updateRoleDto.id = this.id;
      this.roleService.update(this.updateRoleDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/home/role-list");
          }
        });
    }
  }
}
