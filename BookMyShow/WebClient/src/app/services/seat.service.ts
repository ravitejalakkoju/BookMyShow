import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ISeat } from '../Interfaces/ISeat';
import { ISeatsInScreen } from '../Interfaces/ISeatsInScreen';

@Injectable({
  providedIn: 'root'
})
export class SeatService {

  constructor(private http: HttpClient) { }

  GetSeatsInScreen(id: number) {
    return this.http.get<ISeat[]>('https://localhost:44352/api/seats/' + id);
  }

  GetSeatCountInScreens() {
    return this.http.get<ISeatsInScreen[]>('https://localhost:44352/api/seats');
  }
}
