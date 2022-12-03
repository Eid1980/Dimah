
export interface GetUserDto {
  id: number;
  userName: string;
  fullNameAr: string;
  fullNameEn: string;

  phoneNumber: string;
  email: string;
  genderName: string;
  nationalityName: string;

  passwordHash: [];
  passwordSalt: [];
  isEmployee: boolean;
  isActive: boolean;
  oTP: string;
}

export interface GetUserProfileData {
  id: number;
  userName: string;
  firstNameAr: string;
  secondNameAr: string;
  thirdNameAr: string;
  lastNameAr: string;
  firstNameEn: string;
  secondNameEn: string;
  thirdNameEn: string;
  lastNameEn: string;
  isMale: boolean;
  birthDate: string;
  email: string;
  phoneNumber: string;
  passportId: string;
  nationalityId: number;
  nationalityName: string;
  governorateName: string;
  address: string;

  image: any;
}

export interface GetUserSessionDto {
  id: number;
  fullName: string;
  isEmployee: boolean;

  image: any;
}

export interface GetUserDataDto {
  id: number;
  userName: string;
  name: string;

  genderName: string;
  phoneNumber: string;
  email: string;
}

export interface UpdateUserProfileDto {
  id: number;

  newPassWord: string;

  ConfirmNewPassWord: string;

  firstNameAr: string;
  secondNameAr: string;
  thirdNameAr: string;
  lastNameAr: string

  firstNameEn: string
  secondNameEn: string
  thirdNameEn: string
  lastNameEn: string

  isMale: boolean;
  email: string;
  phoneNumber: string;


  nationalityId: number;
  governorateId: number;
  identityExpireDate: string
  address: string
}

export interface UserLoginDto {
  userName: string;
  password: string;
}

export interface ForgetPasswordDto {
  userName: string;
}

export interface ResetPasswordDto {
  userName: string;
  newPassword: string;
}

export interface UpdatePasswordDto {
  userId: number;
  oldPassword: string;
  newPassword: string;
}

export interface ValidateOTPDto {
  userName: string;
  oTP: string;
}


