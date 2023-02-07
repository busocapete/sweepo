import { Component, OnInit, Input } from '@angular/core';
import { Player } from '../Player';
import { ActivatedRoute } from '@angular/router';
import { SweepService } from '../sweep.service';
import { Location } from '@angular/common';


@Component({
  selector: 'app-player-detail',
  templateUrl: './player-detail.component.html',
  styleUrls: ['./player-detail.component.css']
})
export class PlayerDetailComponent implements OnInit {

    @Input() player: Player;

    constructor(
        private route: ActivatedRoute,
        private service: SweepService,
        private location: Location
    ) { }

    ngOnInit(): void {
        this.getPlayer();
    }

    getPlayer(): void {
        const id = this.route.snapshot.paramMap.get('id');
        this.service.getPlayer(id.toString())
            .subscribe(player => this.player = player);
    }

    goBack(): void {
        this.location.back();
    }

}
