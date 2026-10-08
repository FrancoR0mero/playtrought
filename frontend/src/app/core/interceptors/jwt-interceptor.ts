import { HttpInterceptorFn } from '@angular/common/http';

export const jwtInterceptor: HttpInterceptorFn = (req, next) => {
  // TODO: attach the Authorization header once token storage exists (Sprint auth).
  return next(req);
};
