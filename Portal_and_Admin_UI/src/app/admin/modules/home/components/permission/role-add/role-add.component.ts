import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { CreateRoleDto } from '@shared/proxy/roles/models';
import { RoleService } from '@shared/proxy/roles/role.service';

@Component({
  selector: 'app-role-add',
  templateUrl: './role-add.component.html'
})
export class RoleAddComponent implements OnInit {
  createRoleForm: FormGroup;
  isFormSubmitted: boolean;
  createRoleDto = {} as CreateRoleDto;

  constructor(private formBuilder: FormBuilder, private roleService: RoleService,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة صلاحية جديدة');
    this.buildForm();
  }

  buildForm() {
    this.createRoleForm = this.formBuilder.group({
      nameAr: [this.createRoleDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createRoleDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      isActive: [this.createRoleDto.isActive || true, Validators.required]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createRoleForm.valid) {
      this.createRoleDto = { ...this.createRoleForm.value } as CreateRoleDto;
      this.roleService.create(this.createRoleDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/home/role-list");
          }
        });
    }
  }
}
