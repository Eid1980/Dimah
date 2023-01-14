import { Component, OnInit } from '@angular/core';
import { GlobalService } from '@shared/services/global.service';

declare let $: any;
declare let Layout: any;

@Component({
  selector: 'app-core-layout',
  templateUrl: './core-layout.component.html',
})
export class CoreLayoutComponent implements OnInit {

  constructor(private globalService: GlobalService) { }

  ngOnInit() {
    Layout();
  }


  onActivate(event: any) {
    window.scroll({
      top: 0,
      left: 0,
      behavior: 'smooth'
    });
  }
}
