
export interface CreatePosterDto {
  titleAr: string;
  titleEn: string;
  order: number;
  imageName: string;
  isActive: boolean;
  image: any;
}

export interface UpdatePosterDto {
  id: string;
  titleAr: string;
  titleEn: string;
  order: number;
  imageName: string;
  isActive: boolean;
  image: any;
}

export interface GetPosterDetailsDto {
  id: string;
  titleAr: string;
  titleEn: string;
  order: number;
  imageName: string;
  isActive: boolean;
}

export interface GetPosterListDto {
  id: string;
  titleAr: string;
  titleEn: string;
  order: number;
  imageName: string;
  isActive: boolean;
}
