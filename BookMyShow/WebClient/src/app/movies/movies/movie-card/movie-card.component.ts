import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-movie-card',
  templateUrl: './movie-card.component.html',
  styleUrls: ['./movie-card.component.sass']
})
export class MovieCardComponent implements OnInit {

  @Input() movie: movie;
  
  constructor() { }

  ngOnInit(): void {
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

enum Status{
  released = 0, 
  notReleased,
  all
}