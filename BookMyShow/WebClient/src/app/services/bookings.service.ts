import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { IBooking } from '../Interfaces/IBooking';
import { Time } from "@angular/common";

@Injectable({
  providedIn: 'root'
})
export class BookingsService {
  
  currentId: number;
  currentIdChange: Subject<number> = new Subject<number>();

  updateCurrentId(value: number){
    this.currentId = value
    this.currentIdChange.next(this.currentId)
  }

  bookings: IBooking[] = [
    { id: 1, amount: 300, dateTime: { hours: 13, minutes: 15 }, status: 0, customerID: 1},
    { id: 2, amount: 300, dateTime: { hours: 13, minutes: 15 }, status: 0, customerID: 2},
    { id: 3, amount: 300, dateTime: { hours: 13, minutes: 15 }, status: 0, customerID: 3}
  ]

  constructor() { }
}
