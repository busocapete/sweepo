import { Player } from './Player';
import { Event } from './Event';
import { SweepApproval } from './SweepApproval';

export interface Sweep {
    id: string;
    name: string;
    owner: string;
    totalEvents: number;
    events: Event[];
    members: Player[];
    requests: Player[];
    userIsMember: boolean;
    approved: boolean;
}