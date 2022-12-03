import { Component, OnInit } from '@angular/core';
import { AccountService } from '@proxy/accounts/account.service';

@Component({
  selector: 'app-view-profile',
  templateUrl: './view-profile.component.html',
  styleUrls: ['./view-profile.component.scss']
})
export class ViewProfileComponent implements OnInit {
 userInfo:any;

  constructor(private accountService: AccountService) { }

  ngOnInit() {
    this.userInfo = this.accountService.getCurrentUserInfo();
  }

}
