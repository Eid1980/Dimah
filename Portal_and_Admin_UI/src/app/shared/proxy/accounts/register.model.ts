
export interface CreateUserDto {
  userName: string;
  passWord: string;
  confirmPassWord: string;

  fullNameAr: string;
  fullNameEn: string;
  phoneNumber: string;
  email: string;
  isMale: boolean;
  nationalityId?: number;
}
