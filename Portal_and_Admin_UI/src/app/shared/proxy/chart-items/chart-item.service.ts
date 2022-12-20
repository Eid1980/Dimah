import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { CreateChartItemDto, CurrentChartListDto, GetChartItemDetailsDto, UpdateChartItemDto } from './models';
import { ApiResponse } from '../shared/api-response.model';

@Injectable({
  providedIn: 'root',
})
export class ChartItemService {
  serviceUrl: string = `${environment.ApiUrl}/api/ChartItem`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: string): Observable<ApiResponse<GetChartItemDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetChartItemDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getCurrentChart = (): Observable<ApiResponse<CurrentChartListDto[]>> => {
    return this.httpClient.get<ApiResponse<CurrentChartListDto[]>>(`${this.serviceUrl}/GetCurrentChart`).pipe();
  }
  getCurrentChartCount = (): Observable<ApiResponse<number>> => {
    return this.httpClient.get<ApiResponse<number>>(`${this.serviceUrl}/GetCurrentChartCount`).pipe();
  }

  create = (createdDto: CreateChartItemDto): Observable<ApiResponse<number>> => {
    return this.httpClient.post<ApiResponse<number>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateChartItemDto): Observable<ApiResponse<number>> => {
    return this.httpClient.put<ApiResponse<number>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

  delete = (id: string): Observable<ApiResponse<number>> => {
    return this.httpClient.delete<ApiResponse<number>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

  finishPayment = (): Observable<ApiResponse<string>> => {
    return this.httpClient.put<ApiResponse<string>>(`${this.serviceUrl}/FinishPayment`, null).pipe();
  }

}
