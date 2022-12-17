
export interface CreateCharityProjectDto {
  nameAr: string;
  nameEn: string;
  charityId: string;
  projectTypeId: number;
  descriptionAr: string;
  descriptionEn: string;
  projectCost: number;
  projectLocation: string;
  image: string;
  isActive: boolean;
}

export interface UpdateCharityProjectDto {
  id: string;
  nameAr: string;
  nameEn: string;
  charityId: string;
  projectTypeId: number;
  descriptionAr: string;
  descriptionEn: string;
  projectCost: number;
  projectLocation: string;
  image: string;
  isActive: boolean;
}

export interface GetCharityProjectDetailsDto {
  id: string;
  nameAr: string;
  nameEn: string;
  charityId: string;
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
  id: string;
  nameAr: string;
  nameEn: string;
  charityName: string;
  projectTypeName: string;
  projectCost: number;
  isActive: boolean;
}
