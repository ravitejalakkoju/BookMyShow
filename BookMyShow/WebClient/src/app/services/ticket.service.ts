import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ITicket } from '../Interfaces/ITicket';

@Injectable({
  providedIn: 'root'
})
export class TicketService {

  constructor(private http: HttpClient) { }

  createTicketsForBooking(ticket: ITicket) {
    return this.http.post<ITicket>('https://localhost:44352/api/tickets', ticket);
  }
}
