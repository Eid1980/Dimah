import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { CreateUserRoleDto, GetRolUsersDto, GetUserRoleListDto } from './models';

@Injectable({
  providedIn: 'root',
})
export class UserRoleService {
  serviceUrl: string = `${environment.ApiUrl}/api/UserRole`;
  constructor(public httpClient: HttpClient) {
  }

  getUsersByRoleId = (roleId: number): Observable<ApiResponse<GetRolUsersDto[]>> => {
    return this.httpClient.get<ApiResponse<GetRolUsersDto[]>>(`${this.serviceUrl}/GetUsersByRoleId/${roleId}`).pipe(
    );
  }
  getRolesByUserId = (userId: number): Observable<ApiResponse<GetUserRoleListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetUserRoleListDto[]>>(`${this.serviceUrl}/GetRolesByUserId/${userId}`).pipe(
    );
  }
  isAuthorize = (roles: string): Observable<ApiResponse<GetRolUsersDto[]>> => {
    return this.httpClient.get<ApiResponse<GetRolUsersDto[]>>(`${this.serviceUrl}/IsAuthorize/${roles}`).pipe(
    );
  }

  create = (createdDto: CreateUserRoleDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }

  delete = (id: number): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

}
