import { Component, OnInit } from '@angular/core';
import { AccountService } from '@proxy/accounts/account.service';
import { GetUserSessionDto } from '@shared/proxy/accounts/models';
import { TranslationServiceService } from '@shared/services/translation-service.service';
import { GlobalService } from '@shared/services/global.service';
import { MessageType } from '@shared/enums/message-type.enum';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
})
export class HeaderComponent implements OnInit {
  currentDate: string;
  userInfo = {} as GetUserSessionDto;
  isAuthenticated: boolean;
  newsSearch: string;

  constructor(private accountService: AccountService, private translateService: TranslationServiceService,
    private globalService: GlobalService)
  {
  }

  ngOnInit() {
    this.currentDate = this.globalService.getFullDate(null, this.translateService.getCurrentLanguage().Name.toLowerCase());
    this.isAuthenticated = this.isUserAuthenticate();
    if (this.isAuthenticated){
      this.userInfo = this.accountService.getCurrentUserInfo();
    }
  }

  logOut() {
    this.accountService.logOut();
  }

  isUserAuthenticate(): boolean {
    if (localStorage.getItem('EmiratesToken') === null || localStorage.getItem('EmiratesToken') === undefined) {
      return false;
    }
    else {
      return true;
    }
  }

  get currentLang() {
    return this.translateService.getCurrentLanguage().Name;
  }

  onChangeLang() {
    this.translateService.switchLanguage();
  }

  newsSearchSubmit() {
    if (this.newsSearch) {
      this.globalService.navigateParams("/home/news-search", { filter: this.newsSearch });
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, "برجاء ادخال كلمات البحث أولا");
    }
  }
}
