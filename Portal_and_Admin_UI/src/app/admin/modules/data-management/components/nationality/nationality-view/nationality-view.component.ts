import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NationalityService } from '@proxy/nationalities/nationality.service';
import { GetNationalityDetailsDto } from '@proxy/nationalities/models';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-nationality-view',
  templateUrl: './nationality-view.component.html'
})
export class NationalityViewComponent implements OnInit {
  id: number;
  nationalityDetailsDto = {} as GetNationalityDetailsDto;

  constructor(private nationalityService: NationalityService,
    private globalService: GlobalService, private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل الجنسية');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
  }

  getDetails() {
    this.nationalityService.getById(this.id).subscribe((response) => {
      this.nationalityDetailsDto = response.data;
    });
  }
}
