import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreLayoutComponent } from './components/core-layout/core-layout.component';
import { FooterComponent } from './components/footer/footer.component';
import { HeaderComponent } from './components/header/header.component';
import { CoreRoutingModule } from './core-routing.module';
import { CarouselModule } from 'ngx-owl-carousel-o';
import { SharedModule } from 'primeng/api';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ButtonModule } from 'primeng/button';

@NgModule({
  declarations: [
    CoreLayoutComponent,
    HeaderComponent,
    FooterComponent,
  ],
  imports: [
    CommonModule,
    CoreRoutingModule,
    CarouselModule,
    SharedModule,
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule,
    ButtonModule,
  ],
  exports: [
    CoreLayoutComponent,
    HeaderComponent,
    FooterComponent,
    CarouselModule,
  ],
})
export class CoreModule {}
