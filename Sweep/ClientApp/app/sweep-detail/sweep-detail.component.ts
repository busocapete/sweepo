import { Component, OnInit, Input } from '@angular/core';
import { Event } from '../Event';
import { ActivatedRoute } from '@angular/router';
import { SweepService } from '../sweep.service';
import { Location, DatePipe } from '@angular/common';
import { Sweep } from '../Sweep';
import { Player } from '../Player';
import { UserAuth } from '../UserAuth';
import { AuthService } from '../auth.service';
import { SweepApproval } from '../SweepApproval';
import { UpdateHandicap } from '../UpdateHandicap';
import { FormGroup, FormControl } from '@angular/forms';
import * as moment from 'moment';


@Component({
    selector: 'app-sweep-detail',
    templateUrl: './sweep-detail.component.html',
    styleUrls: ['./sweep-detail.component.css']
})
export class SweepDetailComponent implements OnInit {

    @Input() sweep: Sweep;
    showOOM: boolean = false;
    showEvents: boolean = true;
    showMembers: boolean = false;
    sweepApproval: SweepApproval = null;
    updateHandicap: UpdateHandicap = null;
    selectedPlayer: Player;

    public userAuth: UserAuth;
    constructor(private service: SweepService,
        private route: ActivatedRoute,
        private location: Location,
        private userService: AuthService,
        private datePipe: DatePipe
    ) { }

    ngOnInit(): void {
        this.userService.getUserAuthDetails().subscribe(data => {
            this.userService.userAuth = data;
            this.userAuth = this.userService.userAuth;
        });
        this.getSweep();
    }


    isUserOwner(sweep: Sweep) {
       return this.userService.userAuth.sweepIds.some(s => s == sweep.id);
    }

    getSweep(): void {
        const id = this.route.snapshot.paramMap.get('id');
        this.service.getSweep(id.toString())
            .subscribe(sweep => this.sweep = sweep);
    }

    displayOOM(): void {
        this.showOOM = true;
        this.showMembers = false;
        this.showEvents = false;
    }

    displayMembers(): void {
        this.showOOM = false;
        this.showMembers = true;
        this.showEvents = false;
    }

    displayEvents(): void {
        this.showOOM = false;
        this.showMembers = false;
        this.showEvents = true;
    }

    getSelectedPlayer(player: Player): void {
        this.selectedPlayer = player;
    }

    approveRequest(player: Player): void {

        alert("button works");
        this.sweepApproval = {
            playerId: player.id,
            sweepId: this.sweep.id
        }

        alert("This SweepApproval: " + this.sweepApproval);

        this.service.approveSweepRequest(this.sweepApproval)
            .subscribe(data => {
                this.sweepApproval = null;
                this.sweep.members.unshift(data);

                var playerToRemove = this.sweep.requests.indexOf(player);

                if (playerToRemove !== -1) {
                    this.sweep.requests.splice(playerToRemove, 1);
                }
            })
    }



    updatePlayerHandicap(player: Player): void {
     

        this.updateHandicapForm.patchValue({
            playerId: player.id,
            sweepId: this.sweep.id
        })

        this.service.updateHandicap(this.updateHandicapForm.value).subscribe(data => {
            this.selectedPlayer.currentExactHandicap = data.currentExactHandicap;
            this.selectedPlayer.currentHandicap = data.currentHandicap;
            this.updateHandicapForm.reset();
            this.selectedPlayer = null;
            $('#updateHandicapModal').modal('toggle');
        });
    }

    updateHandicapForm = new FormGroup({
        handicap: new FormControl(''),
        playerId: new FormControl(''),
        sweepId: new FormControl('')
    });

    enterEvent(event: Event) {
        this.service.enterEvent(event);
        event.userHasJoined = true;
    }


    withDrawEntry(event: Event) {
        this.service.withDrawEntry(event);
        event.userHasJoined = false;
    }

    userHasJoined(event: Event) {
        return event.userHasJoined;
    }


    goBack(): void {
        this.location.back();
    }


    createEvent(): void {

        const eventForm = this.createEventForm.value;
        //eventForm.date = this.datePipe.transform(eventForm.date, 'yyyy-MM-dd');
        eventForm.date = new Date(eventForm.date).toISOString();

        console.log(eventForm);


        this.createEventForm.patchValue({
            sweepId: this.sweep.id,
            date: eventForm.date
        });


        this.service.createEvent(this.createEventForm.value).subscribe(data => {
        //this.service.createEvent(eventForm).subscribe(data => {

        this.sweep.events.unshift(data);

            this.createEventForm.reset();

            $('#createEventModal').modal('toggle');

        });
    }

    createEventForm = new FormGroup({
        courseId: new FormControl(''),
        date: new FormControl(''),
        winterHandicaps: new FormControl(false),
        sweepId: new FormControl('')
    })

}
