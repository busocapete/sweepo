import { Component, OnInit, Input } from '@angular/core';
import { Event } from '../Event'; 
import { Player } from '../Player';
import { ActivatedRoute } from '@angular/router';
import { SweepService } from '../sweep.service';
import { Location } from '@angular/common';
import { AuthService } from '../auth.service';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-event-detail',
  templateUrl: './event-detail.component.html',
  styleUrls: ['./event-detail.component.css']
})
export class EventDetailComponent implements OnInit {
    currentDate =  new Date();

    @Input() event: Event;
    groupedEntries: [[], []];
    constructor(
        private route: ActivatedRoute,
        private service: SweepService,
        private location: Location,
        private userService: AuthService
    ) { }

    ngOnInit(): void {
        this.userService.getUserAuthDetails().subscribe(data => {
            this.userService.userAuth = data;
        });
        this.getEvent();
    }

    isUserOwner(event: Event) {
        return this.userService.userAuth.sweepIds.some(s => s == event.sweepId)
    }

    playerHasEntered(player: Player) {
        return this.event.playerNames.some(s => s.id == player.id);
    }

    createDraw(event: Event) {
        this.service.createEventDraw(event.id).subscribe(data => {
            this.event.groupedEntries = data;
        });
    }

    closeEvent(event: Event) {
        this.service.closeEvent(event.id).subscribe(data => {
        });
    }


    addPlayerForm = new FormGroup({
        playerId: new FormControl(''),
        eventId: new FormControl('')
    });

    addPlayerToEvent(playerId: string) {

        this.addPlayerForm.patchValue({
            playerId: playerId,
            eventId: this.event.id
        });

        this.service.addPlayerToEvent(this.addPlayerForm.value)
            .subscribe(response => {
                if (response != null) {
                    console.log("addPlayerResponse: " + response);
                    this.event.playerNames.push(response);
                }

                    this.addPlayerForm.reset();
                    this.addPlayerForm.patchValue({
                        playerId: null
                    })
                
            });

    }

    removePlayerFromEvent(playerId: string) {

        this.addPlayerForm.patchValue({
            playerId: playerId,
            eventId: this.event.id
        });
        this.service.removePlayerFromEvent(this.addPlayerForm.value)
            .subscribe(response => {
                if (response != null) {
                    this.getEvent();
                }
                this.addPlayerForm.reset();
                this.addPlayerForm.patchValue({ playerId: null})
            })
    }

    getEvent(): void {
        const id = this.route.snapshot.paramMap.get('id');
        console.log(this.currentDate);
        this.service.getEvent(id.toString())
            .subscribe(event => {
                this.event = event;
                this.event.playerNames = event.playerNames;
            });
    }

    goBack(): void {
        this.location.back();
    }

}
