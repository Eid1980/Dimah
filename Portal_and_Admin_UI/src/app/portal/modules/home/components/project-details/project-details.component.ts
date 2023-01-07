import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { OwlOptions } from 'ngx-owl-carousel-o';
import { ProjectDetailsDto } from '@shared/proxy/home/models';
import { HomeService } from '@shared/proxy/home/home.service';
import { GlobalService } from '@shared/services/global.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ChartItemService } from '@shared/proxy/chart-items/chart-item.service';
import { CreateChartItemDto } from '@shared/proxy/chart-items/models';
import { ChangeChartService } from '@shared/services/change-chart.service';
import { DailyRequestService } from '@shared/proxy/daily-requests/daily-request.service';
import { CreateDailyRequestDto } from '@shared/proxy/daily-requests/models';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { DateType } from 'ngx-hijri-gregorian-datepicker';

@Component({
  selector: 'app-project-details',
  templateUrl: './project-details.component.html'
})
export class ProjectDetailsComponent implements OnInit {
  id: string;
  projectDetailsDto = {} as ProjectDetailsDto;
  createForm: FormGroup;
  isFormSubmitted: boolean = false;
  //createDto = { donationPeriod: 1, donationValue: 1 } as CreateChartItemDto;
  createDto = { donationPeriod: 1, donationValue: 1 } as CreateDailyRequestDto;

  //#region for datePicker
  @ViewChild('datePicker') startDatePicker: any;
  isValidDate = false;
  date: NgbDateStruct;
  selectedDateType = DateType.Hijri;
  //#endregion

  confirmationBox: boolean = false;
  itemsOptions: OwlOptions = {
    loop: false,
    autoplay: false,
    mouseDrag: true,
    touchDrag: true,
    pullDrag: true,
    dots: false,
    navSpeed: 1500,
    rtl: true,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1,
        margin: 0,
      },
      380: {
        items: 2,
        margin: 26,
      },
      576: {
        items: 3,
        margin: 26,
      },
      767: {
        items: 4,
        margin: 26,
      },
      991: {
        items: 4,
        margin: 26,
      }
    },
    nav: true,
  };

  constructor(private formBuilder: FormBuilder, private dailyRequestService: DailyRequestService,
    private homeService: HomeService, private globalService: GlobalService,
    private chartItemService: ChartItemService, private changeChartService: ChangeChartService,
    private activatedRoute: ActivatedRoute, private router: Router) {

  }

  ngOnInit(): void {
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getProjectDetails();
    }
    else {
      this.globalService.navigate('/')
    }
    this.buildForm();
  }
  getProjectDetails() {
    this.homeService.getProjectDetails(this.id).subscribe((res) => {
      this.projectDetailsDto = res.data;
    });
  }
  buildForm() {
    this.createForm = this.formBuilder.group({
      donationValue: [this.createDto.donationValue || 1, [Validators.required]],
      donationPeriod: [this.createDto.donationPeriod || 1, [Validators.required]],
      actForName: [this.createDto.actForName || ''],
      actForMobile: [this.createDto.actForMobile || ''],
      startDate: [this.createDto.startDate || null],
    });
  }

  increase() {
    this.createDto.donationPeriod += 1;
    this.createForm.controls['donationPeriod'].setValue(this.createDto.donationPeriod);
  }
  decrease() {
    if (this.createDto.donationPeriod > 1) {
      this.createDto.donationPeriod -= 1;
      this.createForm.controls['donationPeriod'].setValue(this.createDto.donationPeriod);
    }
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createForm.valid) {
      this.createDto = { ...this.createForm.value } as CreateDailyRequestDto;
      let date = this.startDatePicker.getSelectedDate();
      if (date != 'Invalid date') {
        this.createDto.startDate = date;
      }
      this.dailyRequestService.create(this.createDto).subscribe((res) => {
        if (res.isSuccess) {
          this.globalService.navigate(`/new-payment/${res.data}`);
          //this.globalService.navigateParams("/new-payment", { id: res.data });
        }
      });
    }

  }

  //addToCart() {
  //  this.isFormSubmitted = true;
  //  if (this.createForm.valid) {
  //    this.createDto = { ...this.createForm.value } as CreateChartItemDto;
  //    this.createDto.charityProjectId = this.projectDetailsDto.id;
  //    this.chartItemService.create(this.createDto).subscribe((response) => {
  //      if (response.isSuccess) {
  //        this.changeChartService.addCount(response.data);
  //        this.confirmationBox = true;
  //        setTimeout(() => {
  //          this.confirmationBox = false;
  //        }, 7000);
  //      }
  //    });
  //  }
  //}

  showCart() {
    this.confirmationBox = false;
    this.router.navigateByUrl('/cart');
  }

}
