import { Resident } from './resident';
import { Room } from './room';

export class Home {
    Id: number;
    Name: string;
    Residents: Resident[];
    Rooms: Room[];
}
