
export interface CreateCharityProjectDto {
  nameAr: string;
  nameEn: string;
  charityId: number;
  projectTypeId: number;
  descriptionAr: string;
  descriptionEn: string;
  projectCost: number;
  projectLocation: string;
  image: string;
  isActive: boolean;
}

export interface UpdateCharityProjectDto {
  id: number;
  nameAr: string;
  nameEn: string;
  charityId: number;
  projectTypeId: number;
  descriptionAr: string;
  descriptionEn: string;
  projectCost: number;
  projectLocation: string;
  image: string;
  isActive: boolean;
}

export interface GetCharityProjectDetailsDto {
  id: number;
  nameAr: string;
  nameEn: string;
  charityId: number;
  charityName: string;
  projectTypeId: number;
  projectTypeName: string;
  descriptionAr: string;
  descriptionEn: string;
  projectCost: number;
  projectLocation: string;
  image: string;
  isActive: boolean;
}

export interface GetCharityProjectListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  charityName: string;
  projectTypeName: string;
  projectCost: number;
  isActive: boolean;
}
