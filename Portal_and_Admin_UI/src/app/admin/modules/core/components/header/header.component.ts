import { Component, OnInit } from '@angular/core';
import { AccountService } from '@proxy/accounts/account.service';
import { GetUserSessionDto } from '@shared/proxy/accounts/models';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html'
})
export class HeaderComponent implements OnInit {
  userInfo = {} as GetUserSessionDto;

  constructor(private accountService: AccountService) { }

  ngOnInit() {
    this.userInfo = this.accountService.getCurrentUserInfo();
  }

  logOut() {
    this.accountService.logOut();
  }

  changeLang() {
    console.log("changed");
  }
}
