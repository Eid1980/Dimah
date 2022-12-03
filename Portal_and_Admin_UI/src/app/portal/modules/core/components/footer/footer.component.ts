import { Component, OnInit } from '@angular/core';
import { GlobalService } from '@shared/services/global.service';
import { MessageType } from '@shared/enums/message-type.enum';
import { environment } from 'src/environments/environment';
import { TranslationServiceService } from '@shared/services/translation-service.service';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html'
})
export class FooterComponent implements OnInit {
  email: string = '';
  designEvaluate: number;
  lastSieUpdate: string;

  constructor(private translateService: TranslationServiceService,
    private globalService: GlobalService)
  {
  }

  ngOnInit() {
    this.lastSieUpdate = this.globalService.getFullDate(new Date(environment.lastSieUpdate), this.translateService.getCurrentLanguage().Name.toLowerCase());
  }

  evaluate() {
  }
}
