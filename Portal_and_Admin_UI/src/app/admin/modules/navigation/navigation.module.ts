import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { NavigationRoutingModule } from './navigation-routing.module';
import { CoreModule } from '../core/core.module';
import { SharedModule } from '@shared/shared.module';

@NgModule({
  declarations: [],
  imports: [CommonModule, CoreModule, SharedModule, NavigationRoutingModule],
  providers: [],
})
export class NavigationModule {}
