import { Component, OnInit } from '@angular/core';
import {Location} from '@angular/common';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.sass']
})
export class SearchComponent implements OnInit {

  movies: string[] = []

  matchedMovies: string[] = []
  searchValue: string = null
  
  constructor(private _location: Location) { }
  
  initializeMovies(){
    this.movies.push('Avengers');
    this.movies.push('Avengers: Age Of Ultron');
    this.movies.push('Avengers: Infinity War');
    this.movies.push('Avengers: End Game');
    this.movies.push('Captain America: Civil War');
  }

  boldText(text: string){
    return '<b>' + text + '</b>';
  }
  search(){
    this.matchedMovies = []
    this.movies.forEach(movie => {
      if(movie.includes(this.searchValue) && this.searchValue != '') this.matchedMovies.push(movie.replace(this.searchValue, this.boldText(this.searchValue)))
    });
  }

  goBack(){
    this._location.back();
  }

  ngOnInit(): void {
    this.initializeMovies();
  }

}
