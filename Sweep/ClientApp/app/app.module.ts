import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from "@angular/common/http"; 
import * as $ from "jquery";
import * as bootstrap from "bootstrap";
//import * as moment from 'moment';
//let now = moment().format('LLLL');

import { AppComponent } from './app.component';
import { SweepsComponent } from './sweeps/sweeps.component';
import { SweepService } from './sweep.service';
import { EventsComponent } from './events/events.component';
import { EventDetailComponent } from './event-detail/event-detail.component';
import { MessagesComponent } from './messages/messages.component';
import { MessageService } from './message.service';
import { AppRoutingModule } from './app-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { PlayEventComponent } from './play-event/play-event.component';
import { ScoreCardComponent } from './score-card/score-card.component';
import { EnterScoreCardComponent } from './enter-score-card/enter-score-card.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LeaderboardComponent } from './leaderboard/leaderboard.component';
import { SweepDetailComponent } from './sweep-detail/sweep-detail.component';
import { EventResultsComponent } from './event-results/event-results.component';
import { PlayerDetailComponent } from './player-detail/player-detail.component';
import { UserPlayerComponent } from './user-player/user-player.component';
import { VirtualMatchPlayComponent } from './virtual-match-play/virtual-match-play.component';
import { AuthService } from './auth.service';
import { SweepsAdminComponent } from './sweeps-admin/sweeps-admin.component';
import { DatePipe } from '@angular/common';

import * as moment from 'moment';


@NgModule({
  declarations: [
    AppComponent,
    SweepsComponent,
    EventsComponent,
    EventDetailComponent,
    MessagesComponent,
    DashboardComponent,
    PlayEventComponent,
    ScoreCardComponent,
    EnterScoreCardComponent,
    LeaderboardComponent,
    SweepDetailComponent,
    EventResultsComponent,
    PlayerDetailComponent,
    UserPlayerComponent,
    VirtualMatchPlayComponent,
    SweepsAdminComponent
  ],
  imports: [
      BrowserModule,
      HttpClientModule,
      AppRoutingModule,
      FormsModule,
      ReactiveFormsModule
  ],
    providers: [
        SweepService,
        MessageService,
        AuthService,
        DatePipe
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }
