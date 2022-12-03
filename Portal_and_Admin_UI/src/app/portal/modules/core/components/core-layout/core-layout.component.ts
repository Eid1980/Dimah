import { AfterViewInit, Component, OnInit } from '@angular/core';
import { GlobalService } from '@shared/services/global.service';
import { MenuItem } from 'primeng/api';

declare let $: any;
declare let Layout: any;

@Component({
  selector: 'app-core-layout',
  templateUrl: './core-layout.component.html',
})
export class CoreLayoutComponent implements OnInit, AfterViewInit {
  items = [] as MenuItem[];

  constructor(private globalService: GlobalService) { }

  ngOnInit() {
    Layout();
  }

  ngAfterViewInit() {
    this.items = [{ label: 'الرئيسية', url: '/', icon: 'pi pi-home' }];
    this.globalService.subject.subscribe((newItems: any) => {
      this.items = this.items.concat(newItems);
    });
  }

  onActivate(event: any) {
    window.scroll({
      top: 0,
      left: 0,
      behavior: 'smooth'
    });
  }
}
