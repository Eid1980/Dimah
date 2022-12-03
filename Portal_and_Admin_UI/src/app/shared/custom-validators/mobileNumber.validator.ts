import { AbstractControl, ValidationErrors } from '@angular/forms';

export class MobileNumberValidator {
  static validateMobileNumber(control: AbstractControl): ValidationErrors | null {
    let controlValue = (control.value as string)?.valueOf().trim();
    if (controlValue == '') {
      return null;
    }
    let regexp = new RegExp(/^(009665|9665|\+9665|05|5)(5|0|3|6|4|9|1|8|7)([0-9]{7})$/);
    if (!regexp.test(controlValue)) {
      return { isValid: false };
    }
    else {
      return null;
    }
  }
}
