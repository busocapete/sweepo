import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { SweepService } from '../sweep.service';
import { Location } from '@angular/common';
import { ScoreCard } from '../ScoreCard';
import { Score } from '../Score';



@Component({
  selector: 'app-score-card',
  templateUrl: './score-card.component.html',
  styleUrls: ['./score-card.component.css']
})
export class ScoreCardComponent implements OnInit {

    @Input() scoreCard: ScoreCard;
    constructor(
        private route: ActivatedRoute,
        private service: SweepService,
        private location: Location) {
      
    }

    ngOnInit() {
        this.getScoreCard();
    }


    getScoreCard(): void {
        const id = this.route.snapshot.paramMap.get('id');
        this.service.getScoreCard(id.toString())
            .subscribe(card => this.scoreCard = card);
    }


    goBack(): void {
        this.location.back();
    }


}
