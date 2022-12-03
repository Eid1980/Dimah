import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router} from '@angular/router';
import { Observable, throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { HttpErrorResponse } from '@angular/common/http';
import { AccountService } from '@proxy/accounts/account.service';
import { UserRoleService } from '@proxy/user-roles/user-role.service';

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate {
  constructor(private router: Router, private accountService: AccountService,
    private userRoleService: UserRoleService) {
  }

  canActivate(next: ActivatedRouteSnapshot, state: RouterStateSnapshot):
    | Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    if (localStorage.getItem('EmiratesToken') === null || localStorage.getItem('EmiratesToken') === undefined) {
      this.accountService.logOut(state.url);
      return false;
    }
    else {
      if (localStorage.getItem('AuthUser') === null || localStorage.getItem('AuthUser') === undefined) {
        this.accountService.getAuthUser().subscribe((res) => {
          localStorage.setItem('AuthUser', JSON.stringify(res.data));
        });
      }

      const expectedRoles = next.data.expectedRoles;
      if (expectedRoles === null || expectedRoles === undefined || expectedRoles.length === 0) {
        return true;
      }
      else {
        const roles = expectedRoles.toString();
        return this.userRoleService.isAuthorize(roles).pipe(map((res) => {
          if (!res.isSuccess) {
            next.data = {};
            // redirect to not authorize Page
            this.router.navigate(['/admin/home/not-authorize'], {
              queryParams: { },
            });
          }
          return res.isSuccess;
        }),
          catchError((error: HttpErrorResponse) => {
            if (error.status === 401) {
              // redirect to not authorize Page
              this.router.navigate(['/admin/home/not-authorize'], {
                queryParams: { },
              });
            }
            return throwError(error);
          }));
      }
    }
  }
}
