import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SharedModule } from '@shared/shared.module';
import { NavigationRoutingModule } from './navigation-routing.module';
import { CoreModule } from '../core/core.module';

@NgModule({
  declarations: [],
  imports: [CommonModule, CoreModule, SharedModule, NavigationRoutingModule],
  providers: [],
})
export class NavigationModule {}
