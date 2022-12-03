import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { GetRoleDetailsDto } from '@shared/proxy/roles/models';
import { RoleService } from '@shared/proxy/roles/role.service';
import { UserRoleService } from '@shared/proxy/user-roles/user-role.service';
import { GetRolUsersDto } from '@shared/proxy/user-roles/models';

@Component({
  selector: 'app-role-view',
  templateUrl: './role-view.component.html'
})
export class RoleViewComponent implements OnInit {
  id: number;
  roleDetailsDto = {} as GetRoleDetailsDto;
  rolUsersDto = [] as GetRolUsersDto[]

  constructor(private roleService: RoleService,
    private globalService: GlobalService, private userRoleService: UserRoleService,
    private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل الصلاحية');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
  }

  getDetails() {
    this.roleService.getById(this.id).subscribe((response) => {
      this.roleDetailsDto = response.data;
    });
    this.userRoleService.getUsersByRoleId(this.id).subscribe((response) => {
      this.rolUsersDto = response.data;
    });
  }
}
