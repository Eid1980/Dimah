import { Component, Input, OnInit } from '@angular/core';
import { AccountService } from '@proxy/accounts/account.service';
import { GetUserDataDto } from '@proxy/accounts/models';

@Component({
  selector: 'app-user-data-view',
  templateUrl: './user-data-view.component.html'
})
export class UserDataViewComponent implements OnInit {
  userDataDto = {} as GetUserDataDto;

  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
  }

  initializeForm(userId?: number) {
    if (userId) {
      this.accountService.getUserData(userId).subscribe((response) => {
        this.userDataDto = response.data;
      });
    }
  }

}
