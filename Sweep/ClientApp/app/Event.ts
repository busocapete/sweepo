import { PlayerResponse } from './Player';

export interface Event {
    id: string;
    date: Date;
    userHasJoined: boolean;
    sweepId: string;
    groupedEntries: [[], []];
    playerNames: PlayerResponse[];
    sweepMembers: [];

}


