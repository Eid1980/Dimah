import { Component, OnInit } from '@angular/core';
import { AccountService } from '@shared/proxy/accounts/account.service';
import { GetUserProfileData } from '@shared/proxy/accounts/models';
import { DailyRequestService } from '@shared/proxy/daily-requests/daily-request.service';
import { GetDailyRequestDetailsListDto, RequestProfileDto } from '@shared/proxy/daily-requests/models';
import { MessageType } from '@shared/enums/message-type.enum';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html'
})
export class ProfileComponent implements OnInit {
  showRolesDialog: boolean = false;
  showDeleteModal: boolean = false;
  operationId: string = '';

  userProfileData = {} as GetUserProfileData;
  requestProfileDto = {} as RequestProfileDto;
  dailyRequestDetailsListDto = [] as GetDailyRequestDetailsListDto[];

  constructor(private _accountService: AccountService, private dailyRequestService: DailyRequestService,
    private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.getProfileData();

    let userId =  JSON.parse(localStorage.getItem("AuthUser")).id;
    this._accountService.getUserProfileData(userId).subscribe(
      (response) => {
        if(response.isSuccess)
        this.userProfileData = response.data
      } , () => {});
  }

  getProfileData() {
    this.dailyRequestService.getRequestProfile().subscribe((res) => {
      this.requestProfileDto = res.data;
    });
  }

  previewDetailsDialog(id: string) {
    if (id) {
      this.dailyRequestService.getRequestDetailsById(id).subscribe((response) => {
        this.dailyRequestDetailsListDto = response.data;
      });
      this.showRolesDialog = true;
    }
  }
  closeDetailsDialog() {
    this.dailyRequestDetailsListDto = [];
    this.showRolesDialog = false;
  }
  //#region Delete
  openDeleteModal(id: string) {
    this.operationId = id;
    this.showDeleteModal = true;
  }
  closeDeleteModal() {
    this.operationId = '';
    this.showDeleteModal = false;
  }
  deleteItem() {
    if (this.operationId) {
      this.dailyRequestService.delete(this.operationId).subscribe((result) => {
        if (result.isSuccess) {
          this.getProfileData();
        }
        this.globalService.showMessage(result.message);
      });
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, 'برجاء اختيار العنصر الذي تريد حذفة أولا');
    }
    this.closeDeleteModal();
  }
  //#endregion

}
