import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IMovie } from '../Interfaces/IMovie';
import { IMovieDetails } from '../Interfaces/IMovieDetails';
import { ILanguage } from '../Interfaces/ILanguage';

@Injectable({
  providedIn: 'root'
})
export class MoviesService {

  constructor(private http: HttpClient) { }

  getMoviesByLocation(locationId: number) {
    return this.http.get<IMovie[]>('https://localhost:44352/' + 'api/movies?locationId=' + locationId);
  }

  getLanguages() {
    return this.http.get<ILanguage[]>('https://localhost:44352/' + 'api/movies/languages');
  }

  getMovie(id: number) {
    return this.http.get<IMovie>('https://localhost:44352/' + 'api/movies/' + id);
  }

  getMovieDetails(apiid: string) {
    return this.http.get<IMovieDetails>('https://www.omdbapi.com/?i=' + apiid + '&apikey=dbaf7dd7');
  }

}
