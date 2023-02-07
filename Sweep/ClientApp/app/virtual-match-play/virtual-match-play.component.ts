import { Component, OnInit, Input } from '@angular/core';
import { Event } from '../Event';
import { ActivatedRoute } from '@angular/router';
import { SweepService } from '../sweep.service';
import { Location } from '@angular/common';


@Component({
  selector: 'app-virtual-match-play',
  templateUrl: './virtual-match-play.component.html',
  styleUrls: ['./virtual-match-play.component.css']
})
export class VirtualMatchPlayComponent implements OnInit {

    @Input() event: any;
    matchesWon: Array<any>;
    matchesHalved: Array<any>;
    matchesLost: Array<any>;

    winCount

    constructor(
        private route: ActivatedRoute,
        private service: SweepService,
        private location: Location
        ) {  }

    ngOnInit() {
        this.getMatchPlayResults();
        }

    getMatchPlayResults(): void {
        const id = this.route.snapshot.paramMap.get('id');
        this.service.getMatchPlayResults(id.toString())
            .subscribe(event => {
                this.event = event;
            });
    }





}
