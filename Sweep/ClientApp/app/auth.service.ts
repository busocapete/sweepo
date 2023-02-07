import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { UserAuth } from './UserAuth';

const httpOptions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json'
    })
}

@Injectable({
  providedIn: 'root'
})

export class AuthService {

    public isAuthenticated: boolean = false;
    private authUrl = '/api/account/';
    private playerIdUrl = '/api/account/getUserPlayerId';
    private userSweepOwnerUrl = 'api/account/getUserSweepOwner';
    private userDetailsUrl = '../../api/account/getUserAuthDetails';


    constructor(private http: HttpClient) { }

    public userAuth: UserAuth;

    isUserAuthenticated(): Observable<any> {
        return this.http.get(this.authUrl, httpOptions);
    }

    getUserPlayerId(): Observable<any> {
        return this.http.get(this.playerIdUrl, httpOptions);
    }

    getUserAuthDetails(): Observable<UserAuth> {
        return this.http.get<UserAuth>(this.userDetailsUrl, httpOptions);
    }
}
