import { Injectable, EventEmitter } from '@angular/core';
import { of, Observable, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ChangeChartService {
  simpleObservable = new Subject();
  simpleObservable$ = this.simpleObservable.asObservable();
  constructor() { }
  addCount(newCount: number) {
    this.simpleObservable.next(newCount)
  }
  getCount() {
    return this.simpleObservable$;
  }
}
