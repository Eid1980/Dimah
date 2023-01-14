import { Component, OnInit } from '@angular/core';
import { AccountService } from '@proxy/accounts/account.service';
import { Role } from '@shared/enums/role.enum';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss'],
})
export class MenuComponent implements OnInit {
  roles: string;
  superSystemAdmin: string = Role.SuperSystemAdmin.toString();
  systemAdmin: string = Role.SystemAdmin.toString();
  settingPermission: string = Role.SettingPermission.toString();
  usersPermission: string = Role.UsersPermission.toString();

  constructor(private accountService: AccountService) {
  }

  ngOnInit() {
    this.accountService.getCurrentUserRoles().subscribe((response) => {
      this.roles = response.data;
    });
  }

  logOut() {
    this.accountService.logOut();
  }

}
