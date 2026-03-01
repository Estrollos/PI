import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { RouterConstants } from '../../constants/router-constants';
import { NgOptimizedImage } from "@angular/common";

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.html',
  styleUrl: './navbar.css',
  imports: [NgOptimizedImage]
})
export class NavbarComponent {

  constructor(private router: Router) {}

  navToLogin(): void {
    this.router.navigate([RouterConstants.LOGIN]);
  }

  navToEvents(): void {
    this.router.navigate([RouterConstants.EVENTS]);
  }

  navToStore(): void {
    this.router.navigate([RouterConstants.STORE]);
  }

  navToFAQ(): void {
    this.router.navigate([RouterConstants.FAQ]);
  }

  navToHome(): void {
    this.router.navigate([RouterConstants.HOME]);
  }
}


