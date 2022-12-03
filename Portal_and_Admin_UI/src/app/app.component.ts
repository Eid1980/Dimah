import {
  Component,
  ChangeDetectorRef,
  AfterViewChecked,
  OnInit,
} from "@angular/core";
import { ProgressSpinnerService } from "@shared/services/progress-spinner.service";
import { Subject } from "rxjs";
import { Router } from "@angular/router";
import { GlobalService } from "./shared/services/global.service";
import { TranslationServiceService } from "@shared/services/translation-service.service";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html"
})
export class AppComponent implements OnInit, AfterViewChecked {
  isActive: Subject<boolean>;
  title = "Admin Dashboard";

  constructor(private progressSpinner: ProgressSpinnerService, private _translateService: TranslationServiceService,
    private cdRef: ChangeDetectorRef, private router: Router, private globalService: GlobalService

  ) { }

  ngOnInit(): void {
    this._translateService.initializeLanguage();
    document.body.style.direction = this._translateService.getCurrentLanguage().Direction;
  }

  onActivate(event: any) {
    window.scroll({
      top: 0,
      left: 0,
      behavior: 'smooth'
    });
  }

  ngAfterViewChecked() {
    this.isActive = this.progressSpinner.isLoading;
    this.cdRef.detectChanges();
  }
  onConfirm() {
    this.globalService.confirm();
  }
  onReject() {
    this.globalService.clearMessages();
  }
}
