import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { ButtonModule } from 'primeng/button';
import { MessageModule } from 'primeng/message';
import { ToastModule } from 'primeng/toast';
import { CoreModule } from '../core/core.module';
import { RatingModule } from 'primeng/rating';
import { NgxPrintModule } from 'ngx-print';
import { HomeComponent } from './components/home/home.component';
import { HomeRoutingModule } from './home-routing.module';
import { ProfileComponent } from './components/profile/profile.component';
import { EditProfileComponent } from './components/edit-profile/edit-profile.component';
import { ChairtyServicesComponent } from './components/chairty-services/chairty-services.component';
import { ChairtyServicesInnerComponent } from './components/chairty-services-inner/chairty-services-inner.component';
import { PaymentResultComponent } from './components/payment-result/payment-result.component';
import { CartComponent } from './components/cart/cart.component';
import { PaymentComponent } from './components/payment/payment.component';

@NgModule({
  declarations: [
    HomeComponent,
    ProfileComponent,
    EditProfileComponent,
    ChairtyServicesComponent,
    ChairtyServicesInnerComponent,
    PaymentResultComponent,
    CartComponent,
    PaymentComponent,
  ],
  imports: [
    SharedModule,
    HomeRoutingModule,
    MessageModule,
    ButtonModule,
    ToastModule,
    CoreModule,
    RatingModule,
    NgxPrintModule,
  ],
  exports: [],
  providers: [],
})
export class HomeModule { }
