import { Component, OnInit } from '@angular/core';
import { SweepService } from '../sweep.service';
import { Event } from '../Event';
import { Sweep } from '../Sweep';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
    events: Event[] = [];
    sweeps: Sweep[] = [];

  constructor(private service: SweepService) { }

    ngOnInit() {
        this.getEvents();
        this.getSweeps();
    }

    getEvents(): void {
        this.service.getEvents()
            .subscribe(events => this.events = events.slice(1, 5));
    }

    getSweeps(): void {
        this.service.getSweeps()
            .subscribe(sweeps => this.sweeps = sweeps);
    }

}
