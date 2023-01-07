import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { CreateDailyRequestDto, GetDailyRequestDetailsListDto, RequestDashBoardDto, RequestProfileDto } from './models';
import { ApiResponse } from '../shared/api-response.model';

@Injectable({
  providedIn: 'root',
})
export class DailyRequestService {
  serviceUrl: string = `${environment.ApiUrl}/api/DailyRequest`;
  constructor(public httpClient: HttpClient) {
  }

  create = (createdDto: CreateDailyRequestDto): Observable<ApiResponse<string>> => {
    return this.httpClient.post<ApiResponse<string>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  
  payRequest = (id: string): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/PayRequest/${id}`).pipe();
  }
  
  getRequestProfile = (): Observable<ApiResponse<RequestProfileDto>> => {
    return this.httpClient.get <ApiResponse<RequestProfileDto>>(`${this.serviceUrl}/GetRequestProfile`).pipe(
    );
  }
  getRequestDashBoard = (): Observable<ApiResponse<RequestDashBoardDto>> => {
    return this.httpClient.get<ApiResponse<RequestDashBoardDto>>(`${this.serviceUrl}/GetRequestDashBoard`).pipe(
    );
  }

  getRequestDetailsById = (id: string): Observable<ApiResponse<GetDailyRequestDetailsListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetDailyRequestDetailsListDto[]>>(`${this.serviceUrl}/GetRequestDetailsById/${id}`).pipe();
  }

  delete = (id: string): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }
}
