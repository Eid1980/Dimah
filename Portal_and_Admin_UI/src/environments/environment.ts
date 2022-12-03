// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,

  cryptionKey: "Emirates@2023",
  ApiUrl: "http://localhost:5000",
  lastSieUpdate: "2022/10/30",

  allowedExtensions: 'image/*',
  fileSize: 4000000,

  charityProjectallowedExtensions: 'image/*',
  charityProjectfileSize: 1500000,
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
