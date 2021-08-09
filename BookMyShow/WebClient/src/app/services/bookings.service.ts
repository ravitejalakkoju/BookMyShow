import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { IBooking } from '../Interfaces/IBooking';
import { Time } from "@angular/common";
import { HttpClient } from '@angular/common/http';
import { IBookingByCustomer } from '../Interfaces/IBookingByCustomer';
import { ITicket } from '../Interfaces/ITicket';

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

  getBookingsByCustomer(customerID: number) {
    return this.http.get<IBookingByCustomer[]>('https://localhost:44352/api/bookings?customerId=' + customerID);
  }

  getBookingDetails(bookingID: number) {
    return this.http.get<IBookingByCustomer>('https://localhost:44352/api/bookings/' + bookingID);
  }

  createBookingForCustomer(booking: IBooking) {
    return this.http.post<IBooking>('https://localhost:44352/api/bookings', booking);
  }

  constructor(private http: HttpClient) { }
}
