import { Component, OnInit, Input } from '@angular/core';
import { Player } from '../Player';
import { SweepService } from '../sweep.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-user-player',
  templateUrl: './user-player.component.html',
  styleUrls: ['./user-player.component.css']
})
export class UserPlayerComponent implements OnInit {

    @Input() player: Player;

    constructor(
        private service: SweepService,
        private location: Location
    ) { }

    ngOnInit() {
        this.getUserPlayer();
  }

    getUserPlayer(): void {
        this.service.getUserPlayer()
            .subscribe(player => this.player = player);
    }

    goBack(): void {
        this.location.back();
    }

}
