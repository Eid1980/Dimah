export interface UploadedFileBase64Model {
  base64File: string;
  fileName: string;
  extention: string;
}

export interface DeleteFileDto {
  categueryName: string;
  name: string;
}
