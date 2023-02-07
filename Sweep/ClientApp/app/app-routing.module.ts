import { RouterModule, Routes } from '@angular/router';
import { EventsComponent } from './events/events.component';
import { NgModule } from '@angular/core';
import { DashboardComponent } from './dashboard/dashboard.component';
import { EventDetailComponent } from './event-detail/event-detail.component';
import { PlayEventComponent } from './play-event/play-event.component';
import { ScoreCardComponent } from './score-card/score-card.component';
import { EnterScoreCardComponent } from './enter-score-card/enter-score-card.component';
import { LeaderboardComponent } from './leaderboard/leaderboard.component';
import { SweepDetailComponent } from './sweep-detail/sweep-detail.component';
import { EventResultsComponent } from './event-results/event-results.component';
import { PlayerDetailComponent } from './player-detail/player-detail.component';
import { UserPlayerComponent } from './user-player/user-player.component';
import { VirtualMatchPlayComponent } from './virtual-match-play/virtual-match-play.component';
import { SweepsComponent } from './sweeps/sweeps.component';
import { SweepsAdminComponent } from './sweeps-admin/sweeps-admin.component';
//import { AppComponent } from 'sweepApp/src/app/app.component';

const routes: Routes = [
    { path: '', redirectTo: '/sweeps', pathMatch: 'full' },
    { path: 'events', component: EventsComponent },
    { path: 'sweeps', component: SweepsComponent},
    { path: 'dashboard', component: DashboardComponent },
    { path: 'event/detail/:id', component: EventDetailComponent },
    { path: 'event/play/:id', component: PlayEventComponent },
    { path: 'scorecard/:id', component: ScoreCardComponent },
    { path: 'scorecard/enter/:id', component: EnterScoreCardComponent },
    { path: 'event/leaderboard/:id', component: LeaderboardComponent },
    { path: 'sweep/details/:id', component: SweepDetailComponent },
    { path: 'event/results/:id', component: EventResultsComponent },
    { path: 'player/details/:id', component: PlayerDetailComponent },
    { path: 'user/player', component: UserPlayerComponent },
    { path: 'event/virtual-matches/:id', component: VirtualMatchPlayComponent },
    { path: 'sweeps/admin', component: SweepsAdminComponent }
        
];

@NgModule({
    imports: [RouterModule.forRoot(routes, {
        useHash: true,
        enableTracing: false, // for Debugging Routes turn on
        scrollPositionRestoration: 'enabled'
        
    }
    )],
    exports: [RouterModule]
})
export class AppRoutingModule { }