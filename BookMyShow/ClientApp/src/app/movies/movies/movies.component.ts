import { Component, OnInit } from '@angular/core';
import { LocationService } from 'src/app/services/location.service';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.sass']
})

export class MoviesComponent implements OnInit {
  
  selectedLocation: string;
  selectedLocationSubscription: any;

  movies: movie[] = [
    {id: 0, name: "Avengers", releaseDate: "2021-07-25", endingDate: "2021-08-25", status: 0, apiid: 0, poster: "https://i.pinimg.com/originals/1f/26/d3/1f26d3c52508b1a46235e0cf7087ab65.jpg", languages: ['telugu', 'hindi', 'english']}
  ];
  moviesList: movie[];
  _filters: filters;

  capitalizeFirstLetter(str: string) {
    return str.charAt(0).toUpperCase() + str.slice(1);
  }

  constructor(private _locationService: LocationService) { 
    if(this._locationService.currentLocation) this.selectedLocation = this.capitalizeFirstLetter(this._locationService.currentLocation);
    this.selectedLocationSubscription = _locationService.currentLocationChange.subscribe(value => {
      this.selectedLocation = this.capitalizeFirstLetter(value);
    })
  }
  
  ngOnInit(): void {
    this.moviesList = [];
    this._filters = {date: "2021-07-25", languages: ['telugu', 'hindi'], status: 0};
    this.initializeMovies();
  }

  initializeMovies(){
    this.movies.forEach(el => {
      if(el.status == this._filters.status){
        this.moviesList.push(el);
      }
    })
  }

}

interface movie{
  id: number,
  name: string,
  releaseDate: string,
  endingDate: string,
  status: Status,
  apiid: number,
  poster: string,
  languages: string[]
};

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
