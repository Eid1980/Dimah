import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataManagementRoutingModule } from './data-management-routing.module';
import { SharedModule } from '@shared/shared.module';
import { StepsModule } from 'primeng/steps';
import { NationalityListComponent } from './components/nationality/nationality-list/nationality-list.component';
import { NationalityAddComponent } from './components/nationality/nationality-add/nationality-add.component';
import { NationalityEditComponent } from './components/nationality/nationality-edit/nationality-edit.component';
import { NationalityViewComponent } from './components/nationality/nationality-view/nationality-view.component';
import { ProjectTypeAddComponent } from './components/project-type/project-type-add/project-type-add.component';
import { ProjectTypeEditComponent } from './components/project-type/project-type-edit/project-type-edit.component';
import { ProjectTypeListComponent } from './components/project-type/project-type-list/project-type-list.component';
import { ProjectTypeViewComponent } from './components/project-type/project-type-view/project-type-view.component';
import { CharityAddComponent } from './components/charity/charity-add/charity-add.component';
import { CharityEditComponent } from './components/charity/charity-edit/charity-edit.component';
import { CharityListComponent } from './components/charity/charity-list/charity-list.component';
import { CharityViewComponent } from './components/charity/charity-view/charity-view.component';
import { CharityProjectAddComponent } from './components/charity-project/charity-project-add/charity-project-add.component';
import { CharityProjectEditComponent } from './components/charity-project/charity-project-edit/charity-project-edit.component';
import { CharityProjectListComponent } from './components/charity-project/charity-project-list/charity-project-list.component';
import { CharityProjectViewComponent } from './components/charity-project/charity-project-view/charity-project-view.component';
import { CharityAddProjectComponent } from './components/charity/charity-add-project/charity-add-project.component';

@NgModule({
  declarations: [
    NationalityListComponent,
    NationalityAddComponent,
    NationalityEditComponent,
    NationalityViewComponent,
    ProjectTypeAddComponent,
    ProjectTypeEditComponent,
    ProjectTypeListComponent,
    ProjectTypeViewComponent,
    CharityAddComponent,
    CharityEditComponent,
    CharityListComponent,
    CharityViewComponent,
    CharityProjectAddComponent,
    CharityProjectEditComponent,
    CharityProjectListComponent,
    CharityProjectViewComponent,
    CharityAddProjectComponent,
  ],
  imports: [StepsModule, CommonModule, DataManagementRoutingModule, SharedModule],
})
export class DataManagementModule {}
