import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'customSlice'
})
export class CustomSlicePipe implements PipeTransform {

  transform(value: string, length: number): string {
    return value.length < length ? value : value.substring(0,length);
  }

}
