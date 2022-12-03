import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { GetProjectTypeDetailsDto } from '@shared/proxy/project-types/models';
import { ProjectTypeService } from '@shared/proxy/project-types/project-type.service';

@Component({
  selector: 'app-project-type-view',
  templateUrl: './project-type-view.component.html'
})
export class ProjectTypeViewComponent implements OnInit {
  id: number;
  projectTypeDetailsDto = {} as GetProjectTypeDetailsDto;

  constructor(private projectTypeService: ProjectTypeService, private globalService: GlobalService,
    private activatedRoute: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تفاصيل نوع المشروع');
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
  }

  getDetails() {
    this.projectTypeService.getById(this.id).subscribe((response) => {
      this.projectTypeDetailsDto = response.data;
    });
  }
}
