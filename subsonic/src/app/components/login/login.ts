import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { RouterConstants } from '../../constants/router-constants';

@Component({
  selector: 'app-login',
  imports: [],
  templateUrl: './login.html',
  styleUrl: './login.css',
})
export class Login {

  constructor(private router: Router) {}

  navToForgotPassword(): void {
    this.router.navigate([RouterConstants.FORGOT_PASSWORD]);
  }

  navToCreateAccount(): void {
    this.router.navigate([RouterConstants.CREATE_ACCOUNT]);
  }
}
