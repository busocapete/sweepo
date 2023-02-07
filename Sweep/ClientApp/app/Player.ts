import { Entry } from './Entry';
import { Course } from './Score';

export interface Player {
    id: string;
    fullName: string;
    userId: string;
    currentHandicap: number;
    currentExactHandicap: number;
    handicaps: [];
    //entries: Entry[];
    events: PlayerEvent[]
}

export interface PlayerEvent {
    id: string;
    date: Date;
    entry: [];
    course: Course;
    winterHandicaps: boolean;
}

export interface PlayerResponse {
    id: string;
    name: string;
}
