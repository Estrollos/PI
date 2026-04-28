import { Component, inject } from '@angular/core';
import { EventModel } from '../../../models/event';
import { NgOptimizedImage } from '@angular/common';
import { Input } from '@angular/core';
import { Router } from '@angular/router';
import { RouterConstants } from '../../../constants/router-constants';
import { EventService } from '../../../../services/event-services';

@Component({
  selector: 'app-tickets',
  imports: [NgOptimizedImage],
  templateUrl: './tickets.html',
  styleUrl: './tickets.css',
})
export class Tickets {
  @Input() day: string = '';
  @Input() hour: string = '';
  dia: number = 0;
  hora: number = 0;

  constructor(private router: Router) {}

  navToTicket(): void {
    this.router.navigate([RouterConstants.TICKET]);
  }

  events: EventModel[] = [];
  EventService = inject(EventService);

  ngAfterViewInit() {
    setTimeout(() => {
      this.EventService.getAll().subscribe((events) => {
        this.events = events.$values;
      });
    });
  }

  ngOnInit() {
    switch (this.day) {
      case 'Monday':
        this.dia = 1;
        break;
      case 'Tuesday':
        this.dia = 2;
        break;
      case 'Wednesday':
        this.dia = 3;
        break;
    }

    switch (this.hour) {
      case 'Morning':
        this.hora = 1;
        break;
      case 'Afternoon':
        this.hora = 2;
        break;
      case 'Night':
        this.hora = 3;
        break;
    }
  }
}
