
export interface CreateNationalityDto {
  nameAr: string;
  nameEn: string;
  code: string;
  iso2: string;
  dialCode: string;
  isActive: boolean;
}

export interface UpdateNationalityDto {
  id: number;
  nameAr: string;
  nameEn: string;
  code: string;
  iso2: string;
  dialCode: string;
  isActive: boolean;
}

export interface GetNationalityDetailsDto {
  id: number;
  nameAr: string;
  nameEn: string;
  code: string;
  iso2: string;
  dialCode: string;
  isActive: boolean;
}

export interface GetNationalityListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  code: string;
  iso2: string;
  dialCode: string;
  isActive: boolean;
}
