import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { Event } from './Event';
import { MessageService } from './message.service';
import { catchError, map, tap } from 'rxjs/operators';
import { ScoreCard, UpdateCard } from './ScoreCard';
import { Score, CreateScoreCard } from './Score';
import { Leaderboard } from './Leaderboard';
import { Sweep } from './Sweep';
import { Player, PlayerResponse } from './Player';
import { PlayerEntryForm } from './PlayerEntryForm';
import { SweepApproval } from './SweepApproval';
import { UpdateHandicap } from './UpdateHandicap';
import { EventForm } from './EventForm';
import { SweepForm } from './SweepForm';
import * as moment from 'moment';

const httpOptions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json'
    }),

}

const httpOptionsMultiPart = {
    headers: new HttpHeaders({
        'Content-Disposition': 'multipart/form-data'
    }),
}


@Injectable({
  providedIn: 'root'
})
export class SweepService {

    constructor(private http: HttpClient, private messageService: MessageService) { }
    public sweeps = [];
    public events: Event[] = [];
    private sweepsUrl = "/api/sweeps/";
    private sweepsAdminUrl = "api/sweeps/admin";
    private eventsUrl = "api/events/";
    private enterEventUrl = "api/entries/enter";
    private withDrawEntryUrl = "api/entries/withdraw";
    private playEventUrl = "api/entries/play/";
    private scoreCardsUrl = "api/scorecards/";
    private scoresUrl = "api/scores/";
    private createScoreCardUrl = "api/scores/createCard";
    private leaderBoardUrl = "api/leaderboard/";
    private eventResultsUrl = "api/events/results/";
    private playersUrl = "api/players/";
    private virtualMatchesUrl = "api/virtualmatchplay/";
    private createEventDrawUrl = "api/events/draw/";
    private closeEventUrl = "api/events/close/";
    private playerEntryUrl = "api/entries/player/enter/";
    private updateCardUrl = "api/scorecards/update/";
    private updateHandicapUrl = "api/handicaps/"
    private playerRemoveUrl = "api/entries/delete/";



    getSweeps(): Observable<any> {
        this.messageService.add("Getting Sweeps")
        return this.http.get<any>(this.sweepsUrl, httpOptions);
    }

    getAdminSweeps(): Observable<any> {
        return this.http.get<any>(this.sweepsAdminUrl, httpOptions)
            .pipe(
                tap(_ => this.log('fetched Admin Sweeps')),
                catchError(this.handleError<any>('getAdminSweeps'))
                );
    }

    getEvents(): Observable<Event[]> {
        //this.messageService.add("Getting Events")
        return this.http.get<Event[]>(this.eventsUrl, httpOptions)
            .pipe(
                tap(_ => this.log('fetched events')),
                catchError(this.handleError<Event[]>('getEvents', []))
                );
    }

    getLeaderboard(id: string): Observable<Leaderboard> {
        return this.http.get<Leaderboard>(this.leaderBoardUrl + id, httpOptions)
            .pipe(
                tap(_ => this.log('fetched leaderboard')),
                catchError(this.handleError<Leaderboard>('getLeaderBoard'))
            )
    }

    private handleError<T>(operation = 'operation', result?: T) {
        return (error: any): Observable<T> => {
            console.error(error);
            this.log(`${operation} failed: ${error.message}`);

            return of(result as T);
        };
    }

    getEvent(id: string): Observable<Event> {
        return this.http.get<Event>(this.eventsUrl + id, httpOptions).pipe(
            tap(_ => this.log(`fetched event id=${id}`)),
            catchError(this.handleError<Event>(`getEvent id=${id}`))
        );
    }

    getMatchPlayResults(id: string): Observable<Event> {
        return this.http.get<Event>(this.virtualMatchesUrl + id, httpOptions).pipe(
            tap(_ => this.log(`fetched match play results for event id=${id}`)),
            catchError(this.handleError<Event>(`getMatchPlayResults id=${id}`))
        )
    }

    getPlayer(id: string): Observable<Player> {
        return this.http.get<Player>(this.playersUrl + id, httpOptions).pipe(
            tap(_ => this.log(`fetched player id=${id}`)),
            catchError(this.handleError<Player>(`getPlayer id=${id}`))
        );
    }

    getUserPlayerId(): Observable<string> {
        return this.http.get<string>("api/player/getPlayerId", httpOptions)
            .pipe(
                tap(_ => this.log(`fetched playerid`)),
                catchError(this.handleError<string>('getPlayerId'))
            )
    }


    getUserPlayer(): Observable<Player> {
        return this.http.get<Player>("api/player/getUserPlayer", httpOptions)
            .pipe(
                tap(_ => this.log(`fetched userPlayer`)),
                catchError(this.handleError<Player>('getUserPlayer'))
            )
    }


    getEventResults(id: string): Observable<Event> {
        return this.http.get<Event>(this.eventResultsUrl + id, httpOptions).pipe(
            tap(_ => this.log(`fetched event results for eventId=${id}`)),
            catchError(this.handleError<Event>(`getEventResults id=${id}`))
        );
    }

    getSweep(id: string): Observable<Sweep> {
        return this.http.get<Sweep>(this.sweepsUrl + id, httpOptions).pipe(
            tap(_ => this.log(`fetched sweep id=${id}`)),
            catchError(this.handleError<Sweep>(`getSweep id=${id}`))
        );
    }

    getScoreCard(id: string): Observable<ScoreCard> {
        return this.http.get<ScoreCard>(this.scoreCardsUrl + id, httpOptions).pipe(
            tap(_ => this.log(`fetched scorecard id=${id}`)),
            catchError(this.handleError<ScoreCard>(`getScoreCard id=${id}`))
        );
    }

    updateScore(score: Score): Observable<any> {
        return this.http.post(this.scoresUrl, score, httpOptions)
            .pipe(
                tap(_ => this.log(`updated score id=${score.id}`)),
                catchError(this.handleError<any>('updateScore'))
            );
    }

    updateCard(card: UpdateCard): Observable<ScoreCard> {
        return this.http.post<ScoreCard>(this.updateCardUrl, card, httpOptions).pipe(
            tap(_ => this.log(`updated scorecard id = ${card.id}`)),
            catchError(this.handleError<ScoreCard>(`updateScoreCard id=${card.id}`))
        );
    }


    addPlayerToEvent(player: PlayerEntryForm): Observable<PlayerResponse> {
        return this.http.post<PlayerResponse>(this.playerEntryUrl, player, httpOptions)
            .pipe(
                tap(_ => this.log(`created player entry for playerId=${player.playerId} for eventId ${player.eventId}`)),
                catchError(this.handleError<PlayerResponse>('added Player entry'))
            )
    }

    removePlayerFromEvent(player: PlayerEntryForm): Observable<PlayerResponse> {
        return this.http.post<PlayerResponse>(this.playerRemoveUrl, player, httpOptions)
            .pipe(
                tap(_ => this.log(`removed player entry for playerId=${player.playerId} for eventId ${player.eventId}`)),
                catchError(this.handleError<PlayerResponse>('Player entry removed'))
            )
    }


    createScoreCard(createScoreCard: CreateScoreCard): Observable<any> {
        return this.http.post<any>(this.createScoreCardUrl, createScoreCard, httpOptions)
            .pipe(
                tap(_ => this.log(`updated score card id=${createScoreCard.id}`)),
                catchError(this.handleError<any>('createdScoreCard'))
            );
            
    }

    createEventDraw(id: string): Observable<any> {
        return this.http.post<any>(this.createEventDrawUrl + id, httpOptions)
            .pipe(
                tap(_ => this.log(`updated event draw id=${id}`)),
                catchError(this.handleError<any>(`createEventDraw`))
            );
    }

    closeEvent(id: string): Observable<any> {
        return this.http.post<any>(this.closeEventUrl + id, httpOptions)
            .pipe(
                tap(_ => this.log(`updated event oom and handicaps for event id${id}`)),
                catchError(this.handleError<any>(`closedEvent`))
        )
    }

    playEvent(id: string): Observable<Event> {
        this.messageService.add(`Getting event to play id=${id}`);
        return this.http.get<Event>(this.playEventUrl + id, httpOptions);
    }


    joinSweep(id: string): Observable<any> {
        return this.http.post<any>(this.sweepsUrl + 'join/' + id, httpOptions);
    }

    approveSweepRequest(approval: SweepApproval): Observable<Player> {
        return this.http.post<Player>(this.sweepsUrl + 'approve', approval, httpOptions);
    }
    
    enterEvent(event: Event) {
        this.http.post(this.enterEventUrl, event, httpOptions).subscribe();
    }

    createEvent(event: EventForm): Observable<Event> {
        //event.date = event.date.toISOString();
        //event.date = moment(event.date);
        return this.http.post<Event>(this.eventsUrl, event, httpOptions);
    }

    createSweep(sweep: SweepForm): Observable<Sweep> {
        return this.http.post<Sweep>(this.sweepsUrl + 'createSweep', sweep, httpOptions);
    }

    withDrawEntry(event: Event) {
        this.http.post(this.withDrawEntryUrl, event, httpOptions).subscribe();
    }

    updateHandicap(updateHandicap: UpdateHandicap): Observable<Player> {
        return this.http.post<Player>(this.updateHandicapUrl, updateHandicap, httpOptions);
    }

    private log(message: string) {
        this.messageService.add(`EventService: ${message}`);
    }

}
