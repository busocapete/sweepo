(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./ClientApp/$$_lazy_route_resource lazy recursive":
/*!****************************************************************!*\
  !*** ./ClientApp/$$_lazy_route_resource lazy namespace object ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./ClientApp/$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./ClientApp/app/app-routing.module.ts":
/*!*********************************************!*\
  !*** ./ClientApp/app/app-routing.module.ts ***!
  \*********************************************/
/*! exports provided: AppRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function() { return AppRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _events_events_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./events/events.component */ "./ClientApp/app/events/events.component.ts");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./dashboard/dashboard.component */ "./ClientApp/app/dashboard/dashboard.component.ts");
/* harmony import */ var _event_detail_event_detail_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./event-detail/event-detail.component */ "./ClientApp/app/event-detail/event-detail.component.ts");
/* harmony import */ var _play_event_play_event_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./play-event/play-event.component */ "./ClientApp/app/play-event/play-event.component.ts");
/* harmony import */ var _score_card_score_card_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./score-card/score-card.component */ "./ClientApp/app/score-card/score-card.component.ts");
/* harmony import */ var _enter_score_card_enter_score_card_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./enter-score-card/enter-score-card.component */ "./ClientApp/app/enter-score-card/enter-score-card.component.ts");
/* harmony import */ var _leaderboard_leaderboard_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./leaderboard/leaderboard.component */ "./ClientApp/app/leaderboard/leaderboard.component.ts");
/* harmony import */ var _sweep_detail_sweep_detail_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./sweep-detail/sweep-detail.component */ "./ClientApp/app/sweep-detail/sweep-detail.component.ts");
/* harmony import */ var _event_results_event_results_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./event-results/event-results.component */ "./ClientApp/app/event-results/event-results.component.ts");
/* harmony import */ var _player_detail_player_detail_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./player-detail/player-detail.component */ "./ClientApp/app/player-detail/player-detail.component.ts");
/* harmony import */ var _user_player_user_player_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./user-player/user-player.component */ "./ClientApp/app/user-player/user-player.component.ts");
/* harmony import */ var _virtual_match_play_virtual_match_play_component__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./virtual-match-play/virtual-match-play.component */ "./ClientApp/app/virtual-match-play/virtual-match-play.component.ts");
/* harmony import */ var _sweeps_sweeps_component__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./sweeps/sweeps.component */ "./ClientApp/app/sweeps/sweeps.component.ts");
/* harmony import */ var _sweeps_admin_sweeps_admin_component__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! ./sweeps-admin/sweeps-admin.component */ "./ClientApp/app/sweeps-admin/sweeps-admin.component.ts");

















//import { AppComponent } from 'sweepApp/src/app/app.component';
var routes = [
    { path: '', redirectTo: '/sweeps', pathMatch: 'full' },
    { path: 'events', component: _events_events_component__WEBPACK_IMPORTED_MODULE_2__["EventsComponent"] },
    { path: 'sweeps', component: _sweeps_sweeps_component__WEBPACK_IMPORTED_MODULE_15__["SweepsComponent"] },
    { path: 'dashboard', component: _dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_4__["DashboardComponent"] },
    { path: 'event/detail/:id', component: _event_detail_event_detail_component__WEBPACK_IMPORTED_MODULE_5__["EventDetailComponent"] },
    { path: 'event/play/:id', component: _play_event_play_event_component__WEBPACK_IMPORTED_MODULE_6__["PlayEventComponent"] },
    { path: 'scorecard/:id', component: _score_card_score_card_component__WEBPACK_IMPORTED_MODULE_7__["ScoreCardComponent"] },
    { path: 'scorecard/enter/:id', component: _enter_score_card_enter_score_card_component__WEBPACK_IMPORTED_MODULE_8__["EnterScoreCardComponent"] },
    { path: 'event/leaderboard/:id', component: _leaderboard_leaderboard_component__WEBPACK_IMPORTED_MODULE_9__["LeaderboardComponent"] },
    { path: 'sweep/details/:id', component: _sweep_detail_sweep_detail_component__WEBPACK_IMPORTED_MODULE_10__["SweepDetailComponent"] },
    { path: 'event/results/:id', component: _event_results_event_results_component__WEBPACK_IMPORTED_MODULE_11__["EventResultsComponent"] },
    { path: 'player/details/:id', component: _player_detail_player_detail_component__WEBPACK_IMPORTED_MODULE_12__["PlayerDetailComponent"] },
    { path: 'user/player', component: _user_player_user_player_component__WEBPACK_IMPORTED_MODULE_13__["UserPlayerComponent"] },
    { path: 'event/virtual-matches/:id', component: _virtual_match_play_virtual_match_play_component__WEBPACK_IMPORTED_MODULE_14__["VirtualMatchPlayComponent"] },
    { path: 'sweeps/admin', component: _sweeps_admin_sweeps_admin_component__WEBPACK_IMPORTED_MODULE_16__["SweepsAdminComponent"] }
];
var AppRoutingModule = /** @class */ (function () {
    function AppRoutingModule() {
    }
    AppRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_3__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forRoot(routes, {
                    useHash: true,
                    enableTracing: false,
                    scrollPositionRestoration: 'enabled'
                })],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"]]
        })
    ], AppRoutingModule);
    return AppRoutingModule;
}());



/***/ }),

/***/ "./ClientApp/app/app.component.css":
/*!*****************************************!*\
  !*** ./ClientApp/app/app.component.css ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL2FwcC5jb21wb25lbnQuY3NzIn0= */"

/***/ }),

/***/ "./ClientApp/app/app.component.html":
/*!******************************************!*\
  !*** ./ClientApp/app/app.component.html ***!
  \******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\r\n<router-outlet></router-outlet>\r\n\r\n\r\n<nav class=\"navbar fixed-bottom navbar-expand navbar-dark bg-info\" *ngIf=\"userAuth\">\r\n    <div class=\"navbar-collapse collapse\">\r\n        <ul class=\"navbar-nav\">\r\n            <li class=\"nav-item\">\r\n                <a class=\"nav-link\" routerLink=\"/\"><i class=\"fas fa-list\"></i> SWEEPS</a>\r\n            </li>\r\n\r\n            <li class=\"nav-item\">\r\n                <a class=\"nav-link\" routerLink=\"/events\"><i class=\"fas fa-list\"></i> EVENTS</a>\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                <a class=\"nav-link\" routerLink=\"/user/player\"><i class=\"fas fa-user\"></i> PLAYER</a>\r\n            </li>\r\n\r\n            <li class=\"nav-item\" *ngIf=\"userAuth.sweepIds.length > 0\">\r\n                <a class=\"nav-link\" routerLink=\"/sweeps/admin\"><i class=\"fas fa-user\"></i> Admin</a>\r\n            </li>\r\n\r\n        </ul>\r\n    </div>\r\n</nav>\r\n"

/***/ }),

/***/ "./ClientApp/app/app.component.ts":
/*!****************************************!*\
  !*** ./ClientApp/app/app.component.ts ***!
  \****************************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm5/operators/index.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _auth_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./auth.service */ "./ClientApp/app/auth.service.ts");






var AppComponent = /** @class */ (function () {
    function AppComponent(authService, router, viewportScroller) {
        this.authService = authService;
        this.sweepIds = [];
        router.events.pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_3__["filter"])(function (e) { return e instanceof _angular_router__WEBPACK_IMPORTED_MODULE_2__["Scroll"]; })).subscribe(function (e) {
            if (e.position) {
                // backward navigation
                viewportScroller.scrollToPosition(e.position);
            }
            else if (e.anchor) {
                // anchor navigation
                viewportScroller.scrollToAnchor(e.anchor);
            }
            else {
                // forward navigation
                viewportScroller.scrollToPosition([0, 0]);
            }
        });
    }
    AppComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.authService.getUserAuthDetails().subscribe(function (data) {
            _this.authService.userAuth = data;
            _this.userAuth = _this.authService.userAuth;
            //this.userId = data.id;
            //this.playerId = data.playerId;
            //this.sweepIds = data.sweepIds;
        });
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
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('contentArea'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"])
    ], AppComponent.prototype, "contentArea", void 0);
    AppComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'the-sweep',
            template: __webpack_require__(/*! ./app.component.html */ "./ClientApp/app/app.component.html"),
            styles: [__webpack_require__(/*! ./app.component.css */ "./ClientApp/app/app.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_auth_service__WEBPACK_IMPORTED_MODULE_5__["AuthService"],
            _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"], _angular_common__WEBPACK_IMPORTED_MODULE_4__["ViewportScroller"]])
    ], AppComponent);
    return AppComponent;
}());



/***/ }),

/***/ "./ClientApp/app/app.module.ts":
/*!*************************************!*\
  !*** ./ClientApp/app/app.module.ts ***!
  \*************************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm5/platform-browser.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./app.component */ "./ClientApp/app/app.component.ts");
/* harmony import */ var _sweeps_sweeps_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./sweeps/sweeps.component */ "./ClientApp/app/sweeps/sweeps.component.ts");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./sweep.service */ "./ClientApp/app/sweep.service.ts");
/* harmony import */ var _events_events_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./events/events.component */ "./ClientApp/app/events/events.component.ts");
/* harmony import */ var _event_detail_event_detail_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./event-detail/event-detail.component */ "./ClientApp/app/event-detail/event-detail.component.ts");
/* harmony import */ var _messages_messages_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./messages/messages.component */ "./ClientApp/app/messages/messages.component.ts");
/* harmony import */ var _message_service__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./message.service */ "./ClientApp/app/message.service.ts");
/* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./app-routing.module */ "./ClientApp/app/app-routing.module.ts");
/* harmony import */ var _dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./dashboard/dashboard.component */ "./ClientApp/app/dashboard/dashboard.component.ts");
/* harmony import */ var _play_event_play_event_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./play-event/play-event.component */ "./ClientApp/app/play-event/play-event.component.ts");
/* harmony import */ var _score_card_score_card_component__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./score-card/score-card.component */ "./ClientApp/app/score-card/score-card.component.ts");
/* harmony import */ var _enter_score_card_enter_score_card_component__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./enter-score-card/enter-score-card.component */ "./ClientApp/app/enter-score-card/enter-score-card.component.ts");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _leaderboard_leaderboard_component__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! ./leaderboard/leaderboard.component */ "./ClientApp/app/leaderboard/leaderboard.component.ts");
/* harmony import */ var _sweep_detail_sweep_detail_component__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! ./sweep-detail/sweep-detail.component */ "./ClientApp/app/sweep-detail/sweep-detail.component.ts");
/* harmony import */ var _event_results_event_results_component__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! ./event-results/event-results.component */ "./ClientApp/app/event-results/event-results.component.ts");
/* harmony import */ var _player_detail_player_detail_component__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! ./player-detail/player-detail.component */ "./ClientApp/app/player-detail/player-detail.component.ts");
/* harmony import */ var _user_player_user_player_component__WEBPACK_IMPORTED_MODULE_21__ = __webpack_require__(/*! ./user-player/user-player.component */ "./ClientApp/app/user-player/user-player.component.ts");
/* harmony import */ var _virtual_match_play_virtual_match_play_component__WEBPACK_IMPORTED_MODULE_22__ = __webpack_require__(/*! ./virtual-match-play/virtual-match-play.component */ "./ClientApp/app/virtual-match-play/virtual-match-play.component.ts");
/* harmony import */ var _auth_service__WEBPACK_IMPORTED_MODULE_23__ = __webpack_require__(/*! ./auth.service */ "./ClientApp/app/auth.service.ts");
/* harmony import */ var _sweeps_admin_sweeps_admin_component__WEBPACK_IMPORTED_MODULE_24__ = __webpack_require__(/*! ./sweeps-admin/sweeps-admin.component */ "./ClientApp/app/sweeps-admin/sweeps-admin.component.ts");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_25__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");




//import * as moment from 'moment';
//let now = moment().format('LLLL');






















var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
            declarations: [
                _app_component__WEBPACK_IMPORTED_MODULE_4__["AppComponent"],
                _sweeps_sweeps_component__WEBPACK_IMPORTED_MODULE_5__["SweepsComponent"],
                _events_events_component__WEBPACK_IMPORTED_MODULE_7__["EventsComponent"],
                _event_detail_event_detail_component__WEBPACK_IMPORTED_MODULE_8__["EventDetailComponent"],
                _messages_messages_component__WEBPACK_IMPORTED_MODULE_9__["MessagesComponent"],
                _dashboard_dashboard_component__WEBPACK_IMPORTED_MODULE_12__["DashboardComponent"],
                _play_event_play_event_component__WEBPACK_IMPORTED_MODULE_13__["PlayEventComponent"],
                _score_card_score_card_component__WEBPACK_IMPORTED_MODULE_14__["ScoreCardComponent"],
                _enter_score_card_enter_score_card_component__WEBPACK_IMPORTED_MODULE_15__["EnterScoreCardComponent"],
                _leaderboard_leaderboard_component__WEBPACK_IMPORTED_MODULE_17__["LeaderboardComponent"],
                _sweep_detail_sweep_detail_component__WEBPACK_IMPORTED_MODULE_18__["SweepDetailComponent"],
                _event_results_event_results_component__WEBPACK_IMPORTED_MODULE_19__["EventResultsComponent"],
                _player_detail_player_detail_component__WEBPACK_IMPORTED_MODULE_20__["PlayerDetailComponent"],
                _user_player_user_player_component__WEBPACK_IMPORTED_MODULE_21__["UserPlayerComponent"],
                _virtual_match_play_virtual_match_play_component__WEBPACK_IMPORTED_MODULE_22__["VirtualMatchPlayComponent"],
                _sweeps_admin_sweeps_admin_component__WEBPACK_IMPORTED_MODULE_24__["SweepsAdminComponent"]
            ],
            imports: [
                _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__["BrowserModule"],
                _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpClientModule"],
                _app_routing_module__WEBPACK_IMPORTED_MODULE_11__["AppRoutingModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_16__["FormsModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_16__["ReactiveFormsModule"]
            ],
            providers: [
                _sweep_service__WEBPACK_IMPORTED_MODULE_6__["SweepService"],
                _message_service__WEBPACK_IMPORTED_MODULE_10__["MessageService"],
                _auth_service__WEBPACK_IMPORTED_MODULE_23__["AuthService"],
                _angular_common__WEBPACK_IMPORTED_MODULE_25__["DatePipe"]
            ],
            bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_4__["AppComponent"]]
        })
    ], AppModule);
    return AppModule;
}());



/***/ }),

/***/ "./ClientApp/app/auth.service.ts":
/*!***************************************!*\
  !*** ./ClientApp/app/auth.service.ts ***!
  \***************************************/
/*! exports provided: AuthService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthService", function() { return AuthService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");



var httpOptions = {
    headers: new _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpHeaders"]({
        'Content-Type': 'application/json'
    })
};
var AuthService = /** @class */ (function () {
    function AuthService(http) {
        this.http = http;
        this.isAuthenticated = false;
        this.authUrl = '/api/account/';
        this.playerIdUrl = '/api/account/getUserPlayerId';
        this.userSweepOwnerUrl = 'api/account/getUserSweepOwner';
        this.userDetailsUrl = '../../api/account/getUserAuthDetails';
    }
    AuthService.prototype.isUserAuthenticated = function () {
        return this.http.get(this.authUrl, httpOptions);
    };
    AuthService.prototype.getUserPlayerId = function () {
        return this.http.get(this.playerIdUrl, httpOptions);
    };
    AuthService.prototype.getUserAuthDetails = function () {
        return this.http.get(this.userDetailsUrl, httpOptions);
    };
    AuthService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
            providedIn: 'root'
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"]])
    ], AuthService);
    return AuthService;
}());



/***/ }),

/***/ "./ClientApp/app/dashboard/dashboard.component.css":
/*!*********************************************************!*\
  !*** ./ClientApp/app/dashboard/dashboard.component.css ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "/* DashboardComponent's private CSS styles */\r\n[class*='col-'] {\r\n    float: left;\r\n    padding-right: 20px;\r\n    padding-bottom: 20px;\r\n}\r\n[class*='col-']:last-of-type {\r\n        padding-right: 0;\r\n    }\r\na {\r\n    text-decoration: none;\r\n}\r\n*, *:after, *:before {\r\n    box-sizing: border-box;\r\n}\r\nh3 {\r\n    text-align: center;\r\n    margin-bottom: 0;\r\n}\r\nh4 {\r\n    position: relative;\r\n}\r\n.grid {\r\n    margin: 0;\r\n}\r\n.col-1-4 {\r\n    width: 25%;\r\n}\r\n.module {\r\n    padding: 20px;\r\n    text-align: center;\r\n    color: #eee;\r\n    max-height: 120px;\r\n    min-width: 120px;\r\n    background-color: #3f525c;\r\n    border-radius: 2px;\r\n}\r\n.module:hover {\r\n        background-color: #eee;\r\n        cursor: pointer;\r\n        color: #607d8b;\r\n    }\r\n.grid-pad {\r\n    padding: 10px 0;\r\n}\r\n.grid-pad > [class*='col-']:last-of-type {\r\n        padding-right: 20px;\r\n    }\r\n@media (max-width: 600px) {\r\n    .module {\r\n        font-size: 10px;\r\n        max-height: 75px;\r\n    }\r\n}\r\n@media (max-width: 1024px) {\r\n    .grid {\r\n        margin: 0;\r\n    }\r\n\r\n    .module {\r\n        min-width: 60px;\r\n    }\r\n}\r\n\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIkNsaWVudEFwcC9hcHAvZGFzaGJvYXJkL2Rhc2hib2FyZC5jb21wb25lbnQuY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBLDRDQUE0QztBQUM1QztJQUNJLFdBQVc7SUFDWCxtQkFBbUI7SUFDbkIsb0JBQW9CO0FBQ3hCO0FBRUk7UUFDSSxnQkFBZ0I7SUFDcEI7QUFFSjtJQUNJLHFCQUFxQjtBQUN6QjtBQUVBO0lBR0ksc0JBQXNCO0FBQzFCO0FBRUE7SUFDSSxrQkFBa0I7SUFDbEIsZ0JBQWdCO0FBQ3BCO0FBRUE7SUFDSSxrQkFBa0I7QUFDdEI7QUFFQTtJQUNJLFNBQVM7QUFDYjtBQUVBO0lBQ0ksVUFBVTtBQUNkO0FBRUE7SUFDSSxhQUFhO0lBQ2Isa0JBQWtCO0lBQ2xCLFdBQVc7SUFDWCxpQkFBaUI7SUFDakIsZ0JBQWdCO0lBQ2hCLHlCQUF5QjtJQUN6QixrQkFBa0I7QUFDdEI7QUFFSTtRQUNJLHNCQUFzQjtRQUN0QixlQUFlO1FBQ2YsY0FBYztJQUNsQjtBQUVKO0lBQ0ksZUFBZTtBQUNuQjtBQUVJO1FBQ0ksbUJBQW1CO0lBQ3ZCO0FBRUo7SUFDSTtRQUNJLGVBQWU7UUFDZixnQkFBZ0I7SUFDcEI7QUFDSjtBQUVBO0lBQ0k7UUFDSSxTQUFTO0lBQ2I7O0lBRUE7UUFDSSxlQUFlO0lBQ25CO0FBQ0oiLCJmaWxlIjoiQ2xpZW50QXBwL2FwcC9kYXNoYm9hcmQvZGFzaGJvYXJkLmNvbXBvbmVudC5jc3MiLCJzb3VyY2VzQ29udGVudCI6WyIvKiBEYXNoYm9hcmRDb21wb25lbnQncyBwcml2YXRlIENTUyBzdHlsZXMgKi9cclxuW2NsYXNzKj0nY29sLSddIHtcclxuICAgIGZsb2F0OiBsZWZ0O1xyXG4gICAgcGFkZGluZy1yaWdodDogMjBweDtcclxuICAgIHBhZGRpbmctYm90dG9tOiAyMHB4O1xyXG59XHJcblxyXG4gICAgW2NsYXNzKj0nY29sLSddOmxhc3Qtb2YtdHlwZSB7XHJcbiAgICAgICAgcGFkZGluZy1yaWdodDogMDtcclxuICAgIH1cclxuXHJcbmEge1xyXG4gICAgdGV4dC1kZWNvcmF0aW9uOiBub25lO1xyXG59XHJcblxyXG4qLCAqOmFmdGVyLCAqOmJlZm9yZSB7XHJcbiAgICAtd2Via2l0LWJveC1zaXppbmc6IGJvcmRlci1ib3g7XHJcbiAgICAtbW96LWJveC1zaXppbmc6IGJvcmRlci1ib3g7XHJcbiAgICBib3gtc2l6aW5nOiBib3JkZXItYm94O1xyXG59XHJcblxyXG5oMyB7XHJcbiAgICB0ZXh0LWFsaWduOiBjZW50ZXI7XHJcbiAgICBtYXJnaW4tYm90dG9tOiAwO1xyXG59XHJcblxyXG5oNCB7XHJcbiAgICBwb3NpdGlvbjogcmVsYXRpdmU7XHJcbn1cclxuXHJcbi5ncmlkIHtcclxuICAgIG1hcmdpbjogMDtcclxufVxyXG5cclxuLmNvbC0xLTQge1xyXG4gICAgd2lkdGg6IDI1JTtcclxufVxyXG5cclxuLm1vZHVsZSB7XHJcbiAgICBwYWRkaW5nOiAyMHB4O1xyXG4gICAgdGV4dC1hbGlnbjogY2VudGVyO1xyXG4gICAgY29sb3I6ICNlZWU7XHJcbiAgICBtYXgtaGVpZ2h0OiAxMjBweDtcclxuICAgIG1pbi13aWR0aDogMTIwcHg7XHJcbiAgICBiYWNrZ3JvdW5kLWNvbG9yOiAjM2Y1MjVjO1xyXG4gICAgYm9yZGVyLXJhZGl1czogMnB4O1xyXG59XHJcblxyXG4gICAgLm1vZHVsZTpob3ZlciB7XHJcbiAgICAgICAgYmFja2dyb3VuZC1jb2xvcjogI2VlZTtcclxuICAgICAgICBjdXJzb3I6IHBvaW50ZXI7XHJcbiAgICAgICAgY29sb3I6ICM2MDdkOGI7XHJcbiAgICB9XHJcblxyXG4uZ3JpZC1wYWQge1xyXG4gICAgcGFkZGluZzogMTBweCAwO1xyXG59XHJcblxyXG4gICAgLmdyaWQtcGFkID4gW2NsYXNzKj0nY29sLSddOmxhc3Qtb2YtdHlwZSB7XHJcbiAgICAgICAgcGFkZGluZy1yaWdodDogMjBweDtcclxuICAgIH1cclxuXHJcbkBtZWRpYSAobWF4LXdpZHRoOiA2MDBweCkge1xyXG4gICAgLm1vZHVsZSB7XHJcbiAgICAgICAgZm9udC1zaXplOiAxMHB4O1xyXG4gICAgICAgIG1heC1oZWlnaHQ6IDc1cHg7XHJcbiAgICB9XHJcbn1cclxuXHJcbkBtZWRpYSAobWF4LXdpZHRoOiAxMDI0cHgpIHtcclxuICAgIC5ncmlkIHtcclxuICAgICAgICBtYXJnaW46IDA7XHJcbiAgICB9XHJcblxyXG4gICAgLm1vZHVsZSB7XHJcbiAgICAgICAgbWluLXdpZHRoOiA2MHB4O1xyXG4gICAgfVxyXG59XHJcbiJdfQ== */"

/***/ }),

/***/ "./ClientApp/app/dashboard/dashboard.component.html":
/*!**********************************************************!*\
  !*** ./ClientApp/app/dashboard/dashboard.component.html ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<!--<h3>Next Events</h3>\r\n<div class=\"grid grid-pad\">\r\n    <a *ngFor=\"let event of events\" class=\"col-1-4\"\r\n       routerLink=\"/eventDetail/{{event.id}}\">\r\n        <div class=\"module hero\">\r\n            <h4>{{event.date}}</h4>\r\n        </div>\r\n    </a>\r\n</div>-->\r\n\r\n\r\n\r\n<div *ngIf=\"sweeps\">\r\n    <div class=\"card\" *ngFor=\"let sweep of sweeps\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <p class=\"navbar-brand\" href=\"#\">{{sweep.name}}</p>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\">\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\" routerLink=\"/sweep/details/{{sweep.id}}\">{{sweep.totalEvents}} Events</a>\r\n\r\n                    </li>\r\n                    <!--<li class=\"nav-item\" *ngIf=\"userHasJoined(event)\">\r\n\r\n                        <a *ngIf=\"!event.notDrawn\" routerLink=\"/event/play/{{event.id}}\" class=\"nav-link\" value=\"Play\">Play</a>\r\n\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <button *ngIf=\"!userHasJoined(event)\" (click)=\"enterEvent(event)\" class=\"btn btn-sm btn-success float-right\" value=\"Join\">Join</button>\r\n\r\n                    </li>-->\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div style=\"text-align:center\">\r\n                <h6>\r\n                    Owner: {{sweep.owner}}\r\n                </h6>\r\n\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./ClientApp/app/dashboard/dashboard.component.ts":
/*!********************************************************!*\
  !*** ./ClientApp/app/dashboard/dashboard.component.ts ***!
  \********************************************************/
/*! exports provided: DashboardComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DashboardComponent", function() { return DashboardComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../sweep.service */ "./ClientApp/app/sweep.service.ts");



var DashboardComponent = /** @class */ (function () {
    function DashboardComponent(service) {
        this.service = service;
        this.events = [];
        this.sweeps = [];
    }
    DashboardComponent.prototype.ngOnInit = function () {
        this.getEvents();
        this.getSweeps();
    };
    DashboardComponent.prototype.getEvents = function () {
        var _this = this;
        this.service.getEvents()
            .subscribe(function (events) { return _this.events = events.slice(1, 5); });
    };
    DashboardComponent.prototype.getSweeps = function () {
        var _this = this;
        this.service.getSweeps()
            .subscribe(function (sweeps) { return _this.sweeps = sweeps; });
    };
    DashboardComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-dashboard',
            template: __webpack_require__(/*! ./dashboard.component.html */ "./ClientApp/app/dashboard/dashboard.component.html"),
            styles: [__webpack_require__(/*! ./dashboard.component.css */ "./ClientApp/app/dashboard/dashboard.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_sweep_service__WEBPACK_IMPORTED_MODULE_2__["SweepService"]])
    ], DashboardComponent);
    return DashboardComponent;
}());



/***/ }),

/***/ "./ClientApp/app/enter-score-card/enter-score-card.component.css":
/*!***********************************************************************!*\
  !*** ./ClientApp/app/enter-score-card/enter-score-card.component.css ***!
  \***********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL2VudGVyLXNjb3JlLWNhcmQvZW50ZXItc2NvcmUtY2FyZC5jb21wb25lbnQuY3NzIn0= */"

/***/ }),

/***/ "./ClientApp/app/enter-score-card/enter-score-card.component.html":
/*!************************************************************************!*\
  !*** ./ClientApp/app/enter-score-card/enter-score-card.component.html ***!
  \************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\r\n\r\n<div *ngIf=\"scoreCard\">\r\n    <nav class=\"navbar sticky-top navbar-expand navbar-dark bg-danger justify-content-end card-nav\">\r\n        <button class=\"btn btn-danger\" (click)=\"goBack()\"><i class=\"fas fa-chevron-left\"></i></button>\r\n        <div class=\"navbar-collapse collapse\">\r\n            <ul class=\"navbar-nav ml-auto\">\r\n\r\n                <li class=\"nav-item\">\r\n                </li>\r\n\r\n\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" data-toggle=\"modal\" data-target=\"#cardModal\" (click)=\"setCardHoleValues()\">Mark</a>\r\n                </li>\r\n\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" routerLink=\"/event/leaderboard/{{scoreCard.eventId}}\"><i class=\"fas fa-trophy\"></i> Leaderboard</a>\r\n                </li>\r\n\r\n            </ul>\r\n        </div>\r\n    </nav>\r\n\r\n\r\n    <div class=\"card\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <a class=\"navbar-brand\" href=\"#\">{{scoreCard.player.fullName}} ({{scoreCard.player.currentHandicap}})</a>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\">\r\n                    <li class=\"nav-item\">\r\n                        <!--<a class=\"nav-link\" routerLink=\"/event/detail/{{event.id}}\"><i class=\"fa fa-users\"></i> {{event.playerNames.length}}</a>-->\r\n\r\n\r\n                    </li>\r\n\r\n                    <!--<li class=\"nav-item\">\r\n                        <a routerLink=\"/event/play/{{event.id}}\" *ngIf=\"userHasJoined(event)\" class=\"nav-link\" value=\"Play\">Play</a>\r\n\r\n                    </li>-->\r\n                    <li class=\"nav-item\">\r\n                        <!--<p class=\"nav-link\">Handicap: {{scoreCard.player.currentHandicap}}</p>-->\r\n                        <a class=\"nav-link\" (click)=\"getFrontNine()\">Out</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <!--<p class=\"nav-link\">Handicap: {{scoreCard.player.currentHandicap}}</p>-->\r\n                        <a class=\"nav-link\" (click)=\"getBackNine()\">In</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <!--<p class=\"nav-link\">Handicap: {{scoreCard.player.currentHandicap}}</p>-->\r\n                        <a class=\"nav-link\" (click)=\"getScoreCard()\">All</a>\r\n                    </li>\r\n\r\n\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <p>Course: {{scoreCard.courseName}}</p>\r\n\r\n\r\n            <table class=\"table table-responsive d-sm-none\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            Hole\r\n                        </th>\r\n                        <th>\r\n                            Par\r\n                        </th>\r\n                        <th>\r\n                            Gross\r\n                        </th>\r\n                        <th>\r\n                            Points\r\n                        </th>\r\n                        <!--<th>\r\n\r\n                        </th>-->\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n                    <tr *ngFor=\"let score of scoreCard.scores\" (click)=\"getSelectedScore(score)\"\r\n                        data-toggle=\"modal\" data-target=\"#enterScoreModal\">\r\n                        <td><strong>{{score.holeNumber}}</strong></td>\r\n                        <td>{{score.par}}</td>\r\n                        <!--<td *ngIf=\"score.gross < score.par\">\r\n                            <p class=\"badge badge-success\">\r\n                                <a class=\"score-entry\" href=\"\" (click)=\"getSelectedScore(score)\"\r\n                                   data-toggle=\"modal\" data-target=\"#enterScoreModal\">\r\n                                    {{score.gross}} <i class=\"fas fa-plus\"></i>\r\n                                </a>\r\n                            </p>\r\n                        </td>\r\n                        <td *ngIf=\"score.gross == score.par\">\r\n                            <p class=\"badge badge-info\">\r\n                                <a class=\"score-entry\" href=\"\" (click)=\"getSelectedScore(score)\"\r\n                                   data-toggle=\"modal\" data-target=\"#enterScoreModal\">\r\n                                    {{score.gross}} <i class=\"fas fa-plus\"></i>\r\n                                </a>\r\n                            </p>\r\n                        </td>\r\n                        <td *ngIf=\"score.gross > score.par\">\r\n                            <p class=\"badge badge-danger\">\r\n                                <a class=\"score-entry\" href=\"\" (click)=\"getSelectedScore(score)\"\r\n                                   data-toggle=\"modal\" data-target=\"#enterScoreModal\">\r\n                                    {{score.gross}} <i class=\"fas fa-plus\"></i>\r\n                                </a>\r\n                            </p>\r\n                        </td>-->\r\n\r\n                        <td *ngIf=\"score.gross < score.par\"><p class=\"badge badge-success\">{{score.gross}}</p></td>\r\n                        <td *ngIf=\"score.gross == score.par\"><p class=\"badge badge-info\">{{score.gross}}</p></td>\r\n                        <td *ngIf=\"score.gross > score.par\"><p class=\"badge badge-danger\">{{score.gross}}</p></td>\r\n\r\n\r\n                        <td *ngIf=\"score.nett < score.par\"><p class=\"badge badge-success\">{{score.points}}</p></td>\r\n                        <td *ngIf=\"score.nett == score.par\"><p class=\"badge badge-info\">{{score.points}}</p></td>\r\n                        <td *ngIf=\"score.nett > score.par\"><p class=\"badge badge-danger\">{{score.points}}</p></td>\r\n\r\n                        <!--<td>\r\n                            <a href=\"\" class=\"btn btn-sm btn-success mb-10\" (click)=\"getSelectedScore(score)\"\r\n                               data-toggle=\"modal\" data-target=\"#enterScoreModal\">{{score.holeNumber}}<i class=\"fas fa-plus\"></i></a>\r\n                        </td>-->\r\n\r\n                    </tr>\r\n                </tbody>\r\n\r\n            </table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n            <table class=\"table table-responsive d-none d-sm-block\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            Hole\r\n                        </th>\r\n                        <th>\r\n                            Par\r\n                        </th>\r\n                        <th>\r\n                            SI\r\n                        </th>\r\n                        <th>\r\n                            Gross\r\n                        </th>\r\n                        <th>\r\n                            Nett\r\n                        </th>\r\n                        <th>\r\n                            Points\r\n                        </th>\r\n                        <!--<th>\r\n\r\n                        </th>-->\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n                    <tr *ngFor=\"let score of scoreCard.scores\" (click)=\"getSelectedScore(score)\"\r\n                        data-toggle=\"modal\" data-target=\"#enterScoreModal\">\r\n                        <td><strong>{{score.holeNumber}}</strong></td>\r\n                        <td>{{score.par}}</td>\r\n                        <td>{{score.index}}</td>\r\n\r\n                        <td *ngIf=\"score.gross < score.par\"><p class=\"badge badge-success\">{{score.gross}}</p></td>\r\n                        <td *ngIf=\"score.gross == score.par\"><p class=\"badge badge-info\">{{score.gross}}</p></td>\r\n                        <td *ngIf=\"score.gross > score.par\"><p class=\"badge badge-danger\">{{score.gross}}</p></td>\r\n\r\n\r\n\r\n                        <td *ngIf=\"score.nett < score.par\"><p class=\"badge badge-success\">{{score.nett}}</p></td>\r\n                        <td *ngIf=\"score.nett == score.par\"><p class=\"badge badge-info\">{{score.nett}}</p></td>\r\n                        <td *ngIf=\"score.nett > score.par\"><p class=\"badge badge-danger\">{{score.nett}}</p></td>\r\n\r\n                        <td *ngIf=\"score.nett < score.par\"><p class=\"badge badge-success\">{{score.points}}</p></td>\r\n                        <td *ngIf=\"score.nett == score.par\"><p class=\"badge badge-info\">{{score.points}}</p></td>\r\n                        <td *ngIf=\"score.nett > score.par\"><p class=\"badge badge-danger\">{{score.points}}</p></td>\r\n\r\n\r\n                    </tr>\r\n                </tbody>\r\n\r\n            </table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n    <button class=\"btn btn-danger\" (click)=\"goBack()\"><i class=\"fas fa-chevron-left\"></i></button>\r\n\r\n</div>\r\n\r\n\r\n\r\n<div *ngIf=\"scoreCard\" class=\"modal fade\" id=\"cardModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myModalLabel\" aria-hidden=\"true\">\r\n    <div class=\"modal-dialog\">\r\n\r\n        <div class=\"modal-content\">\r\n\r\n\r\n                <div class=\"modal-header justify-content-center\">\r\n\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">\r\n                        <i class=\"now-ui-icons ui-1_simple-remove\"></i>\r\n                    </button>\r\n                    <h4 class=\"title title-up\">{{scoreCard.player.fullName}}'s Card</h4>\r\n                </div>\r\n                <div class=\"modal-body\">\r\n                    <form [formGroup]=\"updateCardForm\" (ngSubmit)=\"updateCard()\" novalidate>\r\n\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>1</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"first\" [value]=\"getScoreForHole(1)\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 1\" autofocus>\r\n                                <p></p>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>2</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"second\" value=\"{{getScoreForHole(2)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 2\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>3</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"third\" value=\"{{getScoreForHole(3)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 3\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>4</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"fourth\" value=\"{{getScoreForHole(4)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 4\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>5</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"fifth\" value=\"{{getScoreForHole(5)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 5\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>6</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"sixth\" value=\"{{getScoreForHole(6)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 6\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>7</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"seventh\" value=\"{{getScoreForHole(7)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 7\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>8</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"eighth\" value=\"{{getScoreForHole(8)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 8\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>9</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"ninth\" value=\"{{getScoreForHole(9)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 9\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>10</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"tenth\" value=\"{{getScoreForHole(10)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 10\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>11</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"eleventh\" value=\"{{getScoreForHole(11)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 11\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>12</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"twelfth\" value=\"{{getScoreForHole(12)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 12\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>13</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"thirteenth\" value=\"{{getScoreForHole(13)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 13\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>14</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"fourteenth\" value=\"{{getScoreForHole(14)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 14\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>15</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"fifteenth\" value=\"{{getScoreForHole(15)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 15\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>16</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"sixteenth\" value=\"{{getScoreForHole(16)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 16\" autofocus>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>17</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"seventeenth\" value=\"{{getScoreForHole(17)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 17\" autofocus>\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"row\">\r\n                            <div class=\"col-2\">\r\n                                <h6>18</h6>\r\n                            </div>\r\n                            <div class=\"col-10\">\r\n                                <input type=\"number\" formControlName=\"eighteenth\" value=\"{{getScoreForHole(18)}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole 18\" autofocus>\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n\r\n\r\n\r\n                        <div class=\"row\">\r\n                            <button type=\"submit\" class=\"btn btn-success\">Add Scorecard</button>\r\n\r\n                        </div>\r\n\r\n                    </form>\r\n\r\n\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n                    <!--<button type=\"button\" class=\"btn btn-danger\" data-dismiss=\"modal\">Close</button>-->\r\n\r\n                </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div *ngIf=\"selectedScore\" class=\"modal fade modal-mini\" id=\"enterScoreModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myModalLabel\" aria-hidden=\"true\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-header justify-content-center\">\r\n                Enter Score\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                <div>\r\n                    <form [formGroup]=\"updateScoreForm\" (ngSubmit)=\"updateScore(selectedScore)\" novalidate>\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"input-group wd-sm-400 wd-lg-600\">\r\n                                <input type=\"number\" formControlName=\"gross\" class=\"form-control\" placeholder=\"Add Gross Score for Hole {{selectedScore.holeNumber}}\" autofocus>\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"justify-content-center\">\r\n                                <button type=\"submit\" class=\"btn btn-success\">Update Score</button>\r\n                            </div>\r\n                        </div>\r\n                    </form>\r\n\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <!--<button type=\"button\" class=\"btn btn-link btn-neutral\">Back</button>\r\n                <button type=\"button\" class=\"btn btn-link btn-neutral\" data-dismiss=\"modal\">Close</button>-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<!--<div class=\"container\" *ngIf=\"selectedScore\">\r\n    <div class=\"modal\" tabindex=\"-1\" role=\"dialog\" id=\"enterScoreModal\">\r\n        <div class=\"modal-dialog\" role=\"document\">\r\n            <div class=\"modal-content\">\r\n                <div class=\"modal-header\">\r\n                    <h5 class=\"modal-title\">Enter Score</h5>\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                </div>\r\n                <div class=\"modal-body\">\r\n                    <div>\r\n                        <form [formGroup]=\"updateScoreForm\" (ngSubmit)=\"updateScore(selectedScore)\" novalidate>\r\n\r\n                            <div class=\"form-group\">\r\n                                <div class=\"input-group wd-sm-400 wd-lg-600\">\r\n                                    <input type=\"number\" formControlName=\"gross\" value=\"{{selectedScore.gross}}\" class=\"form-control\" placeholder=\"Add Gross Score for Hole {{selectedScore.holeNumber}}\" autofocus>\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                <button type=\"submit\" class=\"btn btn-success\">Update Score</button>\r\n                            </div>\r\n                        </form>\r\n\r\n\r\n\r\n\r\n                    </div>\r\n\r\n\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>-->\r\n"

/***/ }),

/***/ "./ClientApp/app/enter-score-card/enter-score-card.component.ts":
/*!**********************************************************************!*\
  !*** ./ClientApp/app/enter-score-card/enter-score-card.component.ts ***!
  \**********************************************************************/
/*! exports provided: EnterScoreCardComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EnterScoreCardComponent", function() { return EnterScoreCardComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../sweep.service */ "./ClientApp/app/sweep.service.ts");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");






var EnterScoreCardComponent = /** @class */ (function () {
    function EnterScoreCardComponent(route, service, location) {
        this.route = route;
        this.service = service;
        this.location = location;
        this.updateScoreForm = new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormGroup"]({
            gross: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            holeNumber: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            id: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            courseId: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            playerId: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            cardId: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('')
        });
        this.updateCardForm = new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormGroup"]({
            first: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            second: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            third: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            fourth: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            fifth: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            sixth: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            seventh: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            eighth: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            ninth: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            tenth: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            eleventh: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            twelfth: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            thirteenth: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            fourteenth: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            fifteenth: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            sixteenth: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            seventeenth: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            eighteenth: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            courseId: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            id: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"](''),
            playerId: new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('')
        });
    }
    EnterScoreCardComponent.prototype.ngOnInit = function () {
        //this.getFrontNine(this.scoreCard);
        this.getScoreCard();
    };
    EnterScoreCardComponent.prototype.getScoreCard = function () {
        var _this = this;
        var id = this.route.snapshot.paramMap.get('id');
        this.service.getScoreCard(id.toString())
            .subscribe(function (card) {
            _this.scoreCard = card;
            _this.scores = card.scores;
            if (_this.scoreCard.scores.length == 0) {
                var createScoreCard = {
                    id: _this.scoreCard.id,
                    courseId: _this.scoreCard.course.id,
                    playerId: _this.scoreCard.player.id,
                };
                _this.service.createScoreCard(createScoreCard)
                    .subscribe(function (data) {
                    _this.service.getScoreCard(id.toString())
                        .subscribe(function (card) {
                        _this.scoreCard = card;
                    });
                });
            }
        });
    };
    EnterScoreCardComponent.prototype.getFrontNine = function () {
        var _this = this;
        var id = this.route.snapshot.paramMap.get('id');
        this.service.getScoreCard(id.toString())
            .subscribe(function (card) {
            _this.scoreCard = card;
            //alert("Button Clicked");
            _this.scoreCard.scores = _this.scoreCard.scores.filter(function (s) { return s.holeNumber < 10; });
        });
    };
    EnterScoreCardComponent.prototype.getBackNine = function () {
        var _this = this;
        //this.getScoreCard();
        var id = this.route.snapshot.paramMap.get('id');
        this.service.getScoreCard(id.toString())
            .subscribe(function (card) {
            _this.scoreCard = card;
            //alert("Button Clicked");
            _this.scoreCard.scores = _this.scoreCard.scores.filter(function (s) { return s.holeNumber > 9; });
        });
    };
    EnterScoreCardComponent.prototype.getScoreForHole = function (holeNumber) {
        var score = this.scores.find(function (s) { return s.holeNumber == holeNumber; });
        return score.gross;
    };
    EnterScoreCardComponent.prototype.updateCard = function () {
        var _this = this;
        this.updateCardForm.patchValue({
            courseId: this.scoreCard.course.id,
            playerId: this.scoreCard.player.id,
            id: this.scoreCard.id
        });
        this.service.updateCard(this.updateCardForm.value)
            .subscribe(function (response) {
            _this.getScoreCard();
            //this.updateCardForm.reset();
            $('#cardModal').modal('toggle');
        });
    };
    EnterScoreCardComponent.prototype.updateScore = function (score) {
        var _this = this;
        this.updateScoreForm.patchValue({
            holeNumber: score.holeNumber,
            id: score.id,
            courseId: this.scoreCard.course.id,
            playerId: this.scoreCard.player.id,
            cardId: this.scoreCard.id
        });
        this.service.updateScore(this.updateScoreForm.value)
            .subscribe(function (response) {
            var scoreToUpdate = _this.scoreCard.scores.find(function (s) { return s.id == score.id; });
            scoreToUpdate.gross = response.gross;
            scoreToUpdate.nett = response.nett;
            scoreToUpdate.points = response.points;
            //this.selectedHole. = response;
            _this.updateScoreForm.reset();
            _this.updateScoreForm.patchValue({
                holeNumber: null
            });
            //this.selectedScore = response;
            $('#enterScoreModal').modal("toggle");
            _this.selectedHole = null;
            //$("enterScoreModal").modal('toggle');
        });
    };
    EnterScoreCardComponent.prototype.getSelectedHole = function (id) {
        this.selectedHole = id;
    };
    EnterScoreCardComponent.prototype.getSelectedScore = function (score) {
        this.selectedScore = score;
    };
    EnterScoreCardComponent.prototype.goBack = function () {
        this.location.back();
    };
    EnterScoreCardComponent.prototype.setCardHoleValues = function () {
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
        });
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], EnterScoreCardComponent.prototype, "scoreCard", void 0);
    EnterScoreCardComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-enter-score-card',
            template: __webpack_require__(/*! ./enter-score-card.component.html */ "./ClientApp/app/enter-score-card/enter-score-card.component.html"),
            styles: [__webpack_require__(/*! ./enter-score-card.component.css */ "./ClientApp/app/enter-score-card/enter-score-card.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_3__["ActivatedRoute"],
            _sweep_service__WEBPACK_IMPORTED_MODULE_4__["SweepService"],
            _angular_common__WEBPACK_IMPORTED_MODULE_5__["Location"]])
    ], EnterScoreCardComponent);
    return EnterScoreCardComponent;
}());



/***/ }),

/***/ "./ClientApp/app/event-detail/event-detail.component.css":
/*!***************************************************************!*\
  !*** ./ClientApp/app/event-detail/event-detail.component.css ***!
  \***************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL2V2ZW50LWRldGFpbC9ldmVudC1kZXRhaWwuY29tcG9uZW50LmNzcyJ9 */"

/***/ }),

/***/ "./ClientApp/app/event-detail/event-detail.component.html":
/*!****************************************************************!*\
  !*** ./ClientApp/app/event-detail/event-detail.component.html ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div *ngIf=\"event\">\r\n\r\n    <nav *ngIf=\"isUserOwner(event)\" class=\"navbar sticky-top navbar-expand navbar-dark bg-danger justify-content-end card-nav\">\r\n        <a class=\"navbar-brand\" href=\"#\">Manage</a>\r\n        <div class=\"navbar-collapse collapse\">\r\n            <ul class=\"navbar-nav ml-auto\">\r\n\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" data-toggle=\"modal\" data-target=\"#addPlayersModal\"><i class=\"fas fa-user-plus\"></i></a>\r\n                </li>\r\n\r\n\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" (click)=\"createDraw(event)\">Create Draw</a>\r\n                </li>\r\n\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" (click)=\"closeEvent(event)\">Close Event</a>\r\n                </li>\r\n\r\n            </ul>\r\n        </div>\r\n    </nav>\r\n\r\n\r\n\r\n    <div class=\"card\" *ngIf=\"event.groupedEntries\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <a class=\"navbar-brand\" href=\"#\">{{event.date | date: long}} | Groups</a>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\"></ul>\r\n            </div>\r\n        </nav>\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div style=\"text-align:center\">\r\n                <div *ngFor=\"let group of event.groupedEntries; let i = index\">\r\n                    <h5>Group {{i+1}}</h5>\r\n                    <ul *ngFor=\"let entry of group\">\r\n                        <li>\r\n                            <h6>{{entry.scoreCard.player.fullName}}</h6>\r\n                            <p>to mark: {{entry.marker.player.fullName}}'s card</p>\r\n                            <a *ngIf=\"isUserOwner(event)\" routerLink=\"/scorecard/enter/{{entry.scoreCard.id}}\">Mark Card</a>\r\n                        </li>\r\n                    </ul>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card\" *ngIf=\"!event.groupedEntries\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <a class=\"navbar-brand\" href=\"#\">{{event.date | date: long}} | Players</a>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\">\r\n                    <!--<li class=\"nav-item\">\r\n                        <a class=\"nav-link\" routerLink=\"/event/detail/{{event.id}}\"><i class=\"fa fa-users\"></i> {{event.playerNames.length}}</a>\r\n\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a routerLink=\"/event/play/{{event.id}}\" *ngIf=\"userHasJoined(event)\" class=\"nav-link\" value=\"Play\">Play</a>\r\n\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <button *ngIf=\"!userHasJoined(event)\" (click)=\"enterEvent(event)\" class=\"btn btn-sm btn-success float-right\" value=\"Join\">Join</button>\r\n\r\n                    </li>-->\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <!--<div style=\"text-align:center\">\r\n                <ul *ngFor=\"let player of event.playerNames\">\r\n                    <li>\r\n                        <p>{{player.name}}<span><button class=\"btn btn-sm btn-danger\" (click)=\"removePlayerFromEvent(player.id)\"><i class=\"fas fa-remove\"></i></button></span></p>\r\n                    </li>\r\n                </ul>\r\n            </div>-->\r\n\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>Player</th>\r\n                        <th *ngIf=\"isUserOwner(event)\"></th>\r\n                    </tr>\r\n\r\n                </thead>\r\n                <tbody>\r\n                    <tr *ngFor=\"let player of event.playerNames\">\r\n                        <th>{{player.name}}</th>\r\n                        <td *ngIf=\"isUserOwner(event)\"><button class=\"btn btn-sm btn-danger\" (click)=\"removePlayerFromEvent(player.id)\"><i class=\"fas fa-times\"></i></button></td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<button class=\"btn btn-danger\" (click)=\"goBack()\"><i class=\"fas fa-chevron-left\"></i></button>\r\n\r\n\r\n\r\n<div *ngIf=\"event\">\r\n    <div *ngIf=\"event.sweepMembers\" class=\"modal fade\" id=\"addPlayersModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myModalLabel\" aria-hidden=\"true\">\r\n        <div class=\"modal-dialog\">\r\n            <div class=\"modal-content\">\r\n                <div class=\"modal-header justify-content-center\">\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">\r\n                        <i class=\"now-ui-icons ui-1_simple-remove\"></i>\r\n                    </button>\r\n                    <h4 class=\"title title-up\">Add Players</h4>\r\n                </div>\r\n                <div class=\"modal-body\">\r\n                    <div>\r\n                        <table class=\"table\">\r\n                            <thead>\r\n                                <tr>\r\n                                    <th>Player</th>\r\n                                    <th></th>\r\n                                </tr>\r\n\r\n                            </thead>\r\n                            <tbody>\r\n                                <tr *ngFor=\"let player of event.sweepMembers\">\r\n                                    <th *ngIf=\"!playerHasEntered(player)\">{{player.fullName}}</th>\r\n                                    <td *ngIf=\"!playerHasEntered(player)\"><button class=\"btn btn-sm btn-success\" (click)=\"addPlayerToEvent(player.id)\"><i class=\"fas fa-plus\"></i></button></td>\r\n                                </tr>\r\n                            </tbody>\r\n                        </table>\r\n\r\n\r\n                        <!--<form [formGroup]=\"updateScoreForm\" (ngSubmit)=\"updateScore(selectedScore)\" novalidate>\r\n\r\n                <div class=\"form-group\">\r\n                    <div class=\"input-group wd-sm-400 wd-lg-600\">\r\n                        <input type=\"number\" formControlName=\"gross\" class=\"form-control\" placeholder=\"Add Gross Score for Hole {{selectedScore.holeNumber}}\" autofocus>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <div class=\"justify-content-center\">\r\n                        <button type=\"submit\" class=\"btn btn-success\">Update Score</button>\r\n                    </div>\r\n                </div>\r\n            </form>-->\r\n\r\n\r\n\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n                    <!--<button type=\"button\" class=\"btn btn-link btn-neutral\">Back</button>\r\n        <button type=\"button\" class=\"btn btn-link btn-neutral\" data-dismiss=\"modal\">Close</button>-->\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./ClientApp/app/event-detail/event-detail.component.ts":
/*!**************************************************************!*\
  !*** ./ClientApp/app/event-detail/event-detail.component.ts ***!
  \**************************************************************/
/*! exports provided: EventDetailComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EventDetailComponent", function() { return EventDetailComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../sweep.service */ "./ClientApp/app/sweep.service.ts");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _auth_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../auth.service */ "./ClientApp/app/auth.service.ts");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");







var EventDetailComponent = /** @class */ (function () {
    function EventDetailComponent(route, service, location, userService) {
        this.route = route;
        this.service = service;
        this.location = location;
        this.userService = userService;
        this.currentDate = new Date();
        this.addPlayerForm = new _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormGroup"]({
            playerId: new _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormControl"](''),
            eventId: new _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormControl"]('')
        });
    }
    EventDetailComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.userService.getUserAuthDetails().subscribe(function (data) {
            _this.userService.userAuth = data;
        });
        this.getEvent();
    };
    EventDetailComponent.prototype.isUserOwner = function (event) {
        return this.userService.userAuth.sweepIds.some(function (s) { return s == event.sweepId; });
    };
    EventDetailComponent.prototype.playerHasEntered = function (player) {
        return this.event.playerNames.some(function (s) { return s.id == player.id; });
    };
    EventDetailComponent.prototype.createDraw = function (event) {
        var _this = this;
        this.service.createEventDraw(event.id).subscribe(function (data) {
            _this.event.groupedEntries = data;
        });
    };
    EventDetailComponent.prototype.closeEvent = function (event) {
        this.service.closeEvent(event.id).subscribe(function (data) {
        });
    };
    EventDetailComponent.prototype.addPlayerToEvent = function (playerId) {
        var _this = this;
        this.addPlayerForm.patchValue({
            playerId: playerId,
            eventId: this.event.id
        });
        this.service.addPlayerToEvent(this.addPlayerForm.value)
            .subscribe(function (response) {
            if (response != null) {
                console.log("addPlayerResponse: " + response);
                _this.event.playerNames.push(response);
            }
            _this.addPlayerForm.reset();
            _this.addPlayerForm.patchValue({
                playerId: null
            });
        });
    };
    EventDetailComponent.prototype.removePlayerFromEvent = function (playerId) {
        var _this = this;
        this.addPlayerForm.patchValue({
            playerId: playerId,
            eventId: this.event.id
        });
        this.service.removePlayerFromEvent(this.addPlayerForm.value)
            .subscribe(function (response) {
            if (response != null) {
                _this.getEvent();
            }
            _this.addPlayerForm.reset();
            _this.addPlayerForm.patchValue({ playerId: null });
        });
    };
    EventDetailComponent.prototype.getEvent = function () {
        var _this = this;
        var id = this.route.snapshot.paramMap.get('id');
        console.log(this.currentDate);
        this.service.getEvent(id.toString())
            .subscribe(function (event) {
            _this.event = event;
            _this.event.playerNames = event.playerNames;
        });
    };
    EventDetailComponent.prototype.goBack = function () {
        this.location.back();
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], EventDetailComponent.prototype, "event", void 0);
    EventDetailComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-event-detail',
            template: __webpack_require__(/*! ./event-detail.component.html */ "./ClientApp/app/event-detail/event-detail.component.html"),
            styles: [__webpack_require__(/*! ./event-detail.component.css */ "./ClientApp/app/event-detail/event-detail.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"],
            _sweep_service__WEBPACK_IMPORTED_MODULE_3__["SweepService"],
            _angular_common__WEBPACK_IMPORTED_MODULE_4__["Location"],
            _auth_service__WEBPACK_IMPORTED_MODULE_5__["AuthService"]])
    ], EventDetailComponent);
    return EventDetailComponent;
}());



/***/ }),

/***/ "./ClientApp/app/event-results/event-results.component.css":
/*!*****************************************************************!*\
  !*** ./ClientApp/app/event-results/event-results.component.css ***!
  \*****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL2V2ZW50LXJlc3VsdHMvZXZlbnQtcmVzdWx0cy5jb21wb25lbnQuY3NzIn0= */"

/***/ }),

/***/ "./ClientApp/app/event-results/event-results.component.html":
/*!******************************************************************!*\
  !*** ./ClientApp/app/event-results/event-results.component.html ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\r\n<button class=\"btn btn-danger\" (click)=\"goBack()\"><i class=\"fas fa-chevron-left\"></i></button>\r\n\r\n<div *ngIf=\"event\">\r\n    <div class=\"card\" *ngIf=\"showOOM\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <p class=\"navbar-brand\" href=\"#\">ORDER OF MERIT {{event.date | date:short}}</p>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\">\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\" (click)=\"displayCards()\"><i class=\"fas fa-id-card\"></i> CARDS</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\" routerLink=\"/event/virtual-matches/{{event.id}}\"><i class=\"fas fa-users\"></i> Matches</a>\r\n                    </li>\r\n                    <!--<li class=\"nav-item\">\r\n                        <a class=\"nav-link\" (click)=\"displayHandicaps()\"><i class=\"fas fa-wheelchair\"></i></a>\r\n\r\n                    </li>-->\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n\r\n            <table class=\"table table-responsive d-sm-none\">\r\n                <thead>\r\n\r\n                    <tr>\r\n                        <th>Player</th>\r\n                        <th>Hcap</th>\r\n                        <th>Pts</th>\r\n                        <th>OOM</th>\r\n                        <th></th>\r\n                    </tr>\r\n                    <tr></tr>\r\n\r\n                </thead>\r\n                <tbody *ngFor=\"let entry of event.oomPoints\">\r\n\r\n                        <tr>\r\n\r\n                            <td>\r\n                                <h6>{{entry.card.player.fullName}}</h6>\r\n                            </td>\r\n                            <td>\r\n                                {{entry.card.player.currentHandicap}}\r\n                            </td>\r\n                            <td>\r\n                                {{entry.card.totalPoints}}\r\n                            </td>\r\n                            <th>\r\n                                {{entry.points}}\r\n                            </th>\r\n                            <th>\r\n                                <a class=\"btn btn-sm btn-info\" data-toggle=\"collapse\" href=\"#showDetail-{{entry.card.id}}\" role=\"button\" aria-expanded=\"false\" aria-controls=\"multiCollapseExample1\"><i class=\"fas fa-chevron-down\"></i></a>\r\n                            </th>\r\n                        </tr>\r\n\r\n                    <tr class=\"collapse\" id=\"showDetail-{{entry.card.id}}\">\r\n                        <td></td>\r\n                        <td><strong>In:</strong> {{entry.card.inPoints}}</td>\r\n                        <td><strong>Out:</strong> {{entry.card.outPoints}}</td>\r\n                        <td><strong>L6:</strong> {{entry.card.lastSixPoints}}</td>\r\n                        <td><strong>L3:</strong> {{entry.card.lastThreePoints}}</td>\r\n                    </tr>\r\n\r\n                </tbody>\r\n\r\n            </table>\r\n\r\n\r\n            <table class=\"table table-responsive d-none d-sm-block\">\r\n                <thead>\r\n\r\n                    <tr>\r\n                        <th>Player</th>\r\n                        <th>Hcap</th>\r\n                        <th>Pts</th>\r\n                        <th>In</th>\r\n                        <th>Out</th>\r\n                        <th>6</th>\r\n                        <th>3</th>\r\n                        <th>OOM</th>\r\n                    </tr>\r\n\r\n                </thead>\r\n                <tbody>\r\n                    <tr *ngFor=\"let entry of event.oomPoints\">\r\n                        <td>\r\n                            {{entry.card.player.fullName}}\r\n                        </td>\r\n                        <td>\r\n                            {{entry.card.player.currentHandicap}}\r\n                        </td>\r\n                        <td>\r\n                            {{entry.card.totalPoints}}\r\n                        </td>\r\n                        <td>\r\n                            {{entry.card.inPoints}}\r\n                        </td>\r\n                        <td>\r\n                            {{entry.card.outPoints}}\r\n                        </td>\r\n                        <td>\r\n                            {{entry.card.lastSixPoints}}\r\n                        </td>\r\n                        <td>\r\n                            {{entry.card.lastThreePoints}}\r\n                        </td>\r\n                        <th>\r\n                            {{entry.points}}\r\n                        </th>\r\n                    </tr>\r\n\r\n                </tbody>\r\n\r\n            </table>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n    <div class=\"card\" *ngIf=\"showCards\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <p class=\"navbar-brand\" href=\"#\">CARDS {{event.date | date:short}}</p>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\">\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\" (click)=\"displayOOM()\"><i class=\"fas fa-trophy\"></i></a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\" (click)=\"displayHandicaps()\"><i class=\"fas fa-wheelchair\"></i></a>\r\n\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div *ngFor=\"let card of event.cards\">\r\n                <div class=\"row\">\r\n\r\n                    <h6 class=\"col-6\"><a class=\"tx-black\" data-toggle=\"collapse\" href=\"#showScores-{{card.id}}\" role=\"button\">{{card.player.fullName}}</a></h6>\r\n                    <div class=\"col-4\">\r\n                        Gross <br />\r\n                        Nett <br />\r\n                        Points\r\n                    </div>\r\n                    <div class=\"col-2\">\r\n                        <strong>{{card.totalGross}}</strong> <br />\r\n                        <strong>{{card.totalNett}}</strong> <br />\r\n                        <strong>{{card.totalPoints}}</strong>\r\n                    </div>\r\n                    <!--<div class=\"col-2\">\r\n                        <a class=\"btn btn-sm btn-info\" data-toggle=\"collapse\" href=\"#showScores-{{card.id}}\" role=\"button\" aria-expanded=\"false\" aria-controls=\"multiCollapseExample1\"><i class=\"fas fa-chevron-down\"></i></a>\r\n\r\n                    </div>-->\r\n                </div>\r\n\r\n                <div class=\"collapse\" id=\"showScores-{{card.id}}\">\r\n\r\n                    <hr />\r\n                    <table>\r\n                        <thead>\r\n                            <tr>\r\n                                <th class=\"d-none d-sm-block\" style=\"text-align:center\"></th>\r\n                                <th style=\"text-align:center\">1</th>\r\n                                <th style=\"text-align:center\">2</th>\r\n                                <th style=\"text-align:center\">3</th>\r\n                                <th style=\"text-align:center\">4</th>\r\n                                <th style=\"text-align:center\">5</th>\r\n                                <th style=\"text-align:center\">6</th>\r\n                                <th style=\"text-align:center\">7</th>\r\n                                <th style=\"text-align:center\">8</th>\r\n                                <th style=\"text-align:center\">9</th>\r\n                                <th style=\"text-align:center\"></th>\r\n                                <th style=\"text-align:center\">Total</th>\r\n                                \r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n                            <tr>\r\n                                <td class=\"d-none d-sm-block\">Gross</td>\r\n                                <td *ngFor=\"let score of card.frontNine\">\r\n                                    <span *ngIf=\"score.gross < score.par\" class=\"badge badge-success\">{{score.gross}}</span>\r\n                                    <span *ngIf=\"score.gross == score.par\" class=\"badge badge-info\">{{score.gross}}</span>\r\n                                    <span *ngIf=\"score.gross > score.par\" class=\"badge badge-danger\">{{score.gross}}</span>\r\n\r\n                                </td>\r\n                                <td>\r\n                                   \r\n                                </td>\r\n                                <td>\r\n                                    <strong>{{card.outGross}}</strong>                                \r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"d-none d-sm-block\">Nett</td>\r\n                                <td *ngFor=\"let score of card.frontNine\">\r\n                                    <span *ngIf=\"score.nett < score.par\" class=\"badge badge-success\">{{score.nett}}</span>\r\n                                    <span *ngIf=\"score.nett == score.par\" class=\"badge badge-info\">{{score.nett}}</span>\r\n                                    <span *ngIf=\"score.nett > score.par\" class=\"badge badge-danger\">{{score.nett}}</span>\r\n\r\n                                </td>\r\n                                <td></td>\r\n                                <td><strong>{{card.outNett}}</strong></td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"d-none d-sm-block\">Points</td>\r\n                                <td *ngFor=\"let score of card.frontNine\">\r\n                                    <span *ngIf=\"score.nett < score.par\" class=\"badge badge-success\">{{score.points}}</span>\r\n                                    <span *ngIf=\"score.nett == score.par\" class=\"badge badge-info\">{{score.points}}</span>\r\n                                    <span *ngIf=\"score.nett > score.par\" class=\"badge badge-danger\">{{score.points}}</span>\r\n\r\n                                </td>\r\n                                <td></td>\r\n                                <td><strong>{{card.outPoints}}</strong></td>\r\n\r\n                            </tr>\r\n                            <tr>\r\n                                <th class=\"d-none d-sm-block\" style=\"text-align:center\"></th>\r\n                                <th style=\"text-align:center\">10</th>\r\n                                <th style=\"text-align:center\">11</th>\r\n                                <th style=\"text-align:center\">12</th>\r\n                                <th style=\"text-align:center\">13</th>\r\n                                <th style=\"text-align:center\">14</th>\r\n                                <th style=\"text-align:center\">15</th>\r\n                                <th style=\"text-align:center\">16</th>\r\n                                <th style=\"text-align:center\">17</th>\r\n                                <th style=\"text-align:center\">18</th>\r\n                                <th style=\"text-align:center\"></th>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"d-none d-sm-block\">Gross</td>\r\n                                <td *ngFor=\"let score of card.backNine\">\r\n                                    <span *ngIf=\"score.gross < score.par\" class=\"badge badge-success\">{{score.gross}}</span>\r\n                                    <span *ngIf=\"score.gross == score.par\" class=\"badge badge-info\">{{score.gross}}</span>\r\n                                    <span *ngIf=\"score.gross > score.par\" class=\"badge badge-danger\">{{score.gross}}</span>\r\n\r\n                                </td>\r\n                                <td></td>\r\n                                <td><strong>{{card.inGross}}</strong></td>\r\n\r\n                            </tr>\r\n\r\n                            <tr>\r\n                                <td class=\"d-none d-sm-block\">Nett</td>\r\n                                <td *ngFor=\"let score of card.backNine\">\r\n                                    <span *ngIf=\"score.nett < score.par\" class=\"badge badge-success\">{{score.nett}}</span>\r\n                                    <span *ngIf=\"score.nett == score.par\" class=\"badge badge-info\">{{score.nett}}</span>\r\n                                    <span *ngIf=\"score.nett > score.par\" class=\"badge badge-danger\">{{score.nett}}</span>\r\n\r\n                                </td>\r\n                                <td></td>\r\n                                <td><strong>{{card.outNett}}</strong></td>\r\n\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"d-none d-sm-block\">Points</td>\r\n                                <td *ngFor=\"let score of card.backNine\">\r\n                                    <span *ngIf=\"score.nett < score.par\" class=\"badge badge-success\">{{score.points}}</span>\r\n                                    <span *ngIf=\"score.nett == score.par\" class=\"badge badge-info\">{{score.points}}</span>\r\n                                    <span *ngIf=\"score.nett > score.par\" class=\"badge badge-danger\">{{score.points}}</span>\r\n\r\n                                </td>\r\n                                <td></td>\r\n                                <td><strong>{{card.inPoints}}</strong></td>\r\n\r\n                            </tr>\r\n\r\n                            <tr></tr>\r\n                        </tbody>\r\n                    </table>\r\n                    <!--<h6>Gross</h6>\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12\">\r\n                            <span *ngFor=\"let score of card.frontNine\">\r\n                                <span *ngIf=\"score.gross < score.par\" class=\"badge badge-success\">{{score.gross}}</span>\r\n                                <span *ngIf=\"score.gross == score.par\" class=\"badge badge-info\">{{score.gross}}</span>\r\n                                <span *ngIf=\"score.gross > score.par\" class=\"badge badge-danger\">{{score.gross}}</span>\r\n                            </span>\r\n                            <span class=\"badge badge-success\">{{card.outGross}}</span>\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12\">\r\n                            <span *ngFor=\"let score of card.backNine\">\r\n                                <span *ngIf=\"score.gross < score.par\" class=\"badge badge-success\">{{score.gross}}</span>\r\n                                <span *ngIf=\"score.gross == score.par\" class=\"badge badge-info\">{{score.gross}}</span>\r\n                                <span *ngIf=\"score.gross > score.par\" class=\"badge badge-danger\">{{score.gross}}</span>\r\n                            </span>\r\n                            <span class=\"badge badge-success\">{{card.inGross}}</span>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <h6>Nett</h6>\r\n\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12\">\r\n                            <span *ngFor=\"let score of card.frontNine\">\r\n                                <span *ngIf=\"score.nett < score.par\" class=\"badge badge-success\">{{score.nett}}</span>\r\n                                <span *ngIf=\"score.nett == score.par\" class=\"badge badge-info\">{{score.nett}}</span>\r\n                                <span *ngIf=\"score.nett > score.par\" class=\"badge badge-danger\">{{score.nett}}</span>\r\n                            </span>\r\n                            <span class=\"badge badge-success\">{{card.outNett}}</span>\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12\">\r\n                            <span *ngFor=\"let score of card.backNine\">\r\n                                <span *ngIf=\"score.nett < score.par\" class=\"badge badge-success\">{{score.nett}}</span>\r\n                                <span *ngIf=\"score.nett == score.par\" class=\"badge badge-info\">{{score.nett}}</span>\r\n                                <span *ngIf=\"score.nett > score.par\" class=\"badge badge-danger\">{{score.nett}}</span>\r\n                            </span>\r\n                            <span class=\"badge badge-success\">{{card.inNett}}</span>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                <h6>Points</h6>\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        <span *ngFor=\"let score of card.frontNine\">\r\n                            <span *ngIf=\"score.nett < score.par\" class=\"badge badge-success\">{{score.points}}</span>\r\n                            <span *ngIf=\"score.nett == score.par\" class=\"badge badge-info\">{{score.points}}</span>\r\n                            <span *ngIf=\"score.nett > score.par\" class=\"badge badge-danger\">{{score.points}}</span>\r\n                        </span>\r\n                        <span class=\"badge badge-success\">{{card.outPoints}}</span>\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        <span *ngFor=\"let score of card.backNine\">\r\n                            <span *ngIf=\"score.nett < score.par\" class=\"badge badge-success\">{{score.points}}</span>\r\n                            <span *ngIf=\"score.nett == score.par\" class=\"badge badge-info\">{{score.points}}</span>\r\n                            <span *ngIf=\"score.nett > score.par\" class=\"badge badge-danger\">{{score.points}}</span>\r\n                        </span>\r\n                        <span class=\"badge badge-success\">{{card.inPoints}}</span>\r\n                    </div>\r\n                </div>-->\r\n            </div>\r\n                <hr />\r\n\r\n\r\n\r\n        </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"card\" *ngIf=\"showHandicapChanges\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <p class=\"navbar-brand\" href=\"#\">Handicaps {{event.date | date:short}}</p>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\">\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\" (click)=\"displayOOM()\"><i class=\"fas fa-trophy\"></i></a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\" (click)=\"displayCards()\"><i class=\"fas fa-id-card\"></i></a>\r\n\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n\r\n            <table class=\"table table-responsive d-sm-none\">\r\n                <thead>\r\n\r\n                    <tr>\r\n                        <th>Player</th>\r\n                        <th>Hcap</th>\r\n                        <th>Pts</th>\r\n                        <th>OOM</th>\r\n                        <th></th>\r\n                    </tr>\r\n                    <tr></tr>\r\n\r\n                </thead>\r\n                <tbody *ngFor=\"let entry of event.oomPoints\">\r\n                    <tr>\r\n                        <td>\r\n                            {{entry.card.player.fullName}}\r\n                        </td>\r\n                        <td>\r\n                            {{entry.card.player.currentHandicap}}\r\n                        </td>\r\n                        <td>\r\n                            {{entry.card.totalPoints}}\r\n                        </td>\r\n                        <th>\r\n                            {{entry.points}}\r\n                        </th>\r\n                        <th>\r\n                            <a class=\"btn btn-sm btn-info\" data-toggle=\"collapse\" href=\"#showDetail-{{entry.card.id}}\" role=\"button\" aria-expanded=\"false\" aria-controls=\"multiCollapseExample1\"><i class=\"fas fa-chevron-down\"></i></a>\r\n                        </th>\r\n\r\n                    </tr>\r\n                    <tr class=\"collapse\" id=\"showDetail-{{entry.card.id}}\">\r\n                        <td></td>\r\n                        <td><strong>In:</strong> {{entry.card.inPoints}}</td>\r\n                        <td><strong>Out:</strong> {{entry.card.outPoints}}</td>\r\n                        <td><strong>L6:</strong> {{entry.card.lastSixPoints}}</td>\r\n                        <td><strong>L3:</strong> {{entry.card.lastThreePoints}}</td>\r\n                    </tr>\r\n\r\n                </tbody>\r\n\r\n            </table>\r\n\r\n\r\n            <table class=\"table table-responsive d-none d-sm-block\">\r\n                <thead>\r\n\r\n                    <tr>\r\n                        <th>Player</th>\r\n                        <th>Hcap</th>\r\n                        <th>Pts</th>\r\n                        <th>In</th>\r\n                        <th>Out</th>\r\n                        <th>6</th>\r\n                        <th>3</th>\r\n                        <th>OOM</th>\r\n                    </tr>\r\n\r\n                </thead>\r\n                <tbody>\r\n                    <tr *ngFor=\"let entry of event.oomPoints\">\r\n                        <td>\r\n                            {{entry.card.player.fullName}}\r\n                        </td>\r\n                        <td>\r\n                            {{entry.card.player.currentHandicap}}\r\n                        </td>\r\n                        <td>\r\n                            {{entry.card.totalPoints}}\r\n                        </td>\r\n                        <td>\r\n                            {{entry.card.inPoints}}\r\n                        </td>\r\n                        <td>\r\n                            {{entry.card.outPoints}}\r\n                        </td>\r\n                        <td>\r\n                            {{entry.card.lastSixPoints}}\r\n                        </td>\r\n                        <td>\r\n                            {{entry.card.lastThreePoints}}\r\n                        </td>\r\n                        <th>\r\n                            {{entry.points}}\r\n                        </th>\r\n                    </tr>\r\n\r\n                </tbody>\r\n\r\n            </table>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n"

/***/ }),

/***/ "./ClientApp/app/event-results/event-results.component.ts":
/*!****************************************************************!*\
  !*** ./ClientApp/app/event-results/event-results.component.ts ***!
  \****************************************************************/
/*! exports provided: EventResultsComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EventResultsComponent", function() { return EventResultsComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../sweep.service */ "./ClientApp/app/sweep.service.ts");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");





var EventResultsComponent = /** @class */ (function () {
    function EventResultsComponent(route, service, location) {
        this.route = route;
        this.service = service;
        this.location = location;
        this.showOOM = true;
        this.showCards = false;
        this.showHandicapChanges = false;
    }
    EventResultsComponent.prototype.ngOnInit = function () {
        this.getEventResults();
    };
    EventResultsComponent.prototype.displayCards = function () {
        this.showOOM = false;
        this.showHandicapChanges = false;
        this.showCards = true;
    };
    EventResultsComponent.prototype.displayHandicaps = function () {
        this.showOOM = false;
        this.showCards = false;
        this.showHandicapChanges = true;
    };
    EventResultsComponent.prototype.displayOOM = function () {
        this.showHandicapChanges = false;
        this.showCards = false;
        this.showOOM = true;
    };
    EventResultsComponent.prototype.getEventResults = function () {
        var _this = this;
        var id = this.route.snapshot.paramMap.get('id');
        this.service.getEventResults(id.toString())
            .subscribe(function (event) { return _this.event = event; });
    };
    EventResultsComponent.prototype.goBack = function () {
        this.location.back();
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], EventResultsComponent.prototype, "event", void 0);
    EventResultsComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-event-results',
            template: __webpack_require__(/*! ./event-results.component.html */ "./ClientApp/app/event-results/event-results.component.html"),
            styles: [__webpack_require__(/*! ./event-results.component.css */ "./ClientApp/app/event-results/event-results.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"],
            _sweep_service__WEBPACK_IMPORTED_MODULE_3__["SweepService"],
            _angular_common__WEBPACK_IMPORTED_MODULE_4__["Location"]])
    ], EventResultsComponent);
    return EventResultsComponent;
}());



/***/ }),

/***/ "./ClientApp/app/events/events.component.css":
/*!***************************************************!*\
  !*** ./ClientApp/app/events/events.component.css ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL2V2ZW50cy9ldmVudHMuY29tcG9uZW50LmNzcyJ9 */"

/***/ }),

/***/ "./ClientApp/app/events/events.component.html":
/*!****************************************************!*\
  !*** ./ClientApp/app/events/events.component.html ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div *ngIf=\"events\">\r\n    <div class=\"card\" *ngFor=\"let event of events\">\r\n        <nav *ngIf=\"event.inFuture\" class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <a class=\"navbar-brand\" href=\"#\"><i class=\"fas fa-home\"></i></a>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\">\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\" routerLink=\"/event/detail/{{event.id}}\"><i class=\"fa fa-users\"></i> {{event.playerNames.length}}</a>\r\n\r\n                    </li>\r\n                    <li class=\"nav-item\" *ngIf=\"userHasJoined(event)\">\r\n\r\n                        <a *ngIf=\"!event.notDrawn\" routerLink=\"/event/play/{{event.id}}\" class=\"nav-link\" value=\"Play\">Play</a>\r\n\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <button *ngIf=\"!userHasJoined(event)\" (click)=\"enterEvent(event)\" class=\"btn btn-sm btn-success float-right\" value=\"Join\">Join</button>\r\n\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n\r\n        <nav *ngIf=\"!event.inFuture\" class=\"navbar navbar-expand navbar-dark bg-danger justify-content-end card-nav\">\r\n            <a class=\"navbar-brand\" href=\"#\"><i class=\"fas fa-home\"></i></a>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\">\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\" routerLink=\"/event/detail/{{event.id}}\"><i class=\"fa fa-users\"></i> {{event.playerNames.length}}</a>\r\n\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a routerLink=\"/event/results/{{event.id}}\" class=\"nav-link\" value=\"Play\">Results</a>\r\n\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div style=\"text-align:center\">\r\n                <h6>\r\n                    Gerry's Cowglen Winter Sweep\r\n                </h6>\r\n                <h5>{{event.date | date:short }}</h5>\r\n\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n"

/***/ }),

/***/ "./ClientApp/app/events/events.component.ts":
/*!**************************************************!*\
  !*** ./ClientApp/app/events/events.component.ts ***!
  \**************************************************/
/*! exports provided: EventsComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EventsComponent", function() { return EventsComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../sweep.service */ "./ClientApp/app/sweep.service.ts");



var EventsComponent = /** @class */ (function () {
    function EventsComponent(service) {
        this.service = service;
        this.events = [];
        this.currentDate = new Date().toLocaleString();
    }
    EventsComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.service.getEvents()
            .subscribe(function (data) {
            _this.service.events = data;
            _this.events = _this.service.events;
        }, function (error) { return console.error(error); });
    };
    EventsComponent.prototype.showEntries = function (event) {
        this.selectedEvent = event;
    };
    EventsComponent.prototype.enterEvent = function (event) {
        this.service.enterEvent(event);
        event.userHasJoined = true;
    };
    EventsComponent.prototype.isEventInFuture = function (event) {
        var eventDate = new Date(event.date).toLocaleString();
        return eventDate > this.currentDate;
    };
    EventsComponent.prototype.withDrawEntry = function (event) {
        this.service.withDrawEntry(event);
        event.userHasJoined = false;
    };
    EventsComponent.prototype.userHasJoined = function (event) {
        return event.userHasJoined;
    };
    EventsComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'events-list',
            template: __webpack_require__(/*! ./events.component.html */ "./ClientApp/app/events/events.component.html"),
            encapsulation: _angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewEncapsulation"].Emulated,
            styles: [__webpack_require__(/*! ./events.component.css */ "./ClientApp/app/events/events.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_sweep_service__WEBPACK_IMPORTED_MODULE_2__["SweepService"]])
    ], EventsComponent);
    return EventsComponent;
}());



/***/ }),

/***/ "./ClientApp/app/leaderboard/leaderboard.component.css":
/*!*************************************************************!*\
  !*** ./ClientApp/app/leaderboard/leaderboard.component.css ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL2xlYWRlcmJvYXJkL2xlYWRlcmJvYXJkLmNvbXBvbmVudC5jc3MifQ== */"

/***/ }),

/***/ "./ClientApp/app/leaderboard/leaderboard.component.html":
/*!**************************************************************!*\
  !*** ./ClientApp/app/leaderboard/leaderboard.component.html ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\" *ngIf=\"leaderboard\">\r\n    <button class=\"btn btn-danger\" (click)=\"goBack()\"><i class=\"fas fa-chevron-left\"></i></button>\r\n\r\n    <div class=\"card\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <a class=\"navbar-brand\" href=\"#\">Leaderboard</a>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\">\r\n                    <li class=\"nav-item\">\r\n\r\n                    </li>\r\n\r\n\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n\r\n            <table class=\"table table-responsive\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            Player\r\n                        </th>\r\n                        <th>\r\n                            Hole\r\n                        </th>\r\n                        <th>\r\n                            TotalPoints\r\n                        </th>\r\n                        <!--<th>\r\n\r\n                        </th>-->\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n                    <tr *ngFor=\"let item of leaderboard\">\r\n                        <td><strong>{{item.fullName}}</strong></td>\r\n                        <td>{{item.currentHole}}</td>\r\n                        <td>{{item.totalPoints}}</td>\r\n\r\n\r\n                    </tr>\r\n                </tbody>\r\n\r\n            </table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n    <button class=\"btn btn-danger\" (click)=\"goBack()\"><i class=\"fas fa-chevron-left\"></i></button>\r\n\r\n</div>\r\n\r\n"

/***/ }),

/***/ "./ClientApp/app/leaderboard/leaderboard.component.ts":
/*!************************************************************!*\
  !*** ./ClientApp/app/leaderboard/leaderboard.component.ts ***!
  \************************************************************/
/*! exports provided: LeaderboardComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LeaderboardComponent", function() { return LeaderboardComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../sweep.service */ "./ClientApp/app/sweep.service.ts");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");





var LeaderboardComponent = /** @class */ (function () {
    function LeaderboardComponent(route, service, location) {
        this.route = route;
        this.service = service;
        this.location = location;
    }
    LeaderboardComponent.prototype.ngOnInit = function () {
        this.getLeaderboard();
    };
    LeaderboardComponent.prototype.getLeaderboard = function () {
        var _this = this;
        var id = this.route.snapshot.paramMap.get('id');
        this.service.getLeaderboard(id.toString())
            .subscribe(function (leaderboard) { return _this.leaderboard = leaderboard; });
    };
    LeaderboardComponent.prototype.goBack = function () {
        this.location.back();
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], LeaderboardComponent.prototype, "leaderboard", void 0);
    LeaderboardComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-leaderboard',
            template: __webpack_require__(/*! ./leaderboard.component.html */ "./ClientApp/app/leaderboard/leaderboard.component.html"),
            styles: [__webpack_require__(/*! ./leaderboard.component.css */ "./ClientApp/app/leaderboard/leaderboard.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"],
            _sweep_service__WEBPACK_IMPORTED_MODULE_3__["SweepService"],
            _angular_common__WEBPACK_IMPORTED_MODULE_4__["Location"]])
    ], LeaderboardComponent);
    return LeaderboardComponent;
}());



/***/ }),

/***/ "./ClientApp/app/message.service.ts":
/*!******************************************!*\
  !*** ./ClientApp/app/message.service.ts ***!
  \******************************************/
/*! exports provided: MessageService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MessageService", function() { return MessageService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var MessageService = /** @class */ (function () {
    function MessageService() {
        this.messages = [];
    }
    MessageService.prototype.add = function (message) {
        this.messages.push(message);
    };
    MessageService.prototype.clear = function () {
        this.messages = [];
    };
    MessageService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
            providedIn: 'root'
        })
    ], MessageService);
    return MessageService;
}());



/***/ }),

/***/ "./ClientApp/app/messages/messages.component.css":
/*!*******************************************************!*\
  !*** ./ClientApp/app/messages/messages.component.css ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL21lc3NhZ2VzL21lc3NhZ2VzLmNvbXBvbmVudC5jc3MifQ== */"

/***/ }),

/***/ "./ClientApp/app/messages/messages.component.html":
/*!********************************************************!*\
  !*** ./ClientApp/app/messages/messages.component.html ***!
  \********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div *ngIf=\"messageService.messages.length\">\r\n\r\n    <h2>Messages</h2>\r\n    <button class=\"clear\"\r\n            (click)=\"messageService.clear()\">\r\n        clear\r\n    </button>\r\n    <div *ngFor='let message of messageService.messages'> {{message}} </div>\r\n\r\n</div>"

/***/ }),

/***/ "./ClientApp/app/messages/messages.component.ts":
/*!******************************************************!*\
  !*** ./ClientApp/app/messages/messages.component.ts ***!
  \******************************************************/
/*! exports provided: MessagesComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MessagesComponent", function() { return MessagesComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _message_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../message.service */ "./ClientApp/app/message.service.ts");



var MessagesComponent = /** @class */ (function () {
    function MessagesComponent(messageService) {
        this.messageService = messageService;
    }
    MessagesComponent.prototype.ngOnInit = function () {
    };
    MessagesComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-messages',
            template: __webpack_require__(/*! ./messages.component.html */ "./ClientApp/app/messages/messages.component.html"),
            styles: [__webpack_require__(/*! ./messages.component.css */ "./ClientApp/app/messages/messages.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_message_service__WEBPACK_IMPORTED_MODULE_2__["MessageService"]])
    ], MessagesComponent);
    return MessagesComponent;
}());



/***/ }),

/***/ "./ClientApp/app/play-event/play-event.component.css":
/*!***********************************************************!*\
  !*** ./ClientApp/app/play-event/play-event.component.css ***!
  \***********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL3BsYXktZXZlbnQvcGxheS1ldmVudC5jb21wb25lbnQuY3NzIn0= */"

/***/ }),

/***/ "./ClientApp/app/play-event/play-event.component.html":
/*!************************************************************!*\
  !*** ./ClientApp/app/play-event/play-event.component.html ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div *ngIf=\"event\">\r\n    <div class=\"card\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-success justify-content-end card-nav\">\r\n            <p class=\"navbar-brand\" href=\"#\">Play Event  {{event.event.date | date:short}}</p>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\">\r\n                    <li class=\"nav-item\">\r\n                        <a routerLink=\"/scorecard/{{event.playerCard.id}}\" class=\"nav-link\"><i class=\"fas fa-id-card x3\"></i></a>\r\n\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\" routerLink=\"/event/leaderboard/{{event.event.id}}\"><i class=\"fas fa-trophy\"></i> Leaderboard</a>\r\n                    </li>\r\n                    <!--<li class=\"nav-item\">\r\n        <a routerLink=\"/event/play/{{event.id}}\" *ngIf=\"userHasJoined(event)\" class=\"nav-link\" value=\"Play\">Play</a>\r\n\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <button *ngIf=\"!userHasJoined(event)\" (click)=\"enterEvent(event)\" class=\"btn btn-sm btn-success float-right\" value=\"Join\">Join</button>\r\n\r\n    </li>-->\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div>\r\n                <h6>Your Group</h6>\r\n            </div>\r\n            <ul *ngIf=\"event.groupPlayers\">\r\n                <li *ngFor=\"let player of event.groupPlayers\">{{player.fullName}} ({{player.currentHandicap}})</li>\r\n            </ul>\r\n\r\n\r\n\r\n\r\n        </div>\r\n\r\n        <div class=\"card-footer\">\r\n            <a routerLink=\"/scorecard/enter/{{event.markerCard.id}}\" class=\"btn-danger btn-sm float-right btn-card-footer\"><i class=\"fas fa-id-card\"></i>Mark {{event.markerCard.player.fullName }}'s card</a>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<button class=\"btn btn-danger\" (click)=\"goBack()\"><i class=\"fas fa-chevron-left\"></i></button>\r\n\r\n\r\n<!--<h5>{{event.event.date | date:short}}</h5>\r\n<h6>Your Group</h6>\r\n<ul *ngIf=\"event.groupPlayers\">\r\n    <li *ngFor=\"let player of event.groupPlayers\">{{player.fullName}} ({{player.currentHandicap}})</li>\r\n</ul>\r\n<p>Mark {{event.markerCard.player.fullName }}'s card</p>\r\n<a routerLink=\"/scorecard/enter/{{event.markerCard.id}}\" class=\"btn btn-success\">Mark Card</a>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<button class=\"btn btn-danger\" (click)=\"goBack()\">go back</button>-->"

/***/ }),

/***/ "./ClientApp/app/play-event/play-event.component.ts":
/*!**********************************************************!*\
  !*** ./ClientApp/app/play-event/play-event.component.ts ***!
  \**********************************************************/
/*! exports provided: PlayEventComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PlayEventComponent", function() { return PlayEventComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../sweep.service */ "./ClientApp/app/sweep.service.ts");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");





var PlayEventComponent = /** @class */ (function () {
    function PlayEventComponent(route, service, location) {
        this.route = route;
        this.service = service;
        this.location = location;
    }
    PlayEventComponent.prototype.ngOnInit = function () {
        this.getEntryToPlay();
    };
    PlayEventComponent.prototype.getEntryToPlay = function () {
        var _this = this;
        var id = this.route.snapshot.paramMap.get('id');
        this.service.playEvent(id.toString())
            .subscribe(function (event) { return _this.event = event; });
    };
    PlayEventComponent.prototype.goBack = function () {
        this.location.back();
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], PlayEventComponent.prototype, "event", void 0);
    PlayEventComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-play-event',
            template: __webpack_require__(/*! ./play-event.component.html */ "./ClientApp/app/play-event/play-event.component.html"),
            styles: [__webpack_require__(/*! ./play-event.component.css */ "./ClientApp/app/play-event/play-event.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"],
            _sweep_service__WEBPACK_IMPORTED_MODULE_3__["SweepService"],
            _angular_common__WEBPACK_IMPORTED_MODULE_4__["Location"]])
    ], PlayEventComponent);
    return PlayEventComponent;
}());



/***/ }),

/***/ "./ClientApp/app/player-detail/player-detail.component.css":
/*!*****************************************************************!*\
  !*** ./ClientApp/app/player-detail/player-detail.component.css ***!
  \*****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL3BsYXllci1kZXRhaWwvcGxheWVyLWRldGFpbC5jb21wb25lbnQuY3NzIn0= */"

/***/ }),

/***/ "./ClientApp/app/player-detail/player-detail.component.html":
/*!******************************************************************!*\
  !*** ./ClientApp/app/player-detail/player-detail.component.html ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\n  player-detail works!\n</p>\n"

/***/ }),

/***/ "./ClientApp/app/player-detail/player-detail.component.ts":
/*!****************************************************************!*\
  !*** ./ClientApp/app/player-detail/player-detail.component.ts ***!
  \****************************************************************/
/*! exports provided: PlayerDetailComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PlayerDetailComponent", function() { return PlayerDetailComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../sweep.service */ "./ClientApp/app/sweep.service.ts");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");





var PlayerDetailComponent = /** @class */ (function () {
    function PlayerDetailComponent(route, service, location) {
        this.route = route;
        this.service = service;
        this.location = location;
    }
    PlayerDetailComponent.prototype.ngOnInit = function () {
        this.getPlayer();
    };
    PlayerDetailComponent.prototype.getPlayer = function () {
        var _this = this;
        var id = this.route.snapshot.paramMap.get('id');
        this.service.getPlayer(id.toString())
            .subscribe(function (player) { return _this.player = player; });
    };
    PlayerDetailComponent.prototype.goBack = function () {
        this.location.back();
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], PlayerDetailComponent.prototype, "player", void 0);
    PlayerDetailComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-player-detail',
            template: __webpack_require__(/*! ./player-detail.component.html */ "./ClientApp/app/player-detail/player-detail.component.html"),
            styles: [__webpack_require__(/*! ./player-detail.component.css */ "./ClientApp/app/player-detail/player-detail.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"],
            _sweep_service__WEBPACK_IMPORTED_MODULE_3__["SweepService"],
            _angular_common__WEBPACK_IMPORTED_MODULE_4__["Location"]])
    ], PlayerDetailComponent);
    return PlayerDetailComponent;
}());



/***/ }),

/***/ "./ClientApp/app/score-card/score-card.component.css":
/*!***********************************************************!*\
  !*** ./ClientApp/app/score-card/score-card.component.css ***!
  \***********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL3Njb3JlLWNhcmQvc2NvcmUtY2FyZC5jb21wb25lbnQuY3NzIn0= */"

/***/ }),

/***/ "./ClientApp/app/score-card/score-card.component.html":
/*!************************************************************!*\
  !*** ./ClientApp/app/score-card/score-card.component.html ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\" *ngIf=\"scoreCard\">\r\n    <button class=\"btn btn-danger\" (click)=\"goBack()\"><i class=\"fas fa-chevron-left\"></i></button>\r\n\r\n    <div class=\"card\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <a class=\"navbar-brand\" href=\"#\">{{scoreCard.player.fullName}} ({{scoreCard.player.currentHandicap}})</a>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\">\r\n                    <li class=\"nav-item\">\r\n                        <!--<a class=\"nav-link\" routerLink=\"/event/detail/{{event.id}}\"><i class=\"fa fa-users\"></i> {{event.playerNames.length}}</a>-->\r\n\r\n\r\n                    </li>\r\n\r\n                    <!--<li class=\"nav-item\">\r\n                        <a routerLink=\"/event/play/{{event.id}}\" *ngIf=\"userHasJoined(event)\" class=\"nav-link\" value=\"Play\">Play</a>\r\n\r\n                    </li>-->\r\n                    <li class=\"nav-item\">\r\n                        <p class=\"nav-link\">Handicap: {{scoreCard.player.currentHandicap}}</p>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <p>Course: {{scoreCard.courseName}}</p>\r\n\r\n\r\n            <table class=\"table table-responsive d-sm-none\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            Hole\r\n                        </th>\r\n                        <th>\r\n                            Gross\r\n                        </th>\r\n                        <th>\r\n                            Points\r\n                        </th>\r\n                        <!--<th>\r\n\r\n                        </th>-->\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n                    <tr *ngFor=\"let score of scoreCard.scores\">\r\n                        <td><strong>{{score.holeNumber}}</strong></td>\r\n                        <td *ngIf=\"score.gross < score.par\"><p class=\"badge badge-success\">{{score.gross}}</p></td>\r\n                        <td *ngIf=\"score.gross == score.par\"><p class=\"badge badge-info\">{{score.gross}}</p></td>\r\n                        <td *ngIf=\"score.gross > score.par\"><p class=\"badge badge-danger\">{{score.gross}}</p></td>\r\n\r\n                        <td *ngIf=\"score.nett < score.par\"><p class=\"badge badge-success\">{{score.points}}</p></td>\r\n                        <td *ngIf=\"score.nett == score.par\"><p class=\"badge badge-info\">{{score.points}}</p></td>\r\n                        <td *ngIf=\"score.nett > score.par\"><p class=\"badge badge-danger\">{{score.points}}</p></td>\r\n\r\n                        <!--<td>\r\n                            <a href=\"\" class=\"btn btn-sm btn-success mb-10\" (click)=\"getSelectedScore(score)\"\r\n                               data-toggle=\"modal\" data-target=\"#enterScoreModal\">{{score.holeNumber}}<i class=\"fas fa-plus\"></i></a>\r\n                        </td>-->\r\n\r\n                    </tr>\r\n                </tbody>\r\n\r\n            </table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n            <table class=\"table table-responsive d-none d-sm-block\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            Hole\r\n                        </th>\r\n                        <th>\r\n                            Par\r\n                        </th>\r\n                        <th>\r\n                            SI\r\n                        </th>\r\n                        <th>\r\n                            Gross\r\n                        </th>\r\n                        <th>\r\n                            Nett\r\n                        </th>\r\n                        <th>\r\n                            Points\r\n                        </th>\r\n                        <!--<th>\r\n\r\n                        </th>-->\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n                    <tr *ngFor=\"let score of scoreCard.scores\">\r\n                        <td><strong>{{score.holeNumber}}</strong></td>\r\n                        <td>{{score.par}}</td>\r\n                        <td>{{score.index}}</td>\r\n                        <td *ngIf=\"score.gross < score.par\"><p class=\"badge badge-success\">{{score.gross}}</p></td>\r\n                        <td *ngIf=\"score.gross == score.par\"><p class=\"badge badge-info\">{{score.gross}}</p></td>\r\n                        <td *ngIf=\"score.gross > score.par\"><p class=\"badge badge-danger\">{{score.gross}}</p></td>\r\n\r\n                        <td *ngIf=\"score.nett < score.par\"><p class=\"badge badge-success\">{{score.nett}}</p></td>\r\n                        <td *ngIf=\"score.nett == score.par\"><p class=\"badge badge-info\">{{score.nett}}</p></td>\r\n                        <td *ngIf=\"score.nett > score.par\"><p class=\"badge badge-danger\">{{score.nett}}</p></td>\r\n\r\n                        <td *ngIf=\"score.nett < score.par\"><p class=\"badge badge-success\">{{score.points}}</p></td>\r\n                        <td *ngIf=\"score.nett == score.par\"><p class=\"badge badge-info\">{{score.points}}</p></td>\r\n                        <td *ngIf=\"score.nett > score.par\"><p class=\"badge badge-danger\">{{score.points}}</p></td>\r\n\r\n                        <!--<td>\r\n                            <a href=\"\" class=\"btn btn-sm btn-success mb-10\" (click)=\"getSelectedScore(score)\"\r\n                               data-toggle=\"modal\" data-target=\"#enterScoreModal\">{{score.holeNumber}}<i class=\"fas fa-plus\"></i></a>\r\n                        </td>-->\r\n\r\n                    </tr>\r\n                </tbody>\r\n\r\n            </table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n    <button class=\"btn btn-danger\" (click)=\"goBack()\"><i class=\"fas fa-chevron-left\"></i></button>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n<!--<div *ngIf=\"scoreCard\">\r\n    <p>{{scoreCard.player.fullName}}'s Card</p>\r\n    <p>Current Playing Handicap {{scoreCard.player.currentHandicap}}</p>\r\n    <p>Course: {{scoreCard.courseName}}</p>\r\n    <div class=\"row\">\r\n        <div class=\"col-2\">Hole</div>\r\n        <div class=\"col-2\">Par</div>\r\n        <div class=\"col-2\">SI</div>\r\n        <div class=\"col-2\">Gross</div>\r\n        <div class=\"col-2\">Nett</div>\r\n        <div class=\"col-2\">Points</div>\r\n    </div>\r\n    <div class=\"row\" *ngFor=\"let hole of scoreCard.scores\">\r\n        <div class=\"col-2\">{{hole.holeNumber}}</div>\r\n        <div class=\"col-2\">{{hole.par}}</div>\r\n        <div class=\"col-2\">{{hole.index}}</div>\r\n        <div class=\"col-2\">{{hole.gross}}</div>\r\n        <div class=\"col-2\">{{hole.nett}}</div>\r\n        <div class=\"col-2\">{{hole.points}}</div>\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n<br />\r\n\r\n<button class=\"btn btn-danger\" (click)=\"goBack()\">go back</button>-->\r\n"

/***/ }),

/***/ "./ClientApp/app/score-card/score-card.component.ts":
/*!**********************************************************!*\
  !*** ./ClientApp/app/score-card/score-card.component.ts ***!
  \**********************************************************/
/*! exports provided: ScoreCardComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ScoreCardComponent", function() { return ScoreCardComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../sweep.service */ "./ClientApp/app/sweep.service.ts");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");





var ScoreCardComponent = /** @class */ (function () {
    function ScoreCardComponent(route, service, location) {
        this.route = route;
        this.service = service;
        this.location = location;
    }
    ScoreCardComponent.prototype.ngOnInit = function () {
        this.getScoreCard();
    };
    ScoreCardComponent.prototype.getScoreCard = function () {
        var _this = this;
        var id = this.route.snapshot.paramMap.get('id');
        this.service.getScoreCard(id.toString())
            .subscribe(function (card) { return _this.scoreCard = card; });
    };
    ScoreCardComponent.prototype.goBack = function () {
        this.location.back();
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], ScoreCardComponent.prototype, "scoreCard", void 0);
    ScoreCardComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-score-card',
            template: __webpack_require__(/*! ./score-card.component.html */ "./ClientApp/app/score-card/score-card.component.html"),
            styles: [__webpack_require__(/*! ./score-card.component.css */ "./ClientApp/app/score-card/score-card.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"],
            _sweep_service__WEBPACK_IMPORTED_MODULE_3__["SweepService"],
            _angular_common__WEBPACK_IMPORTED_MODULE_4__["Location"]])
    ], ScoreCardComponent);
    return ScoreCardComponent;
}());



/***/ }),

/***/ "./ClientApp/app/sweep-detail/sweep-detail.component.css":
/*!***************************************************************!*\
  !*** ./ClientApp/app/sweep-detail/sweep-detail.component.css ***!
  \***************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL3N3ZWVwLWRldGFpbC9zd2VlcC1kZXRhaWwuY29tcG9uZW50LmNzcyJ9 */"

/***/ }),

/***/ "./ClientApp/app/sweep-detail/sweep-detail.component.html":
/*!****************************************************************!*\
  !*** ./ClientApp/app/sweep-detail/sweep-detail.component.html ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div *ngIf=\"sweep\">\r\n\r\n\r\n    <nav class=\"navbar sticky-top navbar-expand navbar-dark bg-danger justify-content-end card-nav\">\r\n        <div class=\"navbar-collapse collapse\">\r\n            <ul class=\"navbar-nav ml-auto\">\r\n\r\n                <li class=\"nav-item\">\r\n                    <a *ngIf=\"isUserOwner(sweep)\" class=\"nav-link\" data-toggle=\"modal\" data-target=\"#createEventModal\">\r\n                        <i class=\"fas fa-plus\"></i> Event\r\n                    </a>\r\n\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" (click)=\"displayOOM()\"><i class=\"fas fa-list\"></i> OOM</a>\r\n                </li>\r\n\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" (click)=\"displayMembers()\"><i class=\"fas fa-list\"></i> Members</a>\r\n                </li>\r\n\r\n                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\" (click)=\"displayEvents()\"><i class=\"fas fa-list\"></i> Events</a>\r\n                </li>\r\n\r\n\r\n            </ul>\r\n        </div>\r\n    </nav>\r\n\r\n\r\n\r\n\r\n    <div *ngIf=\"showOOM\">\r\n        <div class=\"card\">\r\n            <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n                <p class=\"navbar-brand\">{{sweep.name}} Order of Merit</p>\r\n\r\n                <div class=\"navbar-collapse collapse\">\r\n                    <!--<ul class=\"navbar-nav ml-auto\">\r\n                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link\" routerLink=\"/event/detail/{{event.id}}\"><i class=\"fa fa-users\"></i> {{event.playerNames.length}}</a>\r\n\r\n                        </li>\r\n                        <li class=\"nav-item\" *ngIf=\"userHasJoined(event)\">\r\n\r\n                            <a *ngIf=\"!event.notDrawn\" routerLink=\"/event/play/{{event.id}}\" class=\"nav-link\" value=\"Play\">Play</a>\r\n\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            <button *ngIf=\"!userHasJoined(event)\" (click)=\"enterEvent(event)\" class=\"btn btn-sm btn-success float-right\" value=\"Join\">Join</button>\r\n\r\n                        </li>\r\n\r\n\r\n                    </ul>-->\r\n                </div>\r\n            </nav>\r\n\r\n\r\n            <div class=\"card-header\">\r\n\r\n            </div>\r\n            <div class=\"card-body\">\r\n\r\n\r\n\r\n                <table class=\"table\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>Position</th>\r\n                            <th>Player</th>\r\n                            <th>Played</th>\r\n                            <th>Points</th>\r\n                    </thead>\r\n                    <tbody *ngFor=\"let player of sweep.oom\">\r\n                        <tr>\r\n                            <th>{{player.position}}</th>\r\n                            <th><a data-toggle=\"collapse\" class=\"text-black\" href=\"#showResults-{{player.id}}\" role=\"button\">{{player.fullName}}</a></th>\r\n                            <th>{{player.played}}</th>\r\n                            <th>{{player.totalPoints}}</th>\r\n\r\n                        </tr>\r\n                        <tr *ngFor=\"let result of player.events\" class=\"collapse\" id=\"showResults-{{player.id}}\">\r\n                            <td>{{result.position}}</td>\r\n                            <td>{{result.event.date | date:short }}</td>\r\n                            <td></td>\r\n                            <td>{{result.points}}</td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div *ngIf=\"showMembers\">\r\n        <div class=\"card\" *ngIf=\"isUserOwner(sweep) && sweep.requests.length > 0\">\r\n            <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n                <p class=\"navbar-brand\">{{sweep.name}} Requests</p>\r\n\r\n                <div class=\"navbar-collapse collapse\">\r\n                </div>\r\n            </nav>\r\n\r\n\r\n            <div class=\"card-header\">\r\n\r\n            </div>\r\n            <div class=\"card-body\">\r\n\r\n                <table class=\"table\" *ngIf=\"isUserOwner(sweep)\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>Player</th>\r\n                            <th>Handicap</th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n                        <tr *ngFor=\"let player of sweep.requests\">\r\n                            <td>{{player.fullName}}</td>\r\n                            <td>{{player.currentHandicap}}</td>\r\n                            <td><a class=\"btn btn-sm btn-success\" (click)=\"approveRequest(player)\">Approve</a></td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"card\">\r\n            <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n                <p class=\"navbar-brand\">{{sweep.name}} Members</p>\r\n\r\n                <div class=\"navbar-collapse collapse\">\r\n                </div>\r\n            </nav>\r\n\r\n\r\n            <div class=\"card-header\">\r\n\r\n            </div>\r\n            <div class=\"card-body\">\r\n\r\n\r\n                <table class=\"table\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>Name</th>\r\n                            <th>Playing</th>\r\n                            <th>Exact</th>\r\n                            <th *ngIf=\"isUserOwner(sweep)\"></th>\r\n                    </thead>\r\n                    <tbody>\r\n                        <tr *ngFor=\"let player of sweep.members\">\r\n                            <td>{{player.fullName}}</td>\r\n                            <td>{{player.currentHandicap}}</td>\r\n                            <th>{{player.currentExactHandicap}}</th>\r\n                            <th *ngIf=\"isUserOwner(sweep)\"><button class=\"btn btn-sm btn-info\" (click)=\"getSelectedPlayer(player)\" data-toggle=\"modal\" data-target=\"#updateHandicapModal\"><i class=\"fas fa-pen\"></i> Hcap</button></th>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div *ngIf=\"showEvents\">\r\n        <div class=\"card\" *ngFor=\"let event of sweep.events\">\r\n            <nav *ngIf=\"!event.complete\" class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n                <!--<a class=\"nav-item btn btn-danger\" routerLink=\"/event/detail/{{event.id}}\" *ngIf=\"isUserOwner(sweep)\">\r\n                    Manage\r\n                </a>-->\r\n                <div class=\"navbar-collapse collapse\">\r\n                    <ul class=\"navbar-nav ml-auto\">\r\n                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link\" routerLink=\"/event/detail/{{event.id}}\"><i class=\"fa fa-users\"></i> {{event.playerNames.length}}</a>\r\n\r\n                        </li>\r\n                        <li class=\"nav-item\" *ngIf=\"userHasJoined(event)\">\r\n\r\n                            <a *ngIf=\"event.drawn\" routerLink=\"/event/play/{{event.id}}\" class=\"nav-link\" value=\"Play\">Play</a>\r\n                            <p class=\"nav-link\" *ngIf=\"!event.drawn\">\r\n                                <span class=\"badge badge-danger\">\r\n                                    Pending Draw\r\n                                </span>\r\n                            </p>\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            <button *ngIf=\"!userHasJoined(event)\" (click)=\"enterEvent(event)\" class=\"btn btn-sm btn-success float-right\" value=\"Join\">Join</button>\r\n\r\n                        </li>\r\n\r\n\r\n                    </ul>\r\n                </div>\r\n            </nav>\r\n\r\n\r\n            <nav *ngIf=\"event.complete\" class=\"navbar navbar-expand navbar-dark bg-danger justify-content-end card-nav\">\r\n                <a class=\"navbar-brand\" href=\"#\"><i class=\"fas fa-home\"></i></a>\r\n                <div class=\"navbar-collapse collapse\">\r\n                    <ul class=\"navbar-nav ml-auto\">\r\n                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link\" routerLink=\"/event/detail/{{event.id}}\"><i class=\"fa fa-users\"></i> {{event.playerNames.length}}</a>\r\n\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            <a routerLink=\"/event/results/{{event.id}}\" class=\"nav-link\" value=\"Play\">Results</a>\r\n\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </nav>\r\n\r\n\r\n            <div class=\"card-header\">\r\n\r\n            </div>\r\n            <div class=\"card-body\">\r\n\r\n                <div style=\"text-align:center\">\r\n                    <h6>\r\n                        {{sweep.name}}\r\n                    </h6>\r\n                    <h5>{{event.date | date:short }}</h5>\r\n                    <h6>Course: {{event.course.name}}</h6>\r\n                    <p *ngIf=\"event.winterHandicaps\">Winter Handicaps: {{event.winterHandicaps}}</p>\r\n\r\n                </div>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n    <div *ngIf=\"selectedPlayer\" class=\"modal fade modal-mini\" id=\"updateHandicapModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myModalLabel\" aria-hidden=\"true\">\r\n        <div class=\"modal-dialog\">\r\n            <div class=\"modal-content\">\r\n                <div class=\"modal-header justify-content-center\">\r\n                    Update {{selectedPlayer.fullName}}'s Handicap\r\n                </div>\r\n                <div class=\"modal-body\">\r\n                    <div>\r\n                        <form [formGroup]=\"updateHandicapForm\" (ngSubmit)=\"updatePlayerHandicap(selectedPlayer)\" novalidate>\r\n\r\n                            <div class=\"form-group\">\r\n                                <div class=\"input-group wd-sm-400 wd-lg-600\">\r\n                                    <input type=\"number\" formControlName=\"handicap\" class=\"form-control\" placeholder=\"Enter New Handicap\" autofocus>\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                <div class=\"justify-content-center\">\r\n                                    <button type=\"submit\" class=\"btn btn-success\">Update Handicap</button>\r\n                                </div>\r\n                            </div>\r\n                        </form>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n                    <!--<button type=\"button\" class=\"btn btn-link btn-neutral\">Back</button>\r\n                    <button type=\"button\" class=\"btn btn-link btn-neutral\" data-dismiss=\"modal\">Close</button>-->\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div *ngIf=\"isUserOwner(sweep)\" class=\"modal fade modal-mini\" id=\"createEventModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myModalLabel\" aria-hidden=\"true\">\r\n        <div class=\"modal-dialog\">\r\n            <div class=\"modal-content\">\r\n                <div class=\"modal-header justify-content-center\">\r\n                    Create Event\r\n                </div>\r\n                <div class=\"modal-body\">\r\n                    <div>\r\n                        <form [formGroup]=\"createEventForm\" (ngSubmit)=\"createEvent()\" novalidate>\r\n\r\n                            <div class=\"form-group\">\r\n                                <div class=\"input-group wd-sm-400 wd-lg-600\">\r\n                                    <input type=\"date\" formControlName=\"date\" class=\"form-control\" value=\"MM/DD/YY\" placeholder=\"Enter New Handicap\" autofocus>\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n\r\n                            <div class=\"form-group\">\r\n                                <div class=\"input-group wd-sm-400 wd-lg-600\">\r\n                                    <select formControlName=\"courseId\" class=\"form-control\">\r\n                                        <option *ngFor=\"let course of sweep.courses\" value=\"{{course.id}}\">\r\n                                            {{course.name}}\r\n                                        </option>\r\n                                    </select>\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n                            <div class=\"form-group\">\r\n                                <div class=\"input-group wd-sm-400 wd-lg-600\">\r\n                                    <label class=\"form-control-label\">Winter Handicaps</label>\r\n                                    <input type=\"checkbox\" formControlName=\"winterHandicaps\" class=\"form-control\" >\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n\r\n                            <div class=\"form-group\">\r\n                                <div class=\"justify-content-center\">\r\n                                    <button type=\"submit\" class=\"btn btn-success\">Create Event</button>\r\n                                </div>\r\n                            </div>\r\n                        </form>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n                    <!--<button type=\"button\" class=\"btn btn-link btn-neutral\">Back</button>\r\n                    <button type=\"button\" class=\"btn btn-link btn-neutral\" data-dismiss=\"modal\">Close</button>-->\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n\r\n"

/***/ }),

/***/ "./ClientApp/app/sweep-detail/sweep-detail.component.ts":
/*!**************************************************************!*\
  !*** ./ClientApp/app/sweep-detail/sweep-detail.component.ts ***!
  \**************************************************************/
/*! exports provided: SweepDetailComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SweepDetailComponent", function() { return SweepDetailComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../sweep.service */ "./ClientApp/app/sweep.service.ts");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _auth_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../auth.service */ "./ClientApp/app/auth.service.ts");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");







var SweepDetailComponent = /** @class */ (function () {
    function SweepDetailComponent(service, route, location, userService, datePipe) {
        this.service = service;
        this.route = route;
        this.location = location;
        this.userService = userService;
        this.datePipe = datePipe;
        this.showOOM = false;
        this.showEvents = true;
        this.showMembers = false;
        this.sweepApproval = null;
        this.updateHandicap = null;
        this.updateHandicapForm = new _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormGroup"]({
            handicap: new _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormControl"](''),
            playerId: new _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormControl"](''),
            sweepId: new _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormControl"]('')
        });
        this.createEventForm = new _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormGroup"]({
            courseId: new _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormControl"](''),
            date: new _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormControl"](''),
            winterHandicaps: new _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormControl"](false),
            sweepId: new _angular_forms__WEBPACK_IMPORTED_MODULE_6__["FormControl"]('')
        });
    }
    SweepDetailComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.userService.getUserAuthDetails().subscribe(function (data) {
            _this.userService.userAuth = data;
            _this.userAuth = _this.userService.userAuth;
        });
        this.getSweep();
    };
    SweepDetailComponent.prototype.isUserOwner = function (sweep) {
        return this.userService.userAuth.sweepIds.some(function (s) { return s == sweep.id; });
    };
    SweepDetailComponent.prototype.getSweep = function () {
        var _this = this;
        var id = this.route.snapshot.paramMap.get('id');
        this.service.getSweep(id.toString())
            .subscribe(function (sweep) { return _this.sweep = sweep; });
    };
    SweepDetailComponent.prototype.displayOOM = function () {
        this.showOOM = true;
        this.showMembers = false;
        this.showEvents = false;
    };
    SweepDetailComponent.prototype.displayMembers = function () {
        this.showOOM = false;
        this.showMembers = true;
        this.showEvents = false;
    };
    SweepDetailComponent.prototype.displayEvents = function () {
        this.showOOM = false;
        this.showMembers = false;
        this.showEvents = true;
    };
    SweepDetailComponent.prototype.getSelectedPlayer = function (player) {
        this.selectedPlayer = player;
    };
    SweepDetailComponent.prototype.approveRequest = function (player) {
        var _this = this;
        alert("button works");
        this.sweepApproval = {
            playerId: player.id,
            sweepId: this.sweep.id
        };
        alert("This SweepApproval: " + this.sweepApproval);
        this.service.approveSweepRequest(this.sweepApproval)
            .subscribe(function (data) {
            _this.sweepApproval = null;
            _this.sweep.members.unshift(data);
            var playerToRemove = _this.sweep.requests.indexOf(player);
            if (playerToRemove !== -1) {
                _this.sweep.requests.splice(playerToRemove, 1);
            }
        });
    };
    SweepDetailComponent.prototype.updatePlayerHandicap = function (player) {
        var _this = this;
        this.updateHandicapForm.patchValue({
            playerId: player.id,
            sweepId: this.sweep.id
        });
        this.service.updateHandicap(this.updateHandicapForm.value).subscribe(function (data) {
            _this.selectedPlayer.currentExactHandicap = data.currentExactHandicap;
            _this.selectedPlayer.currentHandicap = data.currentHandicap;
            _this.updateHandicapForm.reset();
            _this.selectedPlayer = null;
            $('#updateHandicapModal').modal('toggle');
        });
    };
    SweepDetailComponent.prototype.enterEvent = function (event) {
        this.service.enterEvent(event);
        event.userHasJoined = true;
    };
    SweepDetailComponent.prototype.withDrawEntry = function (event) {
        this.service.withDrawEntry(event);
        event.userHasJoined = false;
    };
    SweepDetailComponent.prototype.userHasJoined = function (event) {
        return event.userHasJoined;
    };
    SweepDetailComponent.prototype.goBack = function () {
        this.location.back();
    };
    SweepDetailComponent.prototype.createEvent = function () {
        var _this = this;
        var eventForm = this.createEventForm.value;
        //eventForm.date = this.datePipe.transform(eventForm.date, 'yyyy-MM-dd');
        eventForm.date = new Date(eventForm.date).toISOString();
        console.log(eventForm);
        this.createEventForm.patchValue({
            sweepId: this.sweep.id,
            date: eventForm.date
        });
        this.service.createEvent(this.createEventForm.value).subscribe(function (data) {
            //this.service.createEvent(eventForm).subscribe(data => {
            _this.sweep.events.unshift(data);
            _this.createEventForm.reset();
            $('#createEventModal').modal('toggle');
        });
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], SweepDetailComponent.prototype, "sweep", void 0);
    SweepDetailComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-sweep-detail',
            template: __webpack_require__(/*! ./sweep-detail.component.html */ "./ClientApp/app/sweep-detail/sweep-detail.component.html"),
            styles: [__webpack_require__(/*! ./sweep-detail.component.css */ "./ClientApp/app/sweep-detail/sweep-detail.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_sweep_service__WEBPACK_IMPORTED_MODULE_3__["SweepService"],
            _angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"],
            _angular_common__WEBPACK_IMPORTED_MODULE_4__["Location"],
            _auth_service__WEBPACK_IMPORTED_MODULE_5__["AuthService"],
            _angular_common__WEBPACK_IMPORTED_MODULE_4__["DatePipe"]])
    ], SweepDetailComponent);
    return SweepDetailComponent;
}());



/***/ }),

/***/ "./ClientApp/app/sweep.service.ts":
/*!****************************************!*\
  !*** ./ClientApp/app/sweep.service.ts ***!
  \****************************************/
/*! exports provided: SweepService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SweepService", function() { return SweepService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");
/* harmony import */ var _message_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./message.service */ "./ClientApp/app/message.service.ts");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm5/operators/index.js");






var httpOptions = {
    headers: new _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpHeaders"]({
        'Content-Type': 'application/json'
    }),
};
var httpOptionsMultiPart = {
    headers: new _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpHeaders"]({
        'Content-Disposition': 'multipart/form-data'
    }),
};
var SweepService = /** @class */ (function () {
    function SweepService(http, messageService) {
        this.http = http;
        this.messageService = messageService;
        this.sweeps = [];
        this.events = [];
        this.sweepsUrl = "/api/sweeps/";
        this.sweepsAdminUrl = "api/sweeps/admin";
        this.eventsUrl = "api/events/";
        this.enterEventUrl = "api/entries/enter";
        this.withDrawEntryUrl = "api/entries/withdraw";
        this.playEventUrl = "api/entries/play/";
        this.scoreCardsUrl = "api/scorecards/";
        this.scoresUrl = "api/scores/";
        this.createScoreCardUrl = "api/scores/createCard";
        this.leaderBoardUrl = "api/leaderboard/";
        this.eventResultsUrl = "api/events/results/";
        this.playersUrl = "api/players/";
        this.virtualMatchesUrl = "api/virtualmatchplay/";
        this.createEventDrawUrl = "api/events/draw/";
        this.closeEventUrl = "api/events/close/";
        this.playerEntryUrl = "api/entries/player/enter/";
        this.updateCardUrl = "api/scorecards/update/";
        this.updateHandicapUrl = "api/handicaps/";
        this.playerRemoveUrl = "api/entries/delete/";
    }
    SweepService.prototype.getSweeps = function () {
        this.messageService.add("Getting Sweeps");
        return this.http.get(this.sweepsUrl, httpOptions);
    };
    SweepService.prototype.getAdminSweeps = function () {
        var _this = this;
        return this.http.get(this.sweepsAdminUrl, httpOptions)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log('fetched Admin Sweeps'); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError('getAdminSweeps')));
    };
    SweepService.prototype.getEvents = function () {
        var _this = this;
        //this.messageService.add("Getting Events")
        return this.http.get(this.eventsUrl, httpOptions)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log('fetched events'); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError('getEvents', [])));
    };
    SweepService.prototype.getLeaderboard = function (id) {
        var _this = this;
        return this.http.get(this.leaderBoardUrl + id, httpOptions)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log('fetched leaderboard'); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError('getLeaderBoard')));
    };
    SweepService.prototype.handleError = function (operation, result) {
        var _this = this;
        if (operation === void 0) { operation = 'operation'; }
        return function (error) {
            console.error(error);
            _this.log(operation + " failed: " + error.message);
            return Object(rxjs__WEBPACK_IMPORTED_MODULE_3__["of"])(result);
        };
    };
    SweepService.prototype.getEvent = function (id) {
        var _this = this;
        return this.http.get(this.eventsUrl + id, httpOptions).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("fetched event id=" + id); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError("getEvent id=" + id)));
    };
    SweepService.prototype.getMatchPlayResults = function (id) {
        var _this = this;
        return this.http.get(this.virtualMatchesUrl + id, httpOptions).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("fetched match play results for event id=" + id); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError("getMatchPlayResults id=" + id)));
    };
    SweepService.prototype.getPlayer = function (id) {
        var _this = this;
        return this.http.get(this.playersUrl + id, httpOptions).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("fetched player id=" + id); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError("getPlayer id=" + id)));
    };
    SweepService.prototype.getUserPlayerId = function () {
        var _this = this;
        return this.http.get("api/player/getPlayerId", httpOptions)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("fetched playerid"); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError('getPlayerId')));
    };
    SweepService.prototype.getUserPlayer = function () {
        var _this = this;
        return this.http.get("api/player/getUserPlayer", httpOptions)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("fetched userPlayer"); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError('getUserPlayer')));
    };
    SweepService.prototype.getEventResults = function (id) {
        var _this = this;
        return this.http.get(this.eventResultsUrl + id, httpOptions).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("fetched event results for eventId=" + id); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError("getEventResults id=" + id)));
    };
    SweepService.prototype.getSweep = function (id) {
        var _this = this;
        return this.http.get(this.sweepsUrl + id, httpOptions).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("fetched sweep id=" + id); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError("getSweep id=" + id)));
    };
    SweepService.prototype.getScoreCard = function (id) {
        var _this = this;
        return this.http.get(this.scoreCardsUrl + id, httpOptions).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("fetched scorecard id=" + id); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError("getScoreCard id=" + id)));
    };
    SweepService.prototype.updateScore = function (score) {
        var _this = this;
        return this.http.post(this.scoresUrl, score, httpOptions)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("updated score id=" + score.id); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError('updateScore')));
    };
    SweepService.prototype.updateCard = function (card) {
        var _this = this;
        return this.http.post(this.updateCardUrl, card, httpOptions).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("updated scorecard id = " + card.id); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError("updateScoreCard id=" + card.id)));
    };
    SweepService.prototype.addPlayerToEvent = function (player) {
        var _this = this;
        return this.http.post(this.playerEntryUrl, player, httpOptions)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("created player entry for playerId=" + player.playerId + " for eventId " + player.eventId); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError('added Player entry')));
    };
    SweepService.prototype.removePlayerFromEvent = function (player) {
        var _this = this;
        return this.http.post(this.playerRemoveUrl, player, httpOptions)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("removed player entry for playerId=" + player.playerId + " for eventId " + player.eventId); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError('Player entry removed')));
    };
    SweepService.prototype.createScoreCard = function (createScoreCard) {
        var _this = this;
        return this.http.post(this.createScoreCardUrl, createScoreCard, httpOptions)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("updated score card id=" + createScoreCard.id); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError('createdScoreCard')));
    };
    SweepService.prototype.createEventDraw = function (id) {
        var _this = this;
        return this.http.post(this.createEventDrawUrl + id, httpOptions)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("updated event draw id=" + id); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError("createEventDraw")));
    };
    SweepService.prototype.closeEvent = function (id) {
        var _this = this;
        return this.http.post(this.closeEventUrl + id, httpOptions)
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["tap"])(function (_) { return _this.log("updated event oom and handicaps for event id" + id); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError("closedEvent")));
    };
    SweepService.prototype.playEvent = function (id) {
        this.messageService.add("Getting event to play id=" + id);
        return this.http.get(this.playEventUrl + id, httpOptions);
    };
    SweepService.prototype.joinSweep = function (id) {
        return this.http.post(this.sweepsUrl + 'join/' + id, httpOptions);
    };
    SweepService.prototype.approveSweepRequest = function (approval) {
        return this.http.post(this.sweepsUrl + 'approve', approval, httpOptions);
    };
    SweepService.prototype.enterEvent = function (event) {
        this.http.post(this.enterEventUrl, event, httpOptions).subscribe();
    };
    SweepService.prototype.createEvent = function (event) {
        //event.date = event.date.toISOString();
        //event.date = moment(event.date);
        return this.http.post(this.eventsUrl, event, httpOptions);
    };
    SweepService.prototype.createSweep = function (sweep) {
        return this.http.post(this.sweepsUrl + 'createSweep', sweep, httpOptions);
    };
    SweepService.prototype.withDrawEntry = function (event) {
        this.http.post(this.withDrawEntryUrl, event, httpOptions).subscribe();
    };
    SweepService.prototype.updateHandicap = function (updateHandicap) {
        return this.http.post(this.updateHandicapUrl, updateHandicap, httpOptions);
    };
    SweepService.prototype.log = function (message) {
        this.messageService.add("EventService: " + message);
    };
    SweepService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
            providedIn: 'root'
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"], _message_service__WEBPACK_IMPORTED_MODULE_4__["MessageService"]])
    ], SweepService);
    return SweepService;
}());



/***/ }),

/***/ "./ClientApp/app/sweeps-admin/sweeps-admin.component.css":
/*!***************************************************************!*\
  !*** ./ClientApp/app/sweeps-admin/sweeps-admin.component.css ***!
  \***************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL3N3ZWVwcy1hZG1pbi9zd2VlcHMtYWRtaW4uY29tcG9uZW50LmNzcyJ9 */"

/***/ }),

/***/ "./ClientApp/app/sweeps-admin/sweeps-admin.component.html":
/*!****************************************************************!*\
  !*** ./ClientApp/app/sweeps-admin/sweeps-admin.component.html ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div *ngIf=\"sweeps\">\r\n    <div class=\"card\" *ngFor=\"let sweep of sweeps\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <p class=\"navbar-brand\" href=\"#\">{{sweep.name}} <span *ngIf=\"sweep.userIsMember && sweep.approved\" class=\"badge badge-success\">Member</span></p>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\">\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\" routerLink=\"/sweep/admin/events/{{sweep.id}}\">{{sweep.totalEvents}} Events</a>\r\n\r\n                    </li>\r\n\r\n                    <!--<li class=\"nav-item\">\r\n\r\n                        <a *ngIf=\"!event.notDrawn\" routerLink=\"/event/play/{{event.id}}\" class=\"nav-link\" value=\"Play\">Play</a>\r\n\r\n                    </li>-->\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div style=\"text-align:center\">\r\n                <h6>\r\n                    Owner: {{sweep.owner}}\r\n                </h6>\r\n\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./ClientApp/app/sweeps-admin/sweeps-admin.component.ts":
/*!**************************************************************!*\
  !*** ./ClientApp/app/sweeps-admin/sweeps-admin.component.ts ***!
  \**************************************************************/
/*! exports provided: SweepsAdminComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SweepsAdminComponent", function() { return SweepsAdminComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../sweep.service */ "./ClientApp/app/sweep.service.ts");



var SweepsAdminComponent = /** @class */ (function () {
    function SweepsAdminComponent(service) {
        this.service = service;
        this.sweeps = [];
    }
    SweepsAdminComponent.prototype.ngOnInit = function () {
        this.getSweeps();
    };
    SweepsAdminComponent.prototype.getSweeps = function () {
        var _this = this;
        this.service.getAdminSweeps()
            .subscribe(function (sweeps) { return _this.sweeps = sweeps; });
    };
    SweepsAdminComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-sweeps-admin',
            template: __webpack_require__(/*! ./sweeps-admin.component.html */ "./ClientApp/app/sweeps-admin/sweeps-admin.component.html"),
            styles: [__webpack_require__(/*! ./sweeps-admin.component.css */ "./ClientApp/app/sweeps-admin/sweeps-admin.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_sweep_service__WEBPACK_IMPORTED_MODULE_2__["SweepService"]])
    ], SweepsAdminComponent);
    return SweepsAdminComponent;
}());



/***/ }),

/***/ "./ClientApp/app/sweeps/sweeps.component.css":
/*!***************************************************!*\
  !*** ./ClientApp/app/sweeps/sweeps.component.css ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL3N3ZWVwcy9zd2VlcHMuY29tcG9uZW50LmNzcyJ9 */"

/***/ }),

/***/ "./ClientApp/app/sweeps/sweeps.component.html":
/*!****************************************************!*\
  !*** ./ClientApp/app/sweeps/sweeps.component.html ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<!--<div *ngIf=\"sweeps\">\r\n    <a href=\"/Sweeps/Details/{{sweep.id}}\" *ngFor=\"let sweep of sweeps\">{{sweep.name}}</a>\r\n</div>-->\r\n\r\n<nav class=\"navbar sticky-top navbar-expand navbar-dark bg-danger justify-content-end card-nav\">\r\n    <div class=\"navbar-collapse collapse\">\r\n        <ul class=\"navbar-nav ml-auto\">\r\n\r\n            <li class=\"nav-item\">\r\n                <a class=\"nav-link\" data-toggle=\"modal\" data-target=\"#createSweepModal\">\r\n                    <i class=\"fas fa-plus\"></i> Sweep\r\n                </a>\r\n\r\n            </li>\r\n\r\n        </ul>\r\n    </div>\r\n</nav>\r\n\r\n\r\n<div *ngIf=\"sweeps\">\r\n    <div class=\"card\" *ngFor=\"let sweep of sweeps\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <p class=\"navbar-brand\" href=\"#\">\r\n                {{sweep.name}}\r\n                <span *ngIf=\"!isUserOwner(sweep) &&sweep.userIsMember && sweep.approved\" class=\"badge badge-success\">Member</span>\r\n                <span *ngIf=\"isUserOwner(sweep)\" class=\"badge badge-success\">Owner</span>\r\n            </p>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\">\r\n                    <li class=\"nav-item\" *ngIf=\"sweep.userIsMember && sweep.approved\">\r\n                        <a class=\"nav-link\" routerLink=\"/sweep/details/{{sweep.id}}\">{{sweep.totalEvents}} Events</a>\r\n\r\n                    </li>\r\n\r\n                    <!--<li class=\"nav-item\">\r\n\r\n                        <a *ngIf=\"!event.notDrawn\" routerLink=\"/event/play/{{event.id}}\" class=\"nav-link\" value=\"Play\">Play</a>\r\n\r\n                    </li>-->\r\n                    <li class=\"nav-item\" *ngIf=\"!sweep.userIsMember\">\r\n                        <button (click)=\"joinSweep(sweep)\" class=\"btn btn-sm btn-success float-right\" value=\"Join\">Join</button>\r\n\r\n                    </li>\r\n                    <li class=\"nav-item\" *ngIf=\"sweep.userIsMember\">\r\n                        <p *ngIf=\"!sweep.approved\" class=\"nav-link\"><span class=\"badge badge-danger\">Pending</span></p>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div style=\"text-align:center\">\r\n                <h6>\r\n                    Owner: {{sweep.owner}}\r\n                </h6>\r\n\r\n                <h6 *ngIf=\"isUserOwner(sweep)\">You are the owner</h6>\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"modal fade modal-mini\" id=\"createSweepModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"myModalLabel\" aria-hidden=\"true\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-header justify-content-center\">\r\n                Create New Sweep\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                <div>\r\n                    <form [formGroup]=\"createSweepForm\" (ngSubmit)=\"createSweep()\" novalidate>\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"input-group wd-sm-400 wd-lg-600\">\r\n                                <input type=\"text\" formControlName=\"name\" class=\"form-control\" placeholder=\"Enter Sweep Name\" autofocus>\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"input-group wd-sm-400 wd-lg-600\">\r\n                                <label class=\"form-control-label\">Public</label>\r\n                                <input type=\"checkbox\" formControlName=\"public\" class=\"form-control\">\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"justify-content-center\">\r\n                                <button type=\"submit\" class=\"btn btn-success\">Create Sweep</button>\r\n                            </div>\r\n                        </div>\r\n                    </form>\r\n\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <!--<button type=\"button\" class=\"btn btn-link btn-neutral\">Back</button>\r\n                <button type=\"button\" class=\"btn btn-link btn-neutral\" data-dismiss=\"modal\">Close</button>-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./ClientApp/app/sweeps/sweeps.component.ts":
/*!**************************************************!*\
  !*** ./ClientApp/app/sweeps/sweeps.component.ts ***!
  \**************************************************/
/*! exports provided: SweepsComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SweepsComponent", function() { return SweepsComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../sweep.service */ "./ClientApp/app/sweep.service.ts");
/* harmony import */ var _auth_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../auth.service */ "./ClientApp/app/auth.service.ts");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");





var SweepsComponent = /** @class */ (function () {
    function SweepsComponent(service, userService) {
        this.service = service;
        this.userService = userService;
        this.sweeps = [];
        this.createSweepForm = new _angular_forms__WEBPACK_IMPORTED_MODULE_4__["FormGroup"]({
            name: new _angular_forms__WEBPACK_IMPORTED_MODULE_4__["FormControl"](''),
            public: new _angular_forms__WEBPACK_IMPORTED_MODULE_4__["FormControl"](false)
        });
    }
    SweepsComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.userService.getUserAuthDetails().subscribe(function (data) {
            _this.userService.userAuth = data;
            _this.userAuth = _this.userService.userAuth;
        });
        this.getSweeps();
    };
    SweepsComponent.prototype.isUserOwner = function (sweep) {
        return this.userService.userAuth.sweepIds.some(function (s) { return s == sweep.id; });
    };
    SweepsComponent.prototype.getSweeps = function () {
        var _this = this;
        this.service.getSweeps()
            .subscribe(function (sweeps) { return _this.sweeps = sweeps; });
    };
    SweepsComponent.prototype.joinSweep = function (sweep) {
        this.service.joinSweep(sweep.id).subscribe(function (data) {
            sweep.userIsMember = true;
            sweep.approved = data.approved;
        });
    };
    SweepsComponent.prototype.createSweep = function () {
        var _this = this;
        this.createSweepForm.patchValue({});
        this.service.createSweep(this.createSweepForm.value).subscribe(function (data) {
            _this.sweeps.unshift(data);
            _this.createSweepForm.reset();
            $('#createSweepModal').modal('toggle');
        });
    };
    SweepsComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'sweeps-list',
            template: __webpack_require__(/*! ./sweeps.component.html */ "./ClientApp/app/sweeps/sweeps.component.html"),
            styles: [__webpack_require__(/*! ./sweeps.component.css */ "./ClientApp/app/sweeps/sweeps.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_sweep_service__WEBPACK_IMPORTED_MODULE_2__["SweepService"],
            _auth_service__WEBPACK_IMPORTED_MODULE_3__["AuthService"]])
    ], SweepsComponent);
    return SweepsComponent;
}());



/***/ }),

/***/ "./ClientApp/app/user-player/user-player.component.css":
/*!*************************************************************!*\
  !*** ./ClientApp/app/user-player/user-player.component.css ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL3VzZXItcGxheWVyL3VzZXItcGxheWVyLmNvbXBvbmVudC5jc3MifQ== */"

/***/ }),

/***/ "./ClientApp/app/user-player/user-player.component.html":
/*!**************************************************************!*\
  !*** ./ClientApp/app/user-player/user-player.component.html ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div *ngIf=\"player\">\r\n    <div class=\"card\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <a class=\"navbar-brand\" href=\"#\">{{player.fullName}}</a>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\"></ul>\r\n            </div>\r\n        </nav>\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <div style=\"text-align:center\">\r\n                <p>Current Handicap: <strong>{{player.currentHandicap}}</strong></p>\r\n                <p>Exact Handicap: <strong>{{player.currentExactHandicap}}</strong> </p>\r\n            </div>\r\n\r\n            <div style=\"text-align:center\">\r\n                <ul>\r\n                    <li *ngFor=\"let handicap of player.handicaps\">{{handicap.exact}} - {{handicap.created | date:short }}</li>\r\n                </ul>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card\" *ngFor=\"let event of player.events\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <a class=\"navbar-brand\" href=\"#\">{{event.date | date: short}}</a>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\">\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\" routerLink=\"/event/results/{{event.id}}\"><i class=\"fas fa-list\"></i> Results</a>\r\n                    </li>\r\n                    <li *ngIf=\"event.points && event.points.card\" class=\"nav-item\">\r\n                        <a class=\"nav-link\" routerLink=\"/scorecard/{{event.points.card.id}}\"><i class=\"fas fa-id-card\"></i> Card</a>\r\n                    </li>\r\n\r\n\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <h5>{{event.course.name}}</h5>\r\n            <div *ngIf=\"event.points\">\r\n                <h5 *ngIf=\"event.points.position\">Position: {{event.points.position}}</h5>\r\n                <h5 *ngIf=\"event.points.points\">OOM Points: {{event.points.points}}</h5>\r\n                <div *ngIf=\"event.points.card\">\r\n                    <h5>Gross {{event.points.card.outGross}} + {{event.points.card.inGross}} = {{event.points.card.totalGross}}</h5>\r\n                    <h5>Nett {{event.points.card.outNett}} + {{event.points.card.inNett}} = {{event.points.card.totalNett}}</h5>\r\n                    <h5>Points {{event.points.card.outPoints}} + {{event.points.card.inPoints}} = {{event.points.card.totalPoints}}</h5>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<button class=\"btn btn-danger\" (click)=\"goBack()\"><i class=\"fas fa-chevron-left\"></i></button>\r\n"

/***/ }),

/***/ "./ClientApp/app/user-player/user-player.component.ts":
/*!************************************************************!*\
  !*** ./ClientApp/app/user-player/user-player.component.ts ***!
  \************************************************************/
/*! exports provided: UserPlayerComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UserPlayerComponent", function() { return UserPlayerComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../sweep.service */ "./ClientApp/app/sweep.service.ts");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");




var UserPlayerComponent = /** @class */ (function () {
    function UserPlayerComponent(service, location) {
        this.service = service;
        this.location = location;
    }
    UserPlayerComponent.prototype.ngOnInit = function () {
        this.getUserPlayer();
    };
    UserPlayerComponent.prototype.getUserPlayer = function () {
        var _this = this;
        this.service.getUserPlayer()
            .subscribe(function (player) { return _this.player = player; });
    };
    UserPlayerComponent.prototype.goBack = function () {
        this.location.back();
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], UserPlayerComponent.prototype, "player", void 0);
    UserPlayerComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-user-player',
            template: __webpack_require__(/*! ./user-player.component.html */ "./ClientApp/app/user-player/user-player.component.html"),
            styles: [__webpack_require__(/*! ./user-player.component.css */ "./ClientApp/app/user-player/user-player.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_sweep_service__WEBPACK_IMPORTED_MODULE_2__["SweepService"],
            _angular_common__WEBPACK_IMPORTED_MODULE_3__["Location"]])
    ], UserPlayerComponent);
    return UserPlayerComponent;
}());



/***/ }),

/***/ "./ClientApp/app/virtual-match-play/virtual-match-play.component.css":
/*!***************************************************************************!*\
  !*** ./ClientApp/app/virtual-match-play/virtual-match-play.component.css ***!
  \***************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJDbGllbnRBcHAvYXBwL3ZpcnR1YWwtbWF0Y2gtcGxheS92aXJ0dWFsLW1hdGNoLXBsYXkuY29tcG9uZW50LmNzcyJ9 */"

/***/ }),

/***/ "./ClientApp/app/virtual-match-play/virtual-match-play.component.html":
/*!****************************************************************************!*\
  !*** ./ClientApp/app/virtual-match-play/virtual-match-play.component.html ***!
  \****************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div *ngIf=\"event\">\r\n    <div class=\"card\">\r\n        <nav class=\"navbar navbar-expand navbar-dark bg-info justify-content-end card-nav\">\r\n            <a class=\"navbar-brand\" href=\"#\">Virtual Match Play</a>\r\n            <div class=\"navbar-collapse collapse\">\r\n                <ul class=\"navbar-nav ml-auto\"></ul>\r\n            </div>\r\n        </nav>\r\n\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            <ul>\r\n                <li *ngFor=\"let result of event.results\">\r\n                    <p *ngIf=\"result.won\"><span class=\"text-success\"><i class=\"fas fa-check\"></i></span> You beat {{result.playerName}} <strong><span class=\"text-success\">{{result.matchResult}}&amp;{{ 18 - result.hole}}</span></strong></p>\r\n                    <p *ngIf=\"!result.won && !result.halved\"><span class=\"text-danger\"><i class=\"far fa-window-close\"></i></span> You lost to {{result.playerName}} <span class=\"text-danger\"><strong>{{result.matchResult}}&amp;{{18 - result.hole }}</strong></span></p>\r\n                    <p *ngIf=\"result.halved\">You halved your match with {{result.playerName}}</p>\r\n                </li>\r\n            </ul>\r\n            \r\n        </div>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./ClientApp/app/virtual-match-play/virtual-match-play.component.ts":
/*!**************************************************************************!*\
  !*** ./ClientApp/app/virtual-match-play/virtual-match-play.component.ts ***!
  \**************************************************************************/
/*! exports provided: VirtualMatchPlayComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "VirtualMatchPlayComponent", function() { return VirtualMatchPlayComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _sweep_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../sweep.service */ "./ClientApp/app/sweep.service.ts");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");





var VirtualMatchPlayComponent = /** @class */ (function () {
    function VirtualMatchPlayComponent(route, service, location) {
        this.route = route;
        this.service = service;
        this.location = location;
    }
    VirtualMatchPlayComponent.prototype.ngOnInit = function () {
        this.getMatchPlayResults();
    };
    VirtualMatchPlayComponent.prototype.getMatchPlayResults = function () {
        var _this = this;
        var id = this.route.snapshot.paramMap.get('id');
        this.service.getMatchPlayResults(id.toString())
            .subscribe(function (event) {
            _this.event = event;
        });
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], VirtualMatchPlayComponent.prototype, "event", void 0);
    VirtualMatchPlayComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-virtual-match-play',
            template: __webpack_require__(/*! ./virtual-match-play.component.html */ "./ClientApp/app/virtual-match-play/virtual-match-play.component.html"),
            styles: [__webpack_require__(/*! ./virtual-match-play.component.css */ "./ClientApp/app/virtual-match-play/virtual-match-play.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"],
            _sweep_service__WEBPACK_IMPORTED_MODULE_3__["SweepService"],
            _angular_common__WEBPACK_IMPORTED_MODULE_4__["Location"]])
    ], VirtualMatchPlayComponent);
    return VirtualMatchPlayComponent;
}());



/***/ }),

/***/ "./ClientApp/environments/environment.ts":
/*!***********************************************!*\
  !*** ./ClientApp/environments/environment.ts ***!
  \***********************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
var environment = {
    production: false
};
/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./ClientApp/main.ts":
/*!***************************!*\
  !*** ./ClientApp/main.ts ***!
  \***************************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm5/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "./ClientApp/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "./ClientApp/environments/environment.ts");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"])
    .catch(function (err) { return console.error(err); });


/***/ }),

/***/ 0:
/*!*********************************!*\
  !*** multi ./ClientApp/main.ts ***!
  \*********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\Users\PETETOSH\source\repos\Sweep\Sweep\ClientApp\main.ts */"./ClientApp/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map