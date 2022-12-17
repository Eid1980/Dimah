import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { GetCharityProjectDetailsDto } from '@shared/proxy/charity-projects/models';
import { CharityProjectService } from '@shared/proxy/charity-projects/charity-project.service';

@Component({
  selector: 'app-charity-project-view',
  templateUrl: './charity-project-view.component.html'
})
export class CharityProjectViewComponent implements OnInit {
  id: string;
  detailsDto = {} as GetCharityProjectDetailsDto;

  constructor(private charityProjectService: CharityProjectService, private globalService: GlobalService,
    private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل المشروع');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
  }

  getDetails() {
    this.charityProjectService.getById(this.id).subscribe((response) => {
      this.detailsDto = response.data;
    });
  }
}
