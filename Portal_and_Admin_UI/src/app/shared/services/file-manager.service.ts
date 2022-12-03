import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { DeleteFileDto, UploadedFileBase64Model } from '../models/file-manager.model';

@Injectable({
  providedIn: 'root',
})
export class FileManagerService {
  constructor(private http: HttpClient) {}

  upload(entityId: string, entityName: string, subEntityName: string, files: File[]) {
    const formData = new FormData();
    formData.append('entityId', entityId);
    formData.append('entityName', entityName);
    formData.append('subEntityName', subEntityName);

    Array.from(files).map((file, index) => {
      formData.append('file' + index, file, file.name);
    });

    return this.http.post(`${environment.ApiUrl}/api/FileManager`, formData);
  }

  changeStatus(fileId: number) {
    return this.http.get(
      `${environment.ApiUrl}/api/FileManager/ChangeStatus/${fileId}`
    );
  }

  delete(fileId: string) {
    return this.http.delete(`${environment.ApiUrl}/api/FileManager/${fileId}`);
  }

  deleteByEntityName(entityId: any, entityName: string) {
    entityId = entityId.toString();
    return this.http.post(
      `${environment.ApiUrl}/api/FileManager/DeleteByEntityName`,
      { entityName: entityName, entityId: entityId }
    );
  }

  download(id: string) {
    this.http
      .get(`${environment.ApiUrl}/api/FileManager/Download/${id}`)
      .subscribe((res: any) => {
        this.downloadFile(res);
      });
  }

  private downloadFile(res: any) {

    const byteCharacters = atob(res.base64File);
    const byteNumbers = new Array(byteCharacters.length);
    for (let i = 0; i < byteCharacters.length; i++) {
      byteNumbers[i] = byteCharacters.charCodeAt(i);
    }
    const byteArray = new Uint8Array(byteNumbers);
    const blob = new Blob([byteArray], { type: 'application/octet-stream' });

    const a = document.createElement('a');
    a.setAttribute('style', 'display:none;');
    document.body.appendChild(a);

    a.download = res.fileName;
    a.href = URL.createObjectURL(blob);
    a.target = '_blank';
    a.click();
    document.body.removeChild(a);
  }

  getById = (id: string): Observable<UploadedFileBase64Model> => {
    return this.http.get<UploadedFileBase64Model>(`${environment.ApiUrl}/api/FileManager/GetById/${id}`);
  }
  getByEntityId(entityId: string) {
    return this.http.get(
      `${environment.ApiUrl}/api/FileManager/GetByEntityId/${entityId}`
    );
  }
  getByEntityName(entityName: string) {
    return this.http.get(
      `${environment.ApiUrl}/api/FileManager/GetByEntityName/${entityName}`
    );
  }

  convertBase64ToBlobData(base64Data: string, contentType: string = 'image/png', sliceSize = 512) {
    let byteCharacters;
    if (contentType == 'image/png') {
      byteCharacters = atob(base64Data.split(',')[1]); // for image
    }
    else {
      byteCharacters = atob(base64Data);
    }
    const byteArrays = [];
    for (let offset = 0; offset < byteCharacters.length; offset += sliceSize) {
      const slice = byteCharacters.slice(offset, offset + sliceSize);
      const byteNumbers = new Array(slice.length);
      for (let i = 0; i < slice.length; i++) {
        byteNumbers[i] = slice.charCodeAt(i);
      }
      const byteArray = new Uint8Array(byteNumbers);
      byteArrays.push(byteArray);
    }
    const blob = new Blob(byteArrays, { type: contentType });
    return blob;
  }
  downloadAttachment(base64content, fileName) {
    let fileType = ''
    if (fileName.split('.')[1] == 'pdf') {
      fileType = 'application/pdf';
    }
    else if (fileName.split('.')[1].includes('x')) {
      fileType = 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet';
    }
    else {
      fileType = 'image/png';
    }
    const blobData = this.convertBase64ToBlobData(base64content, fileType);
    // chrome
    const blob = new Blob([blobData], { type: fileType });
    const url = window.URL.createObjectURL(blob);
    // window.open(url);
    const link = document.createElement('a');
    link.href = url;
    link.download = 'attachment';
    link.click();
  }

  // added by salah
  uploadFile = (categueryName: string, name: string, files: File[]) => {
    const formData = new FormData();
    formData.append('categueryName', categueryName);
    formData.append('name', name);
    Array.from(files).map((file, index) => {
      formData.append('file' + index, file, file.name);
    });
    return this.http.post(`${environment.ApiUrl}/api/FileManager/UploadFile`, formData);
  }
  deleteFile = (deleteFileDto: DeleteFileDto) => {
    return this.http.post(`${environment.ApiUrl}/api/FileManager/DeleteFile`, deleteFileDto);
  }
  getByEntityIdEntityName = (entityId: string, entityName: string): Observable<any> => {
    return this.http.get<any>(`${environment.ApiUrl}/api/FileManager/GetByEntityIdEntityName?entityId=${entityId}&entityName=${entityName}`);
  }
}
