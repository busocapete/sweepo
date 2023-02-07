import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

import { ActivatedRoute } from '@angular/router';
import { SweepService } from '../sweep.service';
import { Location } from '@angular/common';
import { ScoreCard } from '../ScoreCard';
import { Score, CreateScoreCard } from '../Score';

@Component({
  selector: 'app-enter-score-card',
  templateUrl: './enter-score-card.component.html',
  styleUrls: ['./enter-score-card.component.css']
})
export class EnterScoreCardComponent implements OnInit {

    @Input() scoreCard: ScoreCard;
    selectedHole: number;
    selectedScore: Score;

    scores: Score[];

    frontNine: Score[];
    backNine: Score[];


    constructor(private route: ActivatedRoute,
        private service: SweepService,
        private location: Location) {

 }

    ngOnInit() {
        //this.getFrontNine(this.scoreCard);
        this.getScoreCard();

    }


    getScoreCard(): void {
        const id = this.route.snapshot.paramMap.get('id');
        this.service.getScoreCard(id.toString())
            .subscribe(card => {

                this.scoreCard = card;
                this.scores = card.scores;

                if (this.scoreCard.scores.length == 0) {
                    let createScoreCard : CreateScoreCard = {
                        id : this.scoreCard.id,
                        courseId: this.scoreCard.course.id,
                        playerId: this.scoreCard.player.id,
                    }

                    this.service.createScoreCard(createScoreCard)
                        .subscribe(data => {

                            this.service.getScoreCard(id.toString())
                                .subscribe(card => {
                                    this.scoreCard = card;
                                });
                        });
                }
            });
    }

    getFrontNine() {
        const id = this.route.snapshot.paramMap.get('id');
        this.service.getScoreCard(id.toString())
            .subscribe(card => {
                this.scoreCard = card;
                //alert("Button Clicked");
            this.scoreCard.scores = this.scoreCard.scores.filter(s => s.holeNumber < 10);

        })
    }

    getBackNine() {
        //this.getScoreCard();
        const id = this.route.snapshot.paramMap.get('id');
        this.service.getScoreCard(id.toString())
            .subscribe(card => {
                this.scoreCard = card;
                //alert("Button Clicked");
                this.scoreCard.scores = this.scoreCard.scores.filter(s => s.holeNumber > 9);

            })
    }

    getScoreForHole(holeNumber: number) {
        let score = this.scores.find(s => s.holeNumber == holeNumber);
        return score.gross;
    }

    updateCard(): void {
        this.updateCardForm.patchValue({
            courseId: this.scoreCard.course.id,
            playerId: this.scoreCard.player.id,
            id: this.scoreCard.id
        });

        this.service.updateCard(this.updateCardForm.value)
            .subscribe(response => {
                this.getScoreCard();

                //this.updateCardForm.reset();

                $('#cardModal').modal('toggle');
            });

    }

    updateScore(score: Score): void {
        this.updateScoreForm.patchValue({
            holeNumber: score.holeNumber,
            id: score.id,
            courseId: this.scoreCard.course.id,
            playerId: this.scoreCard.player.id,
            cardId: this.scoreCard.id

        });

        
        this.service.updateScore(this.updateScoreForm.value)
            .subscribe(response => {
                var scoreToUpdate = this.scoreCard.scores.find(s => s.id == score.id);
                scoreToUpdate.gross = response.gross;
                scoreToUpdate.nett = response.nett;
                scoreToUpdate.points = response.points;
                //this.selectedHole. = response;

                this.updateScoreForm.reset();
                this.updateScoreForm.patchValue({
                    holeNumber: null

                });

                //this.selectedScore = response;

                $('#enterScoreModal').modal("toggle");

                
                this.selectedHole = null;
                //$("enterScoreModal").modal('toggle');

            });
    }

    getSelectedHole(id: number) {
        this.selectedHole = id;
    }

    getSelectedScore(score: Score) {
        this.selectedScore = score;
    }

    goBack(): void {
        this.location.back();
    }

    updateScoreForm = new FormGroup({
        gross: new FormControl(''),
        holeNumber: new FormControl(''),
        id: new FormControl(''),
        courseId: new FormControl(''),
        playerId: new FormControl(''),
        cardId: new FormControl('')
    
    });

    updateCardForm = new FormGroup({
        first: new FormControl(''),
        second: new FormControl(''),
        third: new FormControl(''),
        fourth: new FormControl(''),
        fifth: new FormControl(''),
        sixth: new FormControl(''),
        seventh: new FormControl(''),
        eighth: new FormControl(''),
        ninth: new FormControl(''),
        tenth: new FormControl(''),
        eleventh: new FormControl(''),
        twelfth: new FormControl(''),
        thirteenth: new FormControl(''),
        fourteenth: new FormControl(''),
        fifteenth: new FormControl(''),
        sixteenth: new FormControl(''),
        seventeenth: new FormControl(''),
        eighteenth: new FormControl(''),
        courseId: new FormControl(''),
        id: new FormControl(''),
        playerId: new FormControl('')
    })

    setCardHoleValues(): void {
        console.log("setting hole values");
        this.updateCardForm.patchValue({
            first: this.getScoreForHole(1),
            second: this.getScoreForHole(2),
            third: this.getScoreForHole(3),
            fourth: this.getScoreForHole(4),
            fifth: this.getScoreForHole(4),
            sixth: this.getScoreForHole(6),
            seventh: this.getScoreForHole(7),
            eighth: this.getScoreForHole(8),
            ninth: this.getScoreForHole(9),
            tenth: this.getScoreForHole(10),
            eleventh: this.getScoreForHole(11),
            twelfth: this.getScoreForHole(12),
            thirteenth: this.getScoreForHole(13),
            fourteenth: this.getScoreForHole(14),
            fifteenth: this.getScoreForHole(15),
            sixteenth: this.getScoreForHole(16),
            seventeenth: this.getScoreForHole(17),
            eighteenth: this.getScoreForHole(18)

        })
    }
}
