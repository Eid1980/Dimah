import { GetCharityProjectListDto } from "../charity-projects/models";

export interface CreateCharityDto {
  nameAr: string;
  nameEn: string;
  address: string;
  email: string;
  phoneNumber: string;
  isActive: boolean;
}

export interface UpdateCharityDto {
  id: string;
  nameAr: string;
  nameEn: string;
  address: string;
  email: string;
  phoneNumber: string;
  isActive: boolean;
}

export interface GetCharityDetailsDto {
  id: string;
  nameAr: string;
  nameEn: string;
  address: string;
  email: string;
  phoneNumber: string;
  isActive: boolean;
  charityProjectList: GetCharityProjectListDto[];
}

export interface GetCharityListDto {
  id: string;
  nameAr: string;
  nameEn: string;
  phoneNumber: string;
  isActive: boolean;
}
