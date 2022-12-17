import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { GetCharityDetailsDto } from '@shared/proxy/charities/models';
import { CharityService } from '@shared/proxy/charities/charity.service';

@Component({
  selector: 'app-charity-view',
  templateUrl: './charity-view.component.html'
})
export class CharityViewComponent implements OnInit {
  id: string;
  detailsDto = {} as GetCharityDetailsDto;

  constructor(private charityService: CharityService, private globalService: GlobalService,
    private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل الجهة');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
  }

  getDetails() {
    this.charityService.getById(this.id).subscribe((response) => {
      this.detailsDto = response.data;
    });
  }
}
