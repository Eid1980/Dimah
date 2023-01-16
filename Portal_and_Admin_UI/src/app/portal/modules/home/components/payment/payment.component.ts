import { Component, OnInit } from '@angular/core';
import { ChartItemService } from '@shared/proxy/chart-items/chart-item.service';
import { GlobalService } from '@shared/services/global.service';
import { CurrentChartListDto } from '@shared/proxy/chart-items/models';
import { DailyRequestService } from '@shared/proxy/daily-requests/daily-request.service';

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html'
})
export class PaymentComponent implements OnInit {
  currentChartListDto = [] as CurrentChartListDto[];
  totlalChart: number = 0;

  constructor(private chartItemService: ChartItemService, private dailyRequestService: DailyRequestService,
    private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.getCurrentChart();
  }
  getCurrentChart() {
    this.chartItemService.getCurrentChart().subscribe((res) => {
      this.currentChartListDto = res.data;
      this.totlalChart = res.data.reduce((accumulator, obj) => {
        return accumulator + obj.donationTotal;
      }, 0);
    });
  }

  finishPayment() {
    this.chartItemService.finishPayment().subscribe((res) => {
      if (res.isSuccess) {
        this.globalService.navigate("/payment-result");
      }
    });
  }
}
