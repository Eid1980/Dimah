import { Component, OnInit } from '@angular/core';
import { AccountService } from '@shared/proxy/accounts/account.service';
import { GetUserProfileData } from '@shared/proxy/accounts/models';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html'
})
export class ProfileComponent implements OnInit {

  userProfileData = {} as GetUserProfileData;

  constructor(private _accountService : AccountService) { }

  ngOnInit(): void {
    let userId =  JSON.parse(localStorage.getItem("AuthUser")).id;

    this._accountService.getUserProfileData(userId).subscribe(
      (response) => {
        if(response.isSuccess)
        this.userProfileData = response.data
      } , () => {});
  }

}
