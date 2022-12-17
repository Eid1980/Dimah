import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { CreateCharityProjectDto, GetCharityProjectDetailsDto, GetCharityProjectListDto, UpdateCharityProjectDto } from './models';
import { ApiResponse } from '../shared/api-response.model';
import { LookupDto } from '../shared/lookup-dto.model';
import { FileToUploadDto } from '../shared/file-to-upload-dto.model';

@Injectable({
  providedIn: 'root',
})
export class CharityProjectService {
  serviceUrl: string = `${environment.ApiUrl}/api/CharityProject`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: string): Observable<ApiResponse<GetCharityProjectDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetCharityProjectDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }
  getByCharityId = (id: string): Observable<ApiResponse<GetCharityProjectListDto[]>> => {
    return this.httpClient.get<ApiResponse<GetCharityProjectListDto[]>>(`${this.serviceUrl}/GetByCharityId/${id}`).pipe(
    );
  }

  create = (createdDto: CreateCharityProjectDto): Observable<ApiResponse<FileToUploadDto>> => {
    return this.httpClient.post<ApiResponse<FileToUploadDto>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdateCharityProjectDto): Observable<ApiResponse<FileToUploadDto>> => {
    return this.httpClient.put<ApiResponse<FileToUploadDto>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

  changeStatus = (id: string): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  }

  delete = (id: string): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

  getLookupList = (): Observable<ApiResponse<LookupDto<number>[]>> => {
    return this.httpClient.get<ApiResponse<LookupDto<number>[]>>(`${this.serviceUrl}/GetLookupList`).pipe(
    );
  }

}
