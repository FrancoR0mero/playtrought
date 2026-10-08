import { Injectable } from '@angular/core';
import { CanActivate, UrlTree } from '@angular/router';

@Injectable({ providedIn: 'root' })
export class RoleGuard implements CanActivate {
  // TODO: validate the required role here once roles exist (Sprint auth).
  canActivate(): boolean | UrlTree | Promise<boolean | UrlTree> {
    return true;
  }
}
