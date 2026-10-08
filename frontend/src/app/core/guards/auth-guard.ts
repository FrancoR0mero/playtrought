import { Injectable } from '@angular/core';
import { CanActivate, UrlTree } from '@angular/router';

@Injectable({ providedIn: 'root' })
export class AuthGuard implements CanActivate {
  // TODO: validate session/JWT here once the auth feature exists (Sprint auth).
  canActivate(): boolean | UrlTree | Promise<boolean | UrlTree> {
    return true;
  }
}
