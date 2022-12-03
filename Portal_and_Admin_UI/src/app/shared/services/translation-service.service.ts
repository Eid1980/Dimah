import { Injectable } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { LanguageDirection } from '@shared/enums/language-direction';
import { Languages } from '@shared/enums/languages';
import { LanguageModel } from '@shared/models/language-model';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TranslationServiceService {
  private currentLang: LanguageModel = {
    Name: Languages.Arabic,
    Direction: LanguageDirection.RightToLeft,
  };
  // Observable Source
  private languageChangeSource = new Subject<LanguageModel>();

  // Observable Stream
  languageChange = this.languageChangeSource.asObservable();

  constructor(private translateService: TranslateService) {
    translateService.onLangChange.subscribe(l => {
      this.languageChangeSource.next(this.currentLang);
    })
  }

  initializeLanguage() {
    if (
      !localStorage.getItem('lang') ||
      localStorage.getItem('lang') === null
    ) {

      localStorage.setItem('lang', this.currentLang.Name);
    }
    const langName =
      localStorage.getItem('lang') !== null
        ? localStorage.getItem('lang')
        : this.currentLang.Name;

    this.currentLang.Name = langName as Languages;
    this.currentLang.Direction =
      this.currentLang.Name == Languages.English
        ? LanguageDirection.LeftToRight
        : LanguageDirection.RightToLeft;

    this.translateService.use(this.currentLang.Name);
    document.getElementsByTagName('html')[0].setAttribute('dir', this.currentLang.Direction);
    document.getElementsByTagName('html')[0].setAttribute('lang', localStorage.getItem('lang'));
  }

  switchLanguage() {
    window.location.reload();
    if (this.currentLang.Name == Languages.Arabic) {
      this.currentLang.Name = Languages.English;
      this.currentLang.Direction = LanguageDirection.LeftToRight;
    } else {
      this.currentLang.Name = Languages.Arabic;
      this.currentLang.Direction = LanguageDirection.RightToLeft;
    }
    localStorage.setItem('lang', this.currentLang.Name);
    this.translateService.use(this.currentLang.Name);
  }

  instant(key: string): any {
    return this.translateService.instant(key);
  }

  getCurrentLanguage(): LanguageModel {
    const langName =
      localStorage.getItem('lang') !== null
        ? localStorage.getItem('lang')
        : this.currentLang.Name;

    this.currentLang.Name = langName as Languages;
    this.currentLang.Direction =
      this.currentLang.Name == Languages.English
        ? LanguageDirection.LeftToRight
        : LanguageDirection.RightToLeft;

    return this.currentLang;
  }
}
