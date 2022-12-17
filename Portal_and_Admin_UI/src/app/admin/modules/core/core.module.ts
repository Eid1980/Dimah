import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CoreRoutingModule } from './core-routing.module';
import { CoreLayoutComponent } from './components/core-layout/core-layout.component';
import { FooterComponent } from './components/footer/footer.component';
import { HeaderComponent } from './components/header/header.component';
import { MenuComponent } from './components/menu/menu.component';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
  declarations: [
    CoreLayoutComponent,
    HeaderComponent,
    FooterComponent,
    MenuComponent,
  ],
  imports: [CommonModule,TranslateModule, CoreRoutingModule],
  exports: [
    CoreLayoutComponent,
    HeaderComponent,
    FooterComponent,
    MenuComponent,
  ],
})
export class CoreModule {}
