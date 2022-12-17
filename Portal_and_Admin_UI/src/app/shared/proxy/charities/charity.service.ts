import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { CreateCharityDto, GetCharityDetailsDto, UpdateCharityDto } from './models';
import { ApiResponse } from '../shared/api-response.model';
import { LookupDto } from '../shared/lookup-dto.model';

@Injectable({
  providedIn: 'root',
})
export class CharityService {
  serviceUrl: string = `${environment.ApiUrl}/api/Charity`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: string): Observable<ApiResponse<GetCharityDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetCharityDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }

  create = (createdDto: CreateCharityDto): Observable<ApiResponse<string>> => {
    return this.httpClient.post<ApiResponse<string>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateCharityDto): Observable<ApiResponse<string>> => {
    return this.httpClient.put<ApiResponse<string>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

  changeStatus = (id: string): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  }

  delete = (id: string): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

  getLookupList = (): Observable<ApiResponse<LookupDto<string>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<string>[]>>(`${this.serviceUrl}/GetLookupList`).pipe(
    );
  }

}
