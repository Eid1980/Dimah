
export interface CreateRoleDto {
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface UpdateRoleDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface GetRoleDetailsDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}

export interface GetRoleListDto {
  id: number;
  nameAr: string;
  nameEn: string;
  isActive: boolean;
}
