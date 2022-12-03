import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { AccountService } from '@proxy/accounts/account.service';
import { UserLoginDto } from '@proxy/accounts/models';
import { TranslationServiceService } from '@shared/services/translation-service.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  templateUrl: './login.component.html',
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;
  userLoginDto = {} as UserLoginDto;
  isFormSubmitted: boolean = false;
  returnUrl: string;

  constructor(private formBuilder: FormBuilder, private _accountService: AccountService,
    private router: Router, private globalService: GlobalService,
    private _translateService: TranslationServiceService, private activatedRoute: ActivatedRoute)
  {
  }

  ngOnInit() {
    this.globalService.setTitle("تسجيل دخول مستخدم");
    this.returnUrl = this.activatedRoute.snapshot.queryParams['returnUrl'];
    this.buildForm();
  }

  buildForm() {
    this.loginForm = this.formBuilder.group({
      userName: [this.userLoginDto.userName, [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      password: [this.userLoginDto.password, [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.loginForm.valid) {
      this.userLoginDto = { ...this.loginForm.value } as UserLoginDto;
      this._accountService.login(this.userLoginDto).subscribe(response => {
          if (response.isSuccess) {
            localStorage.setItem('EmiratesToken', response.data);
            this._accountService.getAuthUser().subscribe((res) => {
              localStorage.setItem('AuthUser', JSON.stringify(res.data));

              if (this.returnUrl) {
                this.router.navigateByUrl(this.returnUrl);
              } else {
                this.router.navigate(['/']);
              }
            });
          }
        });
    }
  }

  // Translations
  get currentLang() {
    return this._translateService.getCurrentLanguage().Name;
  }

  onChangeLang() {
    this._translateService.switchLanguage();
  }
}
