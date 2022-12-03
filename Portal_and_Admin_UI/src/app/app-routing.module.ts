import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PageNotFoundComponent } from '@shared/components/page-not-found/page-not-found.component';

const routes: Routes = [
  // {
  //   path: "shared",
  //   loadChildren: "./modules/shared/shared.module#SharedModule"
  // },
  {
    path: '',
    loadChildren: () =>
      import('./portal/modules/navigation/navigation.module').then(
        (x) => x.NavigationModule
      ),
  },
  {
    path: 'admin',
    loadChildren: () =>
      import('./admin/modules/navigation/navigation.module').then(
        (x) => x.NavigationModule
      ),
  },
  {
    path: 'auth',
    loadChildren: () => import('./auth/auth.module').then((x) => x.AuthModule),
  },
  {
    path: '**',
    component: PageNotFoundComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { anchorScrolling: 'enabled' })],
  exports: [RouterModule],
})
export class AppRoutingModule { }
