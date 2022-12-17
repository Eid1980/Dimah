import { Router } from '@angular/router';
import { Injectable } from '@angular/core';
import { HttpErrorResponse } from '@angular/common/http';
import { Subject, throwError } from 'rxjs';
import { MessageType } from '@shared/enums/message-type.enum';
import { GlobalOptions } from './global-options';
import { FormArray, FormControl, FormGroup } from '@angular/forms';
import { MenuItem, MessageService } from 'primeng/api';
import { Title } from '@angular/platform-browser';
import { environment } from 'src/environments/environment';
import * as CryptoTS from 'crypto-ts';
import { TranslateService } from '@ngx-translate/core';

@Injectable({
  providedIn: 'root',
})
export class GlobalService {
  cryptionKey: string = environment.cryptionKey ? environment.cryptionKey : 'Emirates@2023';

  constructor(private titleService: Title, private messageService: MessageService,
    private translateService: TranslateService, private router: Router)
  {
  }

  public setTitle(newTitle: string) {
    this.titleService.setTitle(this.translateService.instant('dimah') + ' | ' + newTitle);
  }
  public setAdminTitle(newTitle: string) {
    this.titleService.setTitle(this.translateService.instant('controlPanel') + ' | ' + newTitle);
  }
  translate(key: string): any {
    return this.translateService.instant(key);
  }

  //#region Messaging
  public messageAlert(messageType: MessageType, message: string) {
    this.clearMessages();
    switch (messageType) {
      case MessageType.Success:
        this.messageService.add({ severity: 'success', summary: 'عملية ناجحة', detail: message });
        break;
      case MessageType.Info:
        this.messageService.add({ severity: 'info', summary: '', detail: message });
        break;
      case MessageType.Warning:
        this.messageService.add({ severity: 'warn', summary: 'تنبيه', detail: message });
        break;
      case MessageType.Error:
        this.messageService.add({ severity: 'error', summary: 'خطأ', detail: message });
        break;
    }
  }

  public showMessage(msg: string): void {
    if (msg) {
      var msgArray = msg.split(',');
      this.messageService.add({ severity: msgArray[0], summary: msgArray[1], detail: msgArray[2] });
    }
  }

  public showConfirm(message: string) {
    this.clearMessages();
    this.messageService.add({ key: 'confirm', sticky: true, severity: 'warn', summary: message });
  }
  confirm() {
    this.confirmSubmit();
  }

  confirmSubmit: Function;
  public clearMessages() {
    this.messageService.clear('confirm');
  }
  //#endregion

  convertToHijri(date, lang) {
    var date = date || new Date();
    lang = lang || 'en';
    var options = {
      year: 'numeric',
      month: 'long',
      day: 'numeric',
      weekday: 'long',
    };
    return date.toLocaleString(lang + '-u-ca-islamic', options);
  }

  getFullDate(date, lang) {
    if (!date) {
      date = new Date();
    }
    if (!lang) {
      lang = 'ar';
    }

    let hijrioptions = {
      year: 'numeric',
      month: 'long',
      day: 'numeric',
      weekday: 'long',
    };
    let hijriDate = date.toLocaleString(lang + '-u-ca-islamic', hijrioptions);
    let gregorianoptions = {
      year: 'numeric',
      month: 'long',
      day: 'numeric'
    };
    if (lang != 'ar') {
      let gregorianDate = date.toLocaleString(lang + '-sa-u-nu-latn', gregorianoptions);
      return `${hijriDate} - ${gregorianDate}`;
    }
    else {
      let months = ["يناير", "فبراير", "مارس", "إبريل", "مايو", "يونيو", "يوليو", "أغسطس", "سبتمبر", "أكتوبر", "نوفمبر", "ديسمبر"];
      return `${hijriDate} - ${date.getDate()} ${months[date.getMonth()]} ${date.getFullYear()} م`;
    }
  }

  errorHandler(error: HttpErrorResponse) {
    if (error.status === 401) {
      this.messageService.add({ severity: 'error', summary: '', detail: 'ليس لديك صلاحية لدخول هذة الصفحة' });
      setTimeout(() => {
        document.location.href = '/auth/login';
      }, 3000);
    } else {
      this.messageService.add({ severity: 'error', summary: '', detail: 'حدث خطأ ما من قبل الخادم (server)' });
    }
    return throwError(error);
  }

  //#region Cryption
  encrypt(encryptedMessage: string) {
    if (encryptedMessage) {
      return CryptoTS.AES.encrypt(encryptedMessage, this.cryptionKey).toString();
    }
    else {
      return null;
    }
  }
  decrypt(decryptedMessage: string) {
    if (decryptedMessage) {
      const bytes = CryptoTS.AES.decrypt(decryptedMessage, this.cryptionKey);
      return bytes.toString(CryptoTS.enc.Utf8);
    }
    else {
      return null;
    }
  }

  encryptNumber(encryptedMessage: number) {
    if (encryptedMessage) {
      return CryptoTS.AES.encrypt(encryptedMessage.toString(), this.cryptionKey).toString();
    }
    else {
      return null;
    }
  }
  decryptNumber(decryptedMessage: string) {
    if (decryptedMessage) {
      const bytes = CryptoTS.AES.decrypt(decryptedMessage, this.cryptionKey);
      return +bytes.toString(CryptoTS.enc.Utf8);
    }
    else {
      return null;
    }
  }
  //#endregion

  //#region navigation
  navigate(url: string) {
    this.router.navigate([url]);
  }
  navigateParams(url: string, params: any) {
    this.router.navigate([url, params]);
  }
  navigateToInbox() {
    this.router.navigate(["/admin/eservice-admin/inbox"]);
  }
  navigateToRequesterDashboard() {
    this.router.navigate(["/eservice/my-requests"]);
  }
  //#endregion

  //#region markAllControls
  markAllControls(formGroup: FormGroup, options?: Partial<GlobalOptions.ControlOptions>) {
    const defaultOptions = { markAsDirty: true, updateValueAndValidity: true } as GlobalOptions.ControlOptions;
    this.markFormGroup(formGroup, { ...defaultOptions, ...options });
  }

  markFormGroup(formGroup: FormGroup, options: GlobalOptions.ControlOptions) {
    Object.keys(formGroup.controls).forEach(key => {
      if (formGroup.get(key) instanceof FormGroup) {
        this.markFormGroup(formGroup.get(key) as FormGroup, options);
      }
      else if (formGroup.get(key) instanceof FormArray) {
        this.markFormArray(formGroup.get(key) as FormArray, options);
      }
      else if (formGroup.get(key) instanceof FormControl) {
        this.markFormControl(formGroup.get(key) as FormControl, options);
      }
    });
  }

  markFormArray(formArray: FormArray, options: GlobalOptions.ControlOptions) {
    formArray.controls.forEach(control => {
      if (control instanceof FormGroup) {
        this.markFormGroup(control as FormGroup, options);
      }
      else if (control instanceof FormArray) {
        this.markFormArray(control as FormArray, options);
      }
      else if (control instanceof FormControl) {
        this.markFormControl(control as FormControl, options);
      }
    });
  }

  markFormControl(formControl: FormControl, options: GlobalOptions.ControlOptions) {
    if (options.markAsDirty) formControl.markAsDirty();
    if (options.updateValueAndValidity) formControl.updateValueAndValidity();
  }
  //#endregion

  //#region Breadcrumb
  _breadcrumbItems = [] as MenuItem[];
  subject = new Subject();
  changeBreadcrumbItems(breadcrumbItems: MenuItem[]) {
    this._breadcrumbItems = breadcrumbItems;
    this.subject.next(this._breadcrumbItems);
  }
  //#endregion


}
