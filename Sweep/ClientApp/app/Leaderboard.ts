export interface Leaderboard {
    leaderBoard: LeaderboardItem[];
}

export interface LeaderboardItem {
    id: string;
    fullname: string;
    position: number;
    totalPoints: number;
    currentHole: number;
    scoreCardId: string;
}