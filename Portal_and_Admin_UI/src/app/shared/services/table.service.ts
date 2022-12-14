import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ServiceResponseVM, ResponseVM } from '@shared/models/response.model';
import { SearchModel } from '@proxy/shared/search-model.model';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class TableService {
  constructor(private httpClient: HttpClient) {}

  getListPage(
    serviceUrl: string,
    searchModel: SearchModel
  ): Observable<ServiceResponseVM> {
    const serviceResponseVM: ServiceResponseVM = {
      isSuccess: null,
      data: null
    };
    return this.httpClient.post(`${serviceUrl}/GetListPage`, searchModel).pipe(
      map((responseVM: any) => {
        if (responseVM.isSuccess) {
          serviceResponseVM.data = responseVM.data;
        } else {
        }
        serviceResponseVM.isSuccess = responseVM.isSuccess;
        return serviceResponseVM;
      })
    );
  }

  getListPageWithId(
    id: string,
    serviceUrl: string,
    searchModel: SearchModel
  ): Observable<ServiceResponseVM> {
    const serviceResponseVM: ServiceResponseVM = {
      isSuccess: null,
      data: null
    };
    return this.httpClient.post(`${serviceUrl}/${id}`, searchModel).pipe(
      map((responseVM: ResponseVM) => {
        if (responseVM.isSuccess) {
          serviceResponseVM.data = responseVM.data;
        } else {
        }
        serviceResponseVM.isSuccess = responseVM.isSuccess;
        return serviceResponseVM;
      })
    );
  }
}
