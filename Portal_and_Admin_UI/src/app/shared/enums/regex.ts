export const Regex = {
  UnSignedIntegerNumber: '^\\d*$',
  PositiveIntegerNumber: '^[1-9]$|^0*[1-9]+[0-9]*$',
  UnSignedDecimalNumber: '^\\d*\\.{0,1}\\d*$',
  PositiveDecimalNumber: '^(\\d*[1-9]\\d*(\\.[0-9]*)?|0*\\.\\d*[1-9]\\d*)$',
  Percentage: '^100(\\.0{0,2}?)?$|^\\d{0,2}(\\.\\d{0,2})?$',
  ArabicName: '^([\\u0621-\\u064A\\u0660-\\u0669\\d]+[-_ ]{0,1})*$',
  ArabicNameWithDiacritics:
    '^([\\u0600-\\u06ff\\u0750-\\u077f\\ufb50-\\ufc3f\\ufe70-\\ufefc\\d]+[-_ ]{0,1})*$',
  ArabicLetters: '^[\\u0621-\\u064A ]+$',
  ArabicLettersWithDiacritics:
    '^[\\u0600-\\u06ff\\u0750-\\u077f\\ufb50-\\ufc3f\\ufe70-\\ufefc ]+$',
  EnglishName: '^([a-zA-Z0-9]+[-_ ]{0,1})*$',
  EnglishLetters: '^[a-zA-Z ]+$',
  NationalId: '^(1|2){1}[0-9]{9}$',
  Mobile: /^(009665|9665|\+9665|05|5)(5|0|3|6|4|9|1|8|7)([0-9]{7})$/
};
