import { Component, OnInit } from '@angular/core';
import { DailyRequestService } from '@shared/proxy/daily-requests/daily-request.service';
import { GetDailyRequestDetailsListDto, RequestDashBoardDto } from '@shared/proxy/daily-requests/models';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
})
export class DashboardComponent implements OnInit {
  requestDashBoardDto = {} as RequestDashBoardDto;
  showRolesDialog: boolean = false;
  dailyRequestDetailsListDto = [] as GetDailyRequestDetailsListDto[];

  numericStatistics: any;
  thisWeekRequestData: any;
  nextWeekRequestData: any;

  constructor(private dailyRequestService: DailyRequestService) {
  }

  ngOnInit(): void {
    this.dailyRequestService.getRequestDashBoard().subscribe((res) => {
      this.requestDashBoardDto = res.data;
      this.numericStatistics = {
        labels: ['رصيد ديما', 'الرصيد المتبقي', 'الرصيد المستحق اليوم'],
        datasets: [
          {
            data: [res.data.currentBalance, res.data.remainingBalance, res.data.currentDayDonation],
            backgroundColor: [
              "#99b3ff",
              "#85e085",
              "#ffb3ff"
            ],
            hoverBackgroundColor: [
              "#4d79ff",
              "#29a329",
              "#e600e6"
            ]
          }
        ]
      };

      this.thisWeekRequestData = {
        labels: res.data.thisWeekRequest.map((obj) => obj.name),
        datasets: [{
          label: 'المستحق لهذا الأسبوع',
          data: res.data.thisWeekRequest.map((obj) => obj.count),
          borderWidth: 1
        }]
      };

      this.nextWeekRequestData = {
        labels: res.data.nextWeekRequest.map((obj) => obj.name),
        datasets: [{
          label: 'المستحق للأسبوع القادم',
          data: res.data.nextWeekRequest.map((obj) => obj.count),
          borderWidth: 1
        }]
      };
    });

  }

  previewDetailsDialog(id: string) {
    if (id) {
      this.dailyRequestService.getRequestDetailsById(id).subscribe((response) => {
        this.dailyRequestDetailsListDto = response.data;
      });
      this.showRolesDialog = true;
    }
  }
  closeDetailsDialog() {
    this.dailyRequestDetailsListDto = [];
    this.showRolesDialog = false;
  }

}
