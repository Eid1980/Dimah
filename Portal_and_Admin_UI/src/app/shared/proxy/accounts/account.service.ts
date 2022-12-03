import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { ForgetPasswordDto, GetUserDataDto, GetUserDto, GetUserProfileData, GetUserSessionDto, ResetPasswordDto, UpdateUserProfileDto, UserLoginDto, ValidateOTPDto } from './models';
import { ApiResponse } from '../shared/api-response.model';
import { CreateUserDto } from './register.model';

@Injectable({
  providedIn: 'root',
})
export class AccountService {
  serviceUrl: string = `${environment.ApiUrl}/api/Account`;
  constructor(public httpClient: HttpClient, private router: Router) {
  }

  login = (userLoginDto: UserLoginDto): Observable<ApiResponse<string>> => {
    return this.httpClient.post<ApiResponse<string>>(`${this.serviceUrl}/Login`, userLoginDto).pipe();
  }

  register = (createUserDto: CreateUserDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Register`, createUserDto).pipe();
  }
  createEmployee = (userId: number): Observable<ApiResponse<any>> => {
    return this.httpClient.get<ApiResponse<any>>(`${this.serviceUrl}/CreateEmployee/${userId}`).pipe();
  }
  deleteEmployee = (userId: number): Observable<ApiResponse<any>> => {
    return this.httpClient.get<ApiResponse<any>>(`${this.serviceUrl}/DeleteEmployee/${userId}`).pipe();
  }

  //isAuthorizedComponent = (componentURL): Observable<ApiResponse<GetUserDto>> => {
  //  return this.httpClient.get<ApiResponse<GetUserDto>>(`${this.serviceUrl}/IsAuthorizedComponent`).pipe(
  //  );
  //}
  //isAuthorizedComponent(componentURL) {
  //  return this.httpClient
  //    .get(`${this.serviceUrl}/IsAuthorizedComponent`, {
  //      params: { componentUrl: encodeURI(componentURL) },
  //    })
  //    .pipe(
  //      map((result: ResponseVM) => {
  //        const serviceResponse: ServiceResponseVM = {
  //          IsSuccess: result.isSuccess,
  //          Data: result.data,
  //        };
  //        return serviceResponse;
  //      })
  //    );
  //}

  isAuthorizedPermission = (code: string): boolean => {
    if (localStorage.getItem('AuthUser') != null) {
      const codes = (localStorage.getItem('AuthUser') as any).PermissionCodes;
      return codes.includes(code) || code === '*' || !code || code === '';
    }
    else {
      return false;
    }
  }

  logOut = (url?: string): void => {
    localStorage.removeItem('EmiratesToken');
    localStorage.removeItem('AuthUser');
    if (url) {
      this.router.navigate(['/auth/login'], { queryParams: { returnUrl: url } });
    }
    else {
      this.router.navigate(['/auth/login']);
    }
  }

  getCurrentUserInfo = (): GetUserSessionDto => {
    if (localStorage.getItem('AuthUser') === null || localStorage.getItem('AuthUser') === undefined) {
      this.router.navigate(['/auth/login']);
      return null;
    }
    else {
      return JSON.parse(localStorage.getItem('AuthUser'));
    }
  }

  getUserData = (id?: number): Observable<ApiResponse<GetUserDataDto>> => {
    return this.httpClient.get<ApiResponse<GetUserDataDto>>(`${this.serviceUrl}/GetUserData/${id}`).pipe();
  }
  getCurrentUserRoles = (): Observable<ApiResponse<string>> => {
    return this.httpClient.get<ApiResponse<string>>(`${this.serviceUrl}/GetCurrentUserRoles`).pipe();
  }

  getAuthUser = (): Observable<ApiResponse<GetUserSessionDto>> => {
    return this.httpClient.get<ApiResponse<GetUserSessionDto>>(`${this.serviceUrl}/GetAuthUser`).pipe();
  }
  getById = (id: number): Observable<ApiResponse<GetUserDto>> => {
    return this.httpClient.get<ApiResponse<GetUserDto>>(`${this.serviceUrl}/GetById/${id}`).pipe();
  }
  getByUserName = (userName: string): Observable<ApiResponse<GetUserDto>> => {
    return this.httpClient.get<ApiResponse<GetUserDto>>(`${this.serviceUrl}/GetByUserName/${userName}`).pipe();
  }

  getUserProfileData = (id: number): Observable<ApiResponse<GetUserProfileData>> => {
    return this.httpClient.get<ApiResponse<GetUserProfileData>>(`${this.serviceUrl}/GetUserProfileData/${id}`).pipe();
  }

  forgetPassword(foregetPassword : ForgetPasswordDto ){
    return this.httpClient.post(`${this.serviceUrl}/forgetPassword` , foregetPassword );
  }

  validateOTP(validateOTP : ValidateOTPDto){
    return this.httpClient.post(`${this.serviceUrl}/validateOTP` , validateOTP );
  }

  resetPassword(resetPassword : ResetPasswordDto){
    return this.httpClient.post(`${this.serviceUrl}/resetPassword` , resetPassword );
  }

  updateUserProfile = (userProfileDto : UpdateUserProfileDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/UpdateUserProfile` , userProfileDto).pipe();
  }

}
