import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ITheatre } from '../Interfaces/ITheatre';

@Injectable({
  providedIn: 'root'
})
export class TheatresService {

  constructor(private http: HttpClient) { }

  GetTheatre(theatreId: number) {
    return this.http.get<ITheatre>('https://localhost:44352/api/theatres/' + theatreId);
  }

  GetTheatresForMovieAtLocation(locationId: number, movieId: number) {
    return this.http.get<ITheatre[]>(`https://localhost:44352/api/theatres?locationId=${locationId}&movieId=${movieId}`);
  }
}
