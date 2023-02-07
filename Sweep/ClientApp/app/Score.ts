export interface Score {
    id: string;
    gross: number;
    nett: number;
    points: number;
    holeNumber: number;
    course: Course
}

export interface Course {
    id: string;
    name: string;
}

export interface CreateScoreCard {
    id: string;
    courseId: string;
    playerId: string;
}