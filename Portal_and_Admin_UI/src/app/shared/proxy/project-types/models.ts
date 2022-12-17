
export interface CreateProjectTypeDto {
  nameAr: string;
  nameEn: string;
  imageName: string;
  isActive: boolean;
  image: any;
}

export interface UpdateProjectTypeDto {
  id: string;
  nameAr: string;
  nameEn: string;
  imageName: string;
  isActive: boolean;
  image: any;
}

export interface GetProjectTypeDetailsDto {
  id: string;
  nameAr: string;
  nameEn: string;
  imageName: string;
  isActive: boolean;
}

export interface GetProjectTypeListDto {
  id: string;
  nameAr: string;
  nameEn: string;
  imageName: string;
  isActive: boolean;
}
