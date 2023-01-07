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

  chartData: any;
  chartOptions: any;

  constructor(private dailyRequestService: DailyRequestService) {
    this.chartData = {
      labels: ['رصيد ديما', 'الرصيد المستحق'],
      datasets: [
        {
          data: [30, 70],
          backgroundColor: [
            "#4bbc75",
            "#28924f"
          ],
          hoverBackgroundColor: [
            "#4bbc75",
            "#28924f"
          ]
        }
      ]
    };

    this.chartOptions = {
      responsive: true,
      plugins: {
        title: {
          display: false,
        },
        legend: {
          display: false,
          position: 'bottom',
        }
      }
    };
  }

  ngOnInit(): void {
    this.dailyRequestService.getRequestDashBoard().subscribe((res) => {
      this.requestDashBoardDto = res.data;
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
