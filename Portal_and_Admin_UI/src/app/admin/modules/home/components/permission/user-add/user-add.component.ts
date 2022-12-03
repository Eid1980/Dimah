import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { GetUserDto } from '@shared/proxy/accounts/models';
import { AccountService } from '@shared/proxy/accounts/account.service';
import { MessageType } from '@shared/enums/message-type.enum';

@Component({
  selector: 'app-user-add',
  templateUrl: './user-add.component.html'
})
export class UserAddComponent implements OnInit {
  createUserForm: FormGroup;
  isFormSubmitted: boolean;
  canAdd: boolean;
  userName: string;
  userDataDto = {} as GetUserDto;

  constructor(private formBuilder: FormBuilder, private accountService: AccountService,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة مستخدم جديد');
    this.buildForm();
  }

  buildForm() {
    this.createUserForm = this.formBuilder.group({
      userName: [this.userName || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
    });
  }

  checkUser() {
    this.userName = this.createUserForm.value["userName"];
    if (this.userName) {
      this.accountService.getByUserName(this.userName).subscribe((response) => {
        if (response.isSuccess) {
          if (response.data.isEmployee) {
            this.globalService.messageAlert(MessageType.Warning, "المستخدم مضاف مسبقا");
            this.canAdd = false;
            this.userDataDto = {} as GetUserDto;
          }
          else {
            this.canAdd = true;
            this.userDataDto = response.data;
          }
        }
        else {
          this.globalService.messageAlert(MessageType.Warning, "اسم المستخدم غير مسجل بالنظام برجاء التسجيل أولا");
        }
      });
    }
    else {
      this.globalService.messageAlert(MessageType.Error, "برجاء ادخال اسم المستخدم أولا");
    }
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createUserForm.valid) {
      this.accountService.createEmployee(this.userDataDto.id).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.globalService.navigate("/admin/home/user-list");
        }
      });
    }
  }

}
