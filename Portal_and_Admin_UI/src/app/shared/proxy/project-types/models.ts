
export interface CreateProjectTypeDto {
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface UpdateProjectTypeDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface GetProjectTypeDetailsDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface GetProjectTypeListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}
