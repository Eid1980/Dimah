import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { DimahProjectsListDto, ProjectDetailsDto } from './models';
import { ApiResponse } from '../shared/api-response.model';

@Injectable({
  providedIn: 'root',
})
export class HomeService {
  serviceUrl: string = `${environment.ApiUrl}/api/Home`;
  constructor(public httpClient: HttpClient) {
  }

  getCharityProjects = (id: string): Observable<ApiResponse<DimahProjectsListDto[]>> => {
    return this.httpClient.get<ApiResponse<DimahProjectsListDto[]>>(`${this.serviceUrl}/GetCharityProjects/${id}`).pipe();
  }

  getDimahTopProjects = (): Observable<ApiResponse<DimahProjectsListDto[]>> => {
    return this.httpClient.get<ApiResponse<DimahProjectsListDto[]>>(`${this.serviceUrl}/GetDimahTopProjects`).pipe();
  }

  getProjectDetails = (id: string): Observable<ApiResponse<ProjectDetailsDto>> => {
    return this.httpClient.get<ApiResponse<ProjectDetailsDto>>(`${this.serviceUrl}/GetProjectDetails/${id}`).pipe();
  }


}
