import { AbstractControl, ValidationErrors } from '@angular/forms';

export class NationalityIDValidator {
  static validateNationalityID(control: AbstractControl): ValidationErrors | null {
    let controlValue = (control.value as string)?.valueOf().trim();
    if (controlValue == '') {
      return null;
    }
    let regexp = new RegExp('^(1|2){1}[0-9]{9}$');
    if (!regexp.test(controlValue)) {
      return { isValid: false };
    }
    else {
      return null;
    }
  }
}
