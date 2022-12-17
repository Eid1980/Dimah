import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AuthGuard } from "@shared/guards/auth.guard";
import { Role } from "@shared/enums/role.enum";
import { NationalityAddComponent } from "./components/nationality/nationality-add/nationality-add.component";
import { NationalityEditComponent } from "./components/nationality/nationality-edit/nationality-edit.component";
import { NationalityListComponent } from "./components/nationality/nationality-list/nationality-list.component";
import { NationalityViewComponent } from "./components/nationality/nationality-view/nationality-view.component";
import { ProjectTypeAddComponent } from "./components/project-type/project-type-add/project-type-add.component";
import { ProjectTypeEditComponent } from "./components/project-type/project-type-edit/project-type-edit.component";
import { ProjectTypeListComponent } from "./components/project-type/project-type-list/project-type-list.component";
import { ProjectTypeViewComponent } from "./components/project-type/project-type-view/project-type-view.component";
import { CharityAddComponent } from "./components/charity/charity-add/charity-add.component";
import { CharityEditComponent } from "./components/charity/charity-edit/charity-edit.component";
import { CharityListComponent } from "./components/charity/charity-list/charity-list.component";
import { CharityViewComponent } from "./components/charity/charity-view/charity-view.component";
import { CharityProjectAddComponent } from "./components/charity-project/charity-project-add/charity-project-add.component";
import { CharityProjectEditComponent } from "./components/charity-project/charity-project-edit/charity-project-edit.component";
import { CharityProjectListComponent } from "./components/charity-project/charity-project-list/charity-project-list.component";
import { CharityProjectViewComponent } from "./components/charity-project/charity-project-view/charity-project-view.component";
import { CharityAddProjectComponent } from "./components/charity/charity-add-project/charity-add-project.component";
import { ListPosterComponent } from "./components/poster/list-poster/list-poster.component";
import { AddPosterComponent } from "./components/poster/add-poster/add-poster.component";
import { EditPosterComponent } from "./components/poster/edit-poster/edit-poster.component";
import { ViewPosterComponent } from "./components/poster/view-poster/view-poster.component";

const routes: Routes = [
  //#region Charity
  {
    path: "charity-add",
    component: CharityAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "charity-add-project/:id",
    component: CharityAddProjectComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "charity-edit/:id",
    component: CharityEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "charity-list",
    component: CharityListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "charity-view/:id",
    component: CharityViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  //#endregion

  //#region CharityProject
  {
    path: "charity-project-add",
    component: CharityProjectAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "charity-project-edit/:id",
    component: CharityProjectEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "charity-project-list",
    component: CharityProjectListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "charity-project-view/:id",
    component: CharityProjectViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  //#endregion

  //#region Nationality
  {
    path: "nationality-add",
    component: NationalityAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "nationality-edit/:id",
    component: NationalityEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "nationality-list",
    component: NationalityListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "nationality-view/:id",
    component: NationalityViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  //#endregion
  //#region Poster
  {
    path: "poster-list",
    component: ListPosterComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "poster-add",
    component: AddPosterComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "poster-edit/:id",
    component: EditPosterComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "poster-view/:id",
    component: ViewPosterComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  //#endregion

  //#region ProjectType
  {
    path: "project-type-add",
    component: ProjectTypeAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "project-type-edit/:id",
    component: ProjectTypeEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "project-type-list",
    component: ProjectTypeListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  {
    path: "project-type-view/:id",
    component: ProjectTypeViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.SettingPermission]
    }
  },
  //#endregion


  {
    path: "",
    redirectTo: "index",
    pathMatch: "full",
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class DataManagementRoutingModule { }
