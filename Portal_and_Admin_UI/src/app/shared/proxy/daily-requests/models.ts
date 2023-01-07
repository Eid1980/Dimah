
export interface CreateDailyRequestDto {
  donationValue: number;
  donationPeriod: number;
  actForName: string;
  actForMobile: string;
  startDate: string;
}

export interface GetDailyRequestListDto {
  id: string;
  donationValue: number;
  donationPeriod: number;
  dailyRequestStatusId: number;
  actForName: string;
  actForMobile: string;
  startDate: string;
  payedCount: number;
  notPayedCount: number;
}

export interface RequestProfileDto {
  currentBalance: number;
  currentDayDonation: number;
  allDonation: number;
  payedRequests: GetDailyRequestListDto[];
  newRequests: GetDailyRequestListDto[];
  finishedRequests: GetDailyRequestListDto[];
}

export interface RequestDashBoardDto {
  currentBalance: number;
  remainingBalance: number;
  currentDayDonation: number;
  donationPersonCount: number;
  payedRequests: GetDailyRequestListDto[];
  finishedRequests: GetDailyRequestListDto[];
}

export interface GetDailyRequestDetailsListDto {
  day: string;
  donationValue: number;
  isPayed: string;
  sms: string;
}
