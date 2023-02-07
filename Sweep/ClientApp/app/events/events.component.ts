import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { SweepService } from '../sweep.service';
import { Event } from '../Event';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'events-list',
  templateUrl: './events.component.html',
    styleUrls: ['./events.component.css'],
    encapsulation: ViewEncapsulation.Emulated
})
export class EventsComponent implements OnInit {

    public events: Event[] = [];
    selectedEvent: Event;
    currentDate = new Date().toLocaleString();
    eventInFuture: boolean;


  constructor(private service: SweepService) { }

    ngOnInit(): void {
        this.service.getEvents()
            .subscribe(data => {
                this.service.events = data;
                this.events = this.service.events;
            }, error => console.error(error))
    }

    showEntries(event: Event): void {
        this.selectedEvent = event;
    }

    enterEvent(event: Event) {
        this.service.enterEvent(event);
        event.userHasJoined = true;
    }

    isEventInFuture(event: Event) {
        var eventDate = new Date(event.date).toLocaleString()

        return eventDate > this.currentDate;
    }

    withDrawEntry(event: Event) {
        this.service.withDrawEntry(event);
        event.userHasJoined = false;
    }

    userHasJoined(event: Event) {
        return event.userHasJoined;
    }

}

