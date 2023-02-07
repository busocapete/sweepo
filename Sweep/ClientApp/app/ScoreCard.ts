import { Player } from './Player';
import { Score, Course } from './Score';

export interface ScoreCard {
    id: string;
    scores: Score[];
    player: Player
    totalPoints: number;
    outPoints: number;
    inPoints: number;
    course: Course
}


export interface UpdateCard {
    id: string;
    playerId: string;
    courseId: string;
    first: number;
    second: number;
    third: number;
    fourth: number;
    fifth: number,
    sixth: number,
    seventh: number,
    eighth: number,
    ninth: number,
    tenth: number,
    eleventh: number;
    twelfth: number;
    thirteenth: number;
    fourteenth: number;
    fifteenth: number;
    sixteenth: number;
    seventeenth: number;
    eighteenth: number;

}
