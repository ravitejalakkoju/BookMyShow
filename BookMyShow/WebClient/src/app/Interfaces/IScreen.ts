import { Time } from "@angular/common";

export interface IScreen{
  id: number,
  code: string,
  levels: number,
  seatsPerLevel: number,
  theatreID: number,
  movieID: number,
  seatPrice: number,
  showTime: Time
}
