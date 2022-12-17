import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { CreatePosterDto, GetPosterDetailsDto, UpdatePosterDto } from './models';
import { ApiResponse } from '../shared/api-response.model';
import { FileToUploadDto } from '../shared/file-to-upload-dto.model';

@Injectable({
  providedIn: 'root',
})
export class PosterService {
  serviceUrl: string = `${environment.ApiUrl}/api/Poster`;
  constructor(public httpClient: HttpClient) {
  }

  getById = (id: string): Observable<ApiResponse<GetPosterDetailsDto>> => {
    return this.httpClient.get<ApiResponse<GetPosterDetailsDto>>(`${this.serviceUrl}/GetById/${id}`).pipe(
    );
  }

  getAll = () : Observable<ApiResponse<GetPosterDetailsDto[]>> =>{
    return this.httpClient.get<ApiResponse<GetPosterDetailsDto[]>>(`${this.serviceUrl}/GetAll`).pipe();
  }

  create = (createdDto: CreatePosterDto): Observable<ApiResponse<FileToUploadDto>> => {
    return this.httpClient.post<ApiResponse<FileToUploadDto>>(`${this.serviceUrl}/Create`, createdDto).pipe();
  }
  update = (updatedDto: UpdatePosterDto): Observable<ApiResponse<FileToUploadDto>> => {
    return this.httpClient.put<ApiResponse<FileToUploadDto>>(`${this.serviceUrl}/Update`, updatedDto).pipe();
  }

  changeStatus = (id: string): Observable<ApiResponse<boolean>> => {
    return this.httpClient.get<ApiResponse<boolean>>(`${this.serviceUrl}/ChangeStatus/${id}`).pipe();
  }

  delete = (id: string): Observable<ApiResponse<boolean>> => {
    return this.httpClient.delete<ApiResponse<boolean>>(`${this.serviceUrl}/Delete/${id}`).pipe();
  }

}
