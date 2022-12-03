import { Pipe, PipeTransform } from '@angular/core';
import { GlobalService } from '../services/global.service';

@Pipe({
  name: 'fullDate'
})
export class FullDatePipe implements PipeTransform {

  constructor(private globalService: GlobalService) { }

  transform(date: string, lang: string | null | undefined) {
    return this.globalService.getFullDate(new Date(date), lang);
  }

}
