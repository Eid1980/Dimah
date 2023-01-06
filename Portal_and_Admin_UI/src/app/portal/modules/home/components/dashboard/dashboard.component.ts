import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
})
export class DashboardComponent implements OnInit {

  chartData: any;
  chartOptions: any;

  constructor() {
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
  }

}
