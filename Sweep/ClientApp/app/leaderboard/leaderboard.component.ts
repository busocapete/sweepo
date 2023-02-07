import { Component, OnInit, Input } from '@angular/core';
import { Event } from '../Event';
import { ActivatedRoute } from '@angular/router';
import { SweepService } from '../sweep.service';
import { Location } from '@angular/common';
import { Leaderboard } from '../Leaderboard';



@Component({
  selector: 'app-leaderboard',
  templateUrl: './leaderboard.component.html',
  styleUrls: ['./leaderboard.component.css']
})
export class LeaderboardComponent implements OnInit {

    @Input() leaderboard: Leaderboard;

    constructor(
        private route: ActivatedRoute,
        private service: SweepService,
        private location: Location
    ) { }

    ngOnInit(): void {
        this.getLeaderboard();
    }

    getLeaderboard(): void {
        const id = this.route.snapshot.paramMap.get('id');
        this.service.getLeaderboard(id.toString())
            .subscribe(leaderboard => this.leaderboard = leaderboard);
    }

    goBack(): void {
        this.location.back();
    }

}
