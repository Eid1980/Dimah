import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GetPosterDetailsDto } from '@shared/proxy/posters/models';
import { PosterService } from '@shared/proxy/posters/poster.service';
import { GlobalService } from '@shared/services/global.service';

@Component({
  selector: 'app-view-poster',
  templateUrl: './view-poster.component.html'
})
export class ViewPosterComponent implements OnInit {
  id: string;
  detailsDto = {} as GetPosterDetailsDto;

  constructor(private posterService: PosterService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تفاصيل الإعلان');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/poster-list");
    }
  }

  getDetails() {
    this.posterService.getById(this.id).subscribe((response) => {
      this.detailsDto = response.data;
    });
  }
}
