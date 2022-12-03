import { NgModule } from "@angular/core";
import { SharedModule } from "@shared/shared.module";
import { ButtonModule } from "primeng/button";
import { MessageModule } from "primeng/message";
import { ToastModule } from "primeng/toast";
import { HomeComponent } from "./components/home/home.component";
import { HomeRoutingModule } from "./home-routing.module";
import { UserListComponent } from './components/permission/user-list/user-list.component';
import { UserAddComponent } from './components/permission/user-add/user-add.component';
import { RoleListComponent } from './components/permission/role-list/role-list.component';
import { RoleAddComponent } from './components/permission/role-add/role-add.component';
import { UserRoleAddComponent } from './components/permission/user-role-add/user-role-add.component';
import { RoleEditComponent } from './components/permission/role-edit/role-edit.component';
import { RoleViewComponent } from './components/permission/role-view/role-view.component';
import { NotAuthorizeComponent } from './components/not-authorize/not-authorize.component';
@NgModule({
  declarations: [HomeComponent, UserListComponent, UserAddComponent, RoleListComponent, RoleAddComponent, UserRoleAddComponent, RoleEditComponent, RoleViewComponent, NotAuthorizeComponent],
  imports: [
    SharedModule,
    HomeRoutingModule,
    MessageModule,
    ButtonModule,
    ToastModule,
  ],
  exports: [],
  providers: [],
})
export class HomeModule {}
