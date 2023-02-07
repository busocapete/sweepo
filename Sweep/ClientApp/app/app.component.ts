import { Component, OnInit, OnDestroy, ViewChild, ElementRef } from '@angular/core';
import { SweepService } from './sweep.service';
import { Event, Router, NavigationEnd, NavigationStart, Scroll } from '@angular/router';
import { asyncScheduler } from 'rxjs';
import { filter, observeOn, scan } from 'rxjs/operators';
import { ScrollPositionRestore } from './ScrollPositionRestore';
import { ViewportScroller } from '@angular/common';
import { AuthService } from './auth.service';
import { UserAuth } from './UserAuth';



@Component({
  selector: 'the-sweep',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})


export class AppComponent implements OnInit {

    @ViewChild('contentArea') private contentArea: ElementRef<HTMLMainElement>;

    public userId: string;
    public playerId: string;
    public sweepIds: string[] = [];

    public userAuth: UserAuth;


    constructor(private authService: AuthService,
        router: Router, viewportScroller: ViewportScroller) {
        router.events.pipe(
            filter((e: Event): e is Scroll => e instanceof Scroll)
        ).subscribe(e => {
            if (e.position) {
                // backward navigation
                viewportScroller.scrollToPosition(e.position);
            } else if (e.anchor) {
                // anchor navigation
                viewportScroller.scrollToAnchor(e.anchor);
            } else {
                // forward navigation
                viewportScroller.scrollToPosition([0, 0]);
            }
        });
    }

    ngOnInit() {
        this.authService.getUserAuthDetails().subscribe(data => {
            this.authService.userAuth = data;
            this.userAuth = this.authService.userAuth;
            //this.userId = data.id;
            //this.playerId = data.playerId;
            //this.sweepIds = data.sweepIds;
        })

        //this.router.events
        //    .pipe(
        //        filter(
        //            event =>
        //                event instanceof NavigationStart || event instanceof NavigationEnd,
        //        ),
        //        scan<Event, ScrollPositionRestore>((acc, event) => ({
        //            event,
        //            positions: {
        //                ...acc.positions,
        //                ...(event instanceof NavigationStart
        //                    ? {
        //                        [event.id]: this.contentArea.nativeElement.scrollTop,
        //                    }
        //                    : {}),
        //            },
        //            trigger:
        //                event instanceof NavigationStart
        //                    ? event.navigationTrigger
        //                    : acc.trigger,
        //            idToRestore:
        //                (event instanceof NavigationStart &&
        //                    event.restoredState &&
        //                    event.restoredState.navigationId + 1) ||
        //                acc.idToRestore,
        //        })),
        //        filter(
        //            ({ event, trigger }) => event instanceof NavigationEnd && !!trigger,
        //        ),
        //        observeOn(asyncScheduler),
        //    )
        //    .subscribe(({ trigger, positions, idToRestore }) => {
        //        if (trigger === 'imperative') {
        //            this.contentArea.nativeElement.scrollTop = 0;
        //        }

        //        if (trigger === 'popstate') {
        //            this.contentArea.nativeElement.scrollTop = positions[idToRestore];
        //        }
        //    });
    }
}
