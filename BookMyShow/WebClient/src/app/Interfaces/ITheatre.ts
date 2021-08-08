import { Time } from "@angular/common";

export interface ITheatre {
  id: number,
  name: string,
  locationID: number,
  screenID: number,
  showTime: Time
}
