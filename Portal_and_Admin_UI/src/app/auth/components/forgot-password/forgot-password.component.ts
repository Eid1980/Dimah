import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ForgetPasswordStages } from '@shared/enums/forget-password-stages.enum';
import { MessageType } from '@shared/enums/message-type.enum';
import { AccountService } from '@shared/proxy/accounts/account.service';
import { ForgetPasswordDto, ResetPasswordDto, ValidateOTPDto } from '@shared/proxy/accounts/models';
import { ApiResponse } from '@shared/proxy/shared/api-response.model';
import { GlobalService } from '@shared/services/global.service';
import { TranslationServiceService } from '@shared/services/translation-service.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-forgot-password',
  templateUrl: './forgot-password.component.html'
})
export class ForgotPasswordComponent implements OnInit {

  get currentLang() {
    return this._translateService.getCurrentLanguage().Name;
  }

  stage: number
  userName: string;
  otp: string;
  newPassword : string;

  forgetPasswordForm = this.fb.group({
    userName: ['', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
  });

  constructor(
    private _accountService: AccountService,
    private _translateService: TranslationServiceService,
    private fb: FormBuilder,
    private _router: Router,
    private _globalService: GlobalService,
  ) {

    this.userName = '';
    this.otp = '';
    this.newPassword = '';
    this.stage = ForgetPasswordStages.EnterUserName;
  }

  ngOnInit() {
  }


  forgetPassword() {
    let forgetPassword: ForgetPasswordDto = { userName: this.userName };

    this._accountService.forgetPassword(forgetPassword).subscribe(
      (result: any) => {
        if (result.isSuccess == true) {
          this._globalService.messageAlert(
            MessageType.Success,
            this._translateService.instant('forgetPassword.messages.sentConfirmOTP')
          );
          if (this.stage != ForgetPasswordStages.EnterOTP) {
            this.stage = ForgetPasswordStages.EnterOTP;
          }
        } else {
          this._globalService.messageAlert(
            MessageType.Error,
            this._translateService.instant('forgetPassword.messages.errorWhileSendingRequest')
          );
        }
      },
      () => { }
    );
  }

  validateOTP() {
    let validateOTP: ValidateOTPDto = { userName: this.userName, oTP: this.otp };

    this._accountService.validateOTP(validateOTP).subscribe(
      (result: ApiResponse<boolean>) => {
        if (result.isSuccess && result.data) {
          this._globalService.messageAlert(
            MessageType.Success,
            this._translateService.instant('forgetPassword.messages.otpIsCorrect')
          );

          this.stage = ForgetPasswordStages.SetNewPassword;
        } else {
          this._globalService.messageAlert(
            MessageType.Error,
            this._translateService.instant('forgetPassword.messages.invalidOTP')
          );
        }
      },
      (err) => { }
    );
  }

  resetPassword() {
    let resetPassword: ResetPasswordDto = { userName: this.userName, newPassword: this.newPassword };

    this._accountService.resetPassword(resetPassword).subscribe(
      (result: ApiResponse<boolean>) => {
        if (result.isSuccess && result.data) {
          this._globalService.messageAlert(
            MessageType.Success,
            this._translateService.instant('forgetPassword.messages.resetPasswordSuccessfuly')
          );
          setTimeout(() => {
            this._router.navigate(['/auth/login']);
          }, 3000);
        }
      },
      (err) => { }
    );
  }

  // change language
  onChangeLang() {
    this._translateService.switchLanguage();
  }

}
