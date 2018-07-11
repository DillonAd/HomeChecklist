import { Task } from "./task";

export interface Room {
    Id: number;
    Name: string;
    Tasks: Task[];
}
