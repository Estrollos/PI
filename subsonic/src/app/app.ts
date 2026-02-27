import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from './components/navbar/navbar';
import { Carousel } from './components/carousel/carousel';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, NavbarComponent, Carousel],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('subsonic');
}
