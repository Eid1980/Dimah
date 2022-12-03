import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { DropdownModule } from 'primeng/dropdown';
import { PaginatorModule } from 'primeng/paginator';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { TableModule } from 'primeng/table';
import { CalendarModule } from 'primeng/calendar';
import { ContextMenuModule } from 'primeng/contextmenu';
import { InputMaskModule } from 'primeng/inputmask';
import { AutoCompleteModule } from 'primeng/autocomplete';
import { RouterModule } from '@angular/router';
import { SharedRoutingModule } from './shared-routing.module';
import { InputSwitchModule } from 'primeng/inputswitch';
import { DialogModule } from 'primeng/dialog';
import { TooltipModule } from 'primeng/tooltip';
import { MultiSelectModule } from 'primeng/multiselect';
import { RatingModule } from 'primeng/rating';
import { AuthGuard } from './guards/auth.guard';
import { ProgressSpinnerComponent } from './components/progress-spinner/progress-spinner.component';
import { PageListComponent } from './components/page-list/page-list.component';
import { DataListComponent } from './components/data-list/data-list.component';
import { AuthorizeDirective } from './directives/authorize.directive';
import { HiddenAuthorizeColumnFilterPipe } from './pipes/hidden-authorize-coulmn-filter.pipe';
import { ViewProfileComponent } from './components/view-profile/view-profile.component';
import { FileUploadModule } from 'primeng/fileupload';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { MessageService } from 'primeng/api';
import { AuthLayoutComponent } from './components/auth-layout/auth-layout.component';
import { NotAuthorizedComponent } from './components/not-authorized/not-authorized.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { NgxHijriGregorianDatepickerModule } from 'ngx-hijri-gregorian-datepicker';
import { UserDataViewComponent } from './components/user-data-view/user-data-view.component';
import { UserDataCurrentViewComponent } from './components/user-data-current-view/user-data-current-view.component';
import { BreadcrumbModule } from 'primeng/breadcrumb';
import { ToastModule } from 'primeng/toast';
import { CustomSlicePipe } from './pipes/custom-slice.pipe';
import { HttpClient } from '@angular/common/http';
import { TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import {ButtonModule} from 'primeng/button';
import { FullDatePipe } from './pipes/full-date.pipe';
import { ListStringPipe } from './pipes/list-string.pipe';
import { AgmCoreModule } from '@agm/core';
import { NgxCaptchaModule } from 'ngx-captcha'

@NgModule({
  declarations: [
    AuthLayoutComponent,
    NotAuthorizedComponent,
    PageNotFoundComponent,
    HiddenAuthorizeColumnFilterPipe,
    ProgressSpinnerComponent,
    PageListComponent,
    DataListComponent,
    AuthorizeDirective,
    ViewProfileComponent,
    UserDataViewComponent,
    UserDataCurrentViewComponent,
    CustomSlicePipe,
    FullDatePipe,
    ListStringPipe
  ],
  imports: [
    CommonModule,
    ProgressSpinnerModule,
    AutoCompleteModule,
    PaginatorModule,
    InputMaskModule,
    TableModule,
    CalendarModule,
    AutoCompleteModule,
    ReactiveFormsModule,
    FormsModule,
    RouterModule,
    SharedRoutingModule,
    InputSwitchModule,
    FileUploadModule,
    ConfirmDialogModule,
    BreadcrumbModule,
    ToastModule,
    ButtonModule,
    DialogModule,
    TooltipModule,
    MultiSelectModule,
    RatingModule,
    NgxHijriGregorianDatepickerModule,
    AgmCoreModule.forRoot({
      apiKey: ''
    }),
    NgxCaptchaModule
  ],
  exports: [
    AuthLayoutComponent,
    NotAuthorizedComponent,
    PageNotFoundComponent,
    PageListComponent,
    DataListComponent,
    TableModule,
    AutoCompleteModule,
    ReactiveFormsModule,
    FormsModule,
    DropdownModule,
    CommonModule,
    ProgressSpinnerModule,
    AutoCompleteModule,
    CalendarModule,
    ReactiveFormsModule,
    ContextMenuModule,
    InputMaskModule,
    PaginatorModule,
    HiddenAuthorizeColumnFilterPipe,
    FullDatePipe,
    ListStringPipe,
    InputSwitchModule,
    ToastModule,
    DialogModule,
    TooltipModule,
    MultiSelectModule,
    DatePipe,
    FileUploadModule,
    ConfirmDialogModule,
    NgxHijriGregorianDatepickerModule,
    UserDataViewComponent,
    UserDataCurrentViewComponent,
    CustomSlicePipe,
    TranslateModule,
    ButtonModule,
    AgmCoreModule,
    NgxCaptchaModule
  ],
  providers: [
    HiddenAuthorizeColumnFilterPipe,
    AuthGuard,
    DatePipe,
    MessageService
  ],
})
export class SharedModule {}

// required for AOT compilation
export function HttpLoaderFactory(http: HttpClient) {
  return new TranslateHttpLoader(http);
}
