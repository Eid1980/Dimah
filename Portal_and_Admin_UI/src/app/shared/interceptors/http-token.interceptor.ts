import { Injectable, Injector } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, finalize } from 'rxjs/operators';
import { GlobalService } from '@shared/services/global.service';
import { ProgressSpinnerService } from '@shared/services/progress-spinner.service';
import { Router, ActivatedRoute } from '@angular/router';
import { MessageType } from '@shared/enums/message-type.enum';

@Injectable({
  providedIn: 'root',
})
export class HttpTokenInterceptor implements HttpInterceptor {
  currentLanguage = 'ar';

  constructor(
    private progressSpinner: ProgressSpinnerService,
    private globalService: GlobalService
  ) {}

  intercept(
    req: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    this.progressSpinner.show();

    const token = localStorage.getItem('EmiratesToken');

    if (token) {
      req = req.clone({
        headers: req.headers.set('Authorization', 'Bearer ' + token),
      });
    }

    req = req.clone({ headers: req.headers.set('Accept', 'application/json') });

    return next.handle(req).pipe(
      finalize(() => {
        this.progressSpinner.hide();
      }),
      catchError((error) => {
        return this.errorHandler(error);
      })
    );
  }

  errorHandler(error: HttpErrorResponse) {
    if (error.statusText == 'Unknown Error') {
      this.globalService.messageAlert(MessageType.Error, 'الاتصال بالخادم غير متاح حاليا');
    }
    else {
      this.globalService.messageAlert(MessageType.Error, error.error);
    }
    // if (error.url.includes("IsAuthorizedComponent")) {
    //   this.globalService.messageAlert(
    //     MessageType.Error,
    //     "ليس لديك صلاحية لدخول هذة الصفحة"
    //   );
    //   setTimeout(() => {
    //     document.location.href = "/auth/login";
    //   }, 3000);
    // } else {
    // }
    return throwError(error);
  }
}
