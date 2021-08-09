import { Component, OnInit } from '@angular/core';
import {Location} from '@angular/common';
import { MoviesService } from '../services/movies.service';
import { LocationService } from '../services/location.service';
import { IMovie } from '../Interfaces/IMovie';
import { Router } from '@angular/router';
import { ILocation } from '../Interfaces/ILocation';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.sass']
})
export class SearchComponent implements OnInit {

  movies: IMovie[] = []

  matchedMovies: string[] = []
  matchedMovieIDs: number[] = []
  searchValue: string = null

  currentLocation: ILocation = null;

  constructor(private _location: Location,
    private movieService: MoviesService,
    private locationService: LocationService,
    private router: Router) { }
  
  initializeMovies() {
    this.movieService.getMoviesByLocation(this.currentLocation.id).subscribe(result => {
      this.movies = result;
    }, error => console.error(error));
  }

  boldText(text: string){
    return '<b>' + text + '</b>';
  }
  search(){
    this.matchedMovies = []
    this.matchedMovieIDs = []
    this.movies.forEach(movie => {
      if (movie.name.includes(this.searchValue) && this.searchValue != '') {
        this.matchedMovies.push(movie.name.replace(this.searchValue, this.boldText(this.searchValue)))
        this.matchedMovieIDs.push(movie.id)
      }
    });
  }

  goBack(){
    this._location.back();
  }

  ngOnInit(): void {
    if (this.locationService.currentLocation == null) this.router.navigate(['/']);
    else {
      this.currentLocation = this.locationService.currentLocation;
      this.initializeMovies();
    }
  }

}
