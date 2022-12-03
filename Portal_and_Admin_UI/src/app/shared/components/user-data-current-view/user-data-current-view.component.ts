import { Component, OnInit } from '@angular/core';
import { AccountService } from '@proxy/accounts/account.service';
import { GetUserDataDto } from '@proxy/accounts/models';

@Component({
  selector: 'app-user-data-current-view',
  templateUrl: './user-data-current-view.component.html'
})
export class UserDataCurrentViewComponent implements OnInit {
  userDataDto = {} as GetUserDataDto;

  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
    this.getUserDetails();
  }

  getUserDetails() {
    this.accountService.getUserData().subscribe((response) => {
      this.userDataDto = response.data;
    });
  }
}
