import { Component, OnInit, Input } from '@angular/core';
import { Event } from '../Event';
import { ActivatedRoute } from '@angular/router';
import { SweepService } from '../sweep.service';
import { Location } from '@angular/common';


@Component({
  selector: 'app-play-event',
  templateUrl: './play-event.component.html',
  styleUrls: ['./play-event.component.css']
})
export class PlayEventComponent implements OnInit {

    @Input() event: Event;

    constructor(
        private route: ActivatedRoute,
        private service: SweepService,
        private location: Location
    ) { }

    ngOnInit(): void {
        this.getEntryToPlay();
    }

    getEntryToPlay(): void {
        const id = this.route.snapshot.paramMap.get('id');
        this.service.playEvent(id.toString())
            .subscribe(event => this.event = event);
    }

    goBack(): void {
        this.location.back();
    }
}
