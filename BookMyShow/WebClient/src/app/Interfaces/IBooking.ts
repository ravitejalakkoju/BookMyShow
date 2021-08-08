import { Time } from "@angular/common";

export interface IBooking {
  id: number,
  amount: number,
  dateTime: Time,
  status: number,
  customerID: number
}
