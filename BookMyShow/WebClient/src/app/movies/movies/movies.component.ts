import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LocationService } from 'src/app/services/location.service';
import { MoviesService } from '../../services/movies.service';

import { IMovie } from '../../Interfaces/IMovie';
import { ILocation } from '../../Interfaces/ILocation';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.sass']
})

export class MoviesComponent implements OnInit {

  selectedLocation: ILocation;
  selectedLocationSubscription: any;

  movies: IMovie[] = [];
  filters: filters;

  capitalizeFirstLetter(str: string) {
    return str.charAt(0).toUpperCase() + str.slice(1);
  }

  constructor(private router: Router, private _locationService: LocationService, private movieService: MoviesService) {
    if (this._locationService.currentLocation) this.selectedLocation = this._locationService.currentLocation;
    this.selectedLocationSubscription = _locationService.currentLocationChange.subscribe(value => {
      this.selectedLocation = value;
      this.initializeMovies();
    })
  }
  
  ngOnInit(): void {
    this.filters = { date: "2021-07-25", languages: ['Kannada', 'Hindi'], status: 1 };
    if (this.selectedLocation) this.initializeMovies();
    else this._locationService.updatePickLocationChange(true);
  }

  initializeMovies() {
    this.movieService.getMoviesByLocation(this.selectedLocation.id).subscribe(result => {
      this.movies = result;
    }, error => console.error(error));
  }

  onClick() {
    this.movies = this.movies.filter(m => m.languages.indexOf(this.filters.languages[0]) >= 0 && m.languages.indexOf(this.filters.languages[1]) >= 0)
    console.log(this.movies);
  }
}



interface filters{
  date: string,
  languages: string[],
  status: number
}

enum Status{
  released = 0, 
  notReleased,
  all
}
