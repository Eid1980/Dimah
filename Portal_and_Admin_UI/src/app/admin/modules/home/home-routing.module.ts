import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AuthGuard } from "@shared/guards/auth.guard";
import { Role } from "@shared/enums/role.enum";
import { HomeComponent } from "./components/home/home.component";
import { RoleAddComponent } from "./components/permission/role-add/role-add.component";
import { RoleEditComponent } from "./components/permission/role-edit/role-edit.component";
import { RoleListComponent } from "./components/permission/role-list/role-list.component";
import { RoleViewComponent } from "./components/permission/role-view/role-view.component";
import { UserAddComponent } from "./components/permission/user-add/user-add.component";
import { UserListComponent } from "./components/permission/user-list/user-list.component";
import { UserRoleAddComponent } from "./components/permission/user-role-add/user-role-add.component";
import { NotAuthorizeComponent } from "./components/not-authorize/not-authorize.component";

const routes: Routes = [
  //#region Permission
  {
    path: "role-add",
    component: RoleAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin]
    }
  },
  {
    path: "role-edit/:id",
    component: RoleEditComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.UsersPermission]
    }
  },
  {
    path: "role-list",
    component: RoleListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.UsersPermission]
    }
  },
  {
    path: "role-view/:id",
    component: RoleViewComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.UsersPermission]
    }
  },
  {
    path: "user-add",
    component: UserAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.UsersPermission]
    }
  },
  {
    path: "user-list",
    component: UserListComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.UsersPermission]
    }
  },
  {
    path: "user-role-add/:id",
    component: UserRoleAddComponent,
    canActivate: [AuthGuard],
    data: {
      expectedRoles: [Role.SuperSystemAdmin, Role.SystemAdmin, Role.UsersPermission]
    }
  },
  //#endregion

  { path: 'not-authorize', component: NotAuthorizeComponent },
  { path: "", component: HomeComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HomeRoutingModule { }
