import { Component, OnInit } from "@angular/core";
import { GlobalService } from "@shared/services/global.service";
@Component({
  selector: "app-home",
  templateUrl: "./home.component.html",
})
export class HomeComponent implements OnInit {
  constructor(private globalService: GlobalService) {}

  ngOnInit() {
    this.globalService.setAdminTitle('الصفحة الرئيسية');
  }
}
