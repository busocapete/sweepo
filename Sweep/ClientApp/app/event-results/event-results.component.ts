import { Component, OnInit, Input } from '@angular/core';
import { Event } from '../Event';
import { ActivatedRoute } from '@angular/router';
import { SweepService } from '../sweep.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-event-results',
  templateUrl: './event-results.component.html',
  styleUrls: ['./event-results.component.css']
})
export class EventResultsComponent implements OnInit {

    showOOM: boolean = true;
    showCards: boolean = false;
    showHandicapChanges: boolean = false;

    @Input() event: Event;
    constructor(
        private route: ActivatedRoute,
        private service: SweepService,
        private location: Location
    ) { }

    ngOnInit() {
        this.getEventResults();
    }

    displayCards(): void {
        this.showOOM = false;
        this.showHandicapChanges = false;
        this.showCards = true;
    }

    displayHandicaps(): void {
        this.showOOM = false;
        this.showCards = false;
        this.showHandicapChanges = true;
    }

    displayOOM(): void {
        this.showHandicapChanges = false;
        this.showCards = false;
        this.showOOM = true;
    }

    getEventResults(): void {
        const id = this.route.snapshot.paramMap.get('id');
        this.service.getEventResults(id.toString())
            .subscribe(event => this.event = event);
    }

    goBack(): void {
        this.location.back();
    }

}
