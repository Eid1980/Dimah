import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ApiResponse } from '../shared/api-response.model';
import { LookupDto, LookupExtention } from '../shared/lookup-dto.model';

@Injectable({
  providedIn: 'root'
})
export class LookupService {
  serviceUrl: string = `${environment.ApiUrl}/api/Lookup`;
  constructor(public httpClient: HttpClient) {
  }

  getMaritalStatusLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetMaritalStatusLookupList`).pipe(
    );
  }
  getGovernorateLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetGovernorateLookupList`).pipe(
    );
  }
  getNationalityLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetNationalityLookupList`).pipe(
    );
  }
  getDefendantTypeLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetDefendantTypeLookupList`).pipe(
    );
  }
  getBuildingTypeLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetBuildingTypeLookupList`).pipe(
    );
  }
  getReligionLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetReligionLookupList`).pipe(
    );
  }
  getCommentStageLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetCommentStageLookupList`).pipe(
    );
  }
  getContactUsMessageTypeLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetContactUsMessageTypeLookupList`).pipe(
    );
  }
  getOpenDataSubCategueryLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetOpenDataSubCategueryLookupList`).pipe(
    );
  }

  getExtentionList = (): LookupExtention[] => {
    return [
      { name: 'Images', code: 'image/*' },
      { name: 'Pdf', code: '.pdf' },
      { name: 'Word', code: 'application/msmsword' },
      { name: 'Excell', code: 'application/msexcel' }
      //{ name: 'Excell', code: 'xlsm,application/msexcel' }
    ];
  }
}
