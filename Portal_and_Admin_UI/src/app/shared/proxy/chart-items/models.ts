
export interface CreateChartItemDto {
  charityProjectId: string;
  donationValue: number;
  donationPeriod: number;
}

export interface UpdateChartItemDto {
  id: string;
  charityProjectId: string;
  donationValue: number;
  donationPeriod: number;
}

export interface GetChartItemDetailsDto {
  id: string;
  charityProjectId: string;
  charityProjectName: string;
  donationValue: number;
  donationPeriod: number;
}


export interface CurrentChartListDto {
  id: string;
  charityProjectName: string;
  donationValue: number;
  donationPeriod: number;
  donationTotal: number;
}
