import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { HomeComponent } from "./components/home/home.component";
import { ProfileComponent } from "./components/profile/profile.component";
import { EditProfileComponent } from "./components/edit-profile/edit-profile.component";
import { CartComponent } from "./components/cart/cart.component";
import { PaymentComponent } from "./components/payment/payment.component";
import { PaymentResultComponent } from "./components/payment-result/payment-result.component";
import { CharityProjectsComponent } from "./components/charity-projects/charity-projects.component";
import { ProjectDetailsComponent } from "./components/project-details/project-details.component";

const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: "home", component: HomeComponent },
  { path: "charity-project", component: CharityProjectsComponent },
  { path: "charity-project/:id", component: CharityProjectsComponent },
  { path: "project-details/:id", component: ProjectDetailsComponent },

  { path: "cart", component: CartComponent },
  { path: "payment", component: PaymentComponent },
  { path: "payment-result", component: PaymentResultComponent },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HomeRoutingModule { }
