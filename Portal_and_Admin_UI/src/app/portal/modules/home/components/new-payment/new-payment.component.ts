import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { DailyRequestService } from '@shared/proxy/daily-requests/daily-request.service';

@Component({
  selector: 'app-new-payment',
  templateUrl: './new-payment.component.html'
})
export class NewPaymentComponent implements OnInit {
  id: string;

  constructor(private dailyRequestService: DailyRequestService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('الدفع');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (!this.id) {
      this.globalService.navigate("/");
    }
  }

  finishPayment() {
    this.dailyRequestService.payRequest(this.id).subscribe((result) => {
      if (result.isSuccess) {
        this.globalService.navigate("/payment-result");
      }
    });
  }
}
