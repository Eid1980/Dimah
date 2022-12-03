import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreateUserDto} from '@shared/proxy/accounts/register.model';
import { DateFormatterService, DateType } from 'ngx-hijri-gregorian-datepicker';
import { GlobalService } from '@shared/services/global.service';
import { AccountService } from '@shared/proxy/accounts/account.service';
import { LookupDto } from '@shared/proxy/shared/lookup-dto.model';
import { LookupService } from '@shared/proxy/shared/lookup.service';
import { UserLoginDto } from '@shared/proxy/accounts/models';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { MessageType } from '@shared/enums/message-type.enum';
import { NationalityIDValidator } from '@shared/custom-validators/nationalityId.validator';
import { MobileNumberValidator } from '@shared/custom-validators/mobileNumber.validator';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
})
export class RegisterComponent implements OnInit {
  userRegisterForm: FormGroup;
  isFormSubmitted: boolean = false;
  showCheckUserRegisterForm: boolean = true;

  createUserDto = {} as CreateUserDto;
  nationalities = [] as LookupDto<number>[];

  constructor(
    private formBuilder: FormBuilder,
    private globalService: GlobalService,
    private accountService: AccountService,
    private lookupService: LookupService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تسجيل مستخدم جديد');
    this.fillLookup();
    this.buildRegisterForm();
  }
  buildRegisterForm() {
    this.userRegisterForm = this.formBuilder.group({
      userName: [this.createUserDto.userName || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      passWord: [this.createUserDto.passWord || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, Validators.pattern('^(?=.*[A-Z])(?=.*[!@#$&*])(?=.*[0-9])(?=.*[a-z]).{8,20}$')]],
      confirmPassWord: [this.createUserDto.confirmPassWord || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, Validators.pattern('^(?=.*[A-Z])(?=.*[!@#$&*])(?=.*[0-9])(?=.*[a-z]).{8,20}$')]],

      fullNameAr: [this.createUserDto.fullNameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      fullNameEn: [this.createUserDto.fullNameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],

      phoneNumber: [this.createUserDto.phoneNumber || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, MobileNumberValidator.validateMobileNumber]],
      email: [this.createUserDto.email || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, Validators.email]],
      isMale: [this.createUserDto.isMale || null, Validators.required],
      nationalityId: [this.createUserDto.nationalityId || null],
    }, {
      validators: this.comparePassword('passWord', 'confirmPassWord')
    });
  }

  comparePassword(controlName: string, matchControlName: string) {
    return (formGroup: FormGroup) => {
      const control = formGroup.controls[controlName];
      const matchControl = formGroup.controls[matchControlName];
      if (matchControl.errors && !matchControl.errors.notMatch) {
        return;
      }
      if (control.value !== matchControl.value) {
        matchControl.setErrors({ notMatch: true });
      }
      else {
        matchControl.setErrors(null);
      }
    }
  }

  onRegister() {
    this.isFormSubmitted = true;
    if (this.userRegisterForm.valid) {
      this.createUserDto = { ...this.userRegisterForm.value } as CreateUserDto;
      this.accountService.register(this.createUserDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          this.login();
        }
      });
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, 'برجاء استكمال البيانات المطلوبة');
    }
  }
  fillLookup() {
    this.lookupService.getNationalityLookupList().subscribe((response) => {
      this.nationalities = response.data;
    });
  }
  login() {
    let userLoginDto = { userName: this.createUserDto.userName, password: this.createUserDto.passWord } as UserLoginDto;
    this.accountService.login(userLoginDto).subscribe((response) => {
        if (response.isSuccess) {
          localStorage.setItem('EmiratesToken', response.data);
          this.globalService.navigate('/home/');
        }
      },
      (error) => {
        this.globalService.navigate('/auth/login');
      }
    );
  }
}
