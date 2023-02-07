import { ScoreCard } from './ScoreCard';

export interface Entry {
    id: string;
    group: number;
    scoreCard: ScoreCard;
    marker: ScoreCard;
    paid: boolean;  
}

