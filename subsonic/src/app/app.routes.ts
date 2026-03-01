import { Routes } from '@angular/router';
import { Home } from './components/home/home';
import { Login } from './components/login/login';
import { Events } from './components/events/events';
import { Store } from './components/store/store';
import { FAQ } from './components/faq/faq';
import { RecoverPass } from './components/recover-pass/recover-pass';
import { Register } from './components/register/register';
import { RouterConstants } from './constants/router-constants';

export const routes: Routes = [
  { path: RouterConstants.HOME, component: Home },
  { path: RouterConstants.LOGIN, component: Login },
  { path: RouterConstants.EVENTS, component: Events },
  { path: RouterConstants.STORE, component: Store },
  { path: RouterConstants.FAQ, component: FAQ },
  { path : RouterConstants.FORGOT_PASSWORD, component: RecoverPass },
  { path : RouterConstants.CREATE_ACCOUNT, component: Register },
];
