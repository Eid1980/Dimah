import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { HomeService } from '@shared/proxy/home/home.service';
import { DimahProjectsListDto } from '@shared/proxy/home/models';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-charity-projects',
  templateUrl: './charity-projects.component.html'
})
export class CharityProjectsComponent implements OnInit {
  id: string;
  charityProjects = [] as DimahProjectsListDto[];

  constructor(private homeService: HomeService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id == undefined || this.id == '') {
      this.id = environment.dimahId;
    }
    this.getCharityProjects();
  }

  getCharityProjects() {
    this.homeService.getCharityProjects(this.id).subscribe((res) => {
      this.charityProjects = res.data;
    });
  }
}
