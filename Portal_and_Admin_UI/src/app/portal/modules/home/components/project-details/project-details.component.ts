import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { OwlOptions } from 'ngx-owl-carousel-o';
import { ProjectDetailsDto } from '@shared/proxy/home/models';
import { HomeService } from '@shared/proxy/home/home.service';
import { GlobalService } from '@shared/services/global.service';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ChartItemService } from '@shared/proxy/chart-items/chart-item.service';
import { CreateChartItemDto } from '@shared/proxy/chart-items/models';
import { WhiteSpaceValidator } from '../../../../../shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-project-details',
  templateUrl: './project-details.component.html'
})
export class ProjectDetailsComponent implements OnInit {
  id: string;
  projectDetailsDto = {} as ProjectDetailsDto;
  createForm: FormGroup;
  isFormSubmitted: boolean = false;
  createDto = { donationPeriod: 1, donationValue: 1 } as CreateChartItemDto;

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

  constructor(private formBuilder: FormBuilder, private homeService: HomeService,
    private chartItemService: ChartItemService, private globalService: GlobalService,
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
      donationPeriod: [this.createDto.donationPeriod || 1, [Validators.required]]
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

  addToCart() {
    this.isFormSubmitted = true;
    if (this.createForm.valid) {
      this.createDto = { ...this.createForm.value } as CreateChartItemDto;
      this.createDto.charityProjectId = this.projectDetailsDto.id;
      this.chartItemService.create(this.createDto).subscribe((response) => {
        if (response.isSuccess) {
          this.confirmationBox = true;
          setTimeout(() => {
            this.confirmationBox = false;
          }, 7000);
        }
      });
    }
  }

  showCart() {
    this.confirmationBox = false;
    this.router.navigateByUrl('/cart');
  }

}
