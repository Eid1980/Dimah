import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { UserDataViewComponent } from '@shared/components/user-data-view/user-data-view.component';
import { UserRoleService } from '@shared/proxy/user-roles/user-role.service';
import { GlobalService } from '@shared/services/global.service';
import { CreateUserRoleDto, GetUserRoleListDto } from '@shared/proxy/user-roles/models';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { RoleService } from '@shared/proxy/roles/role.service';

@Component({
  selector: 'app-user-role-add',
  templateUrl: './user-role-add.component.html'
})
export class UserRoleAddComponent implements OnInit {
  @ViewChild(UserDataViewComponent, { static: true }) userDataView: UserDataViewComponent;
  createUserRoleForm: FormGroup;
  isFormSubmitted: boolean;
  userId: number;
  userRolesDto = [] as GetUserRoleListDto[];
  createUserRoleDto = {} as CreateUserRoleDto;
  roles = [] as LookupDto<number>[];

  constructor(private formBuilder: FormBuilder, private userRoleService: UserRoleService,
    private roleService: RoleService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة صلاحية للمستخدم');
    this.userId = this.activatedRoute.snapshot.params['id'];
    this.buildForm();
    if (this.userId) {
      this.userDataView.initializeForm(this.userId);
      this.getRolesByUserId();
      this.fillRoles();
    }
    else {
      this.globalService.navigate("/admin/home/user-list");
    }
  }

  buildForm() {
    this.createUserRoleForm = this.formBuilder.group({
      roleId: [this.createUserRoleDto.roleId || null, [Validators.required]],
    });
  }

  getRolesByUserId() {
    this.userRoleService.getRolesByUserId(this.userId).subscribe((response) => {
      this.userRolesDto = response.data;
    });
  }
  fillRoles() {
    this.roleService.getLookupList().subscribe((response) => {
      this.roles = response.data;
    });
  }

  delete(id: number) {
    this.globalService.showConfirm(this.globalService.translate('global.messages.deleteMessage'));
    this.globalService.confirmSubmit = () => this.isconfirm(id);
  }
  isconfirm(id: number) {
    this.userRoleService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this.globalService.clearMessages();
        this.getRolesByUserId();
      }
      this.globalService.showMessage(result.message);
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createUserRoleForm.valid) {
      this.createUserRoleDto = { ...this.createUserRoleForm.value } as CreateUserRoleDto;
      this.createUserRoleDto.userId = this.userId;
      this.userRoleService.create(this.createUserRoleDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.getRolesByUserId();
          this.createUserRoleForm.reset();
          this.isFormSubmitted = false;
        }
      });
    }
  }

}
