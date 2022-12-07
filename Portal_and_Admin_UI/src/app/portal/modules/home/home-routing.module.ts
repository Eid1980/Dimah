import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { HomeComponent } from "./components/home/home.component";
import { ProfileComponent } from "./components/profile/profile.component";
import { EditProfileComponent } from "./components/edit-profile/edit-profile.component";
import { ChairtyServicesComponent } from "./components/chairty-services/chairty-services.component";
import { ChairtyServicesInnerComponent } from "./components/chairty-services-inner/chairty-services-inner.component";
import { CartComponent } from "./components/cart/cart.component";
import { PaymentComponent } from "./components/payment/payment.component";
import { PaymentResultComponent } from "./components/payment-result/payment-result.component";

const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: "home", component: HomeComponent },
  { path: "chairty-services", component: ChairtyServicesComponent },
  { path: "chairty-services/:id", component: ChairtyServicesInnerComponent },
  { path: "cart", component: CartComponent },
  { path: "payment", component: PaymentComponent },
  { path: "payment-result", component: PaymentResultComponent },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HomeRoutingModule { }
