import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-navbar',
  imports: [RouterLink],      // necesario para que funcione routerLink
  templateUrl: './navbar.html',
  styleUrl: './navbar.css'
})
export class NavbarComponent {}
