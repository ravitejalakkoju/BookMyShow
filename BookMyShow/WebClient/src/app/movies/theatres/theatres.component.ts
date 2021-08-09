import { formatDate } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ITheatre } from '../../Interfaces/ITheatre';
import { TheatresService } from '../../services/theatres.service';
import { MoviesService } from '../../services/movies.service';
import { ActivatedRoute, Router } from '@angular/router';
import { LocationService } from '../../services/location.service';
import { IMovie } from '../../Interfaces/IMovie';
import { link } from 'fs';

@Component({
  selector: 'app-theatres',
  templateUrl: './theatres.component.html',
  styleUrls: ['./theatres.component.sass']
})
export class TheatresComponent implements OnInit {

  dates: string[];
  theatres: ITheatre[];
  movie: IMovie;
  selectedDate: string = null;
  currentDate: Date = new Date();
  
  initializeDates(){
    this.selectedDate = formatDate(this.currentDate, 'yyyy-MM-dd', 'en');
    for (let index = 0; index <= 0; index++) {
      let date = new Date();
      this.dates.push(formatDate(date.setDate(date.getUTCDate()+index), 'yyyy-MM-dd', 'en')); 
    }
  }

  selectDate(e: { value: string; }){
    this.selectedDate = e.value;
  }


  constructor(private theatresService: TheatresService,
    private locationService: LocationService,
    private moviesService: MoviesService,
    private route: ActivatedRoute,
    private router: Router  ) {
    this.dates = []
    this.theatres = []
  }

  ngOnInit(): void {
    let locationId: number;
    let movieId: number;
    if (!this.locationService.currentLocation) this.router.navigate(['/']);
    else {
      locationId = this.locationService.currentLocation.id;
      movieId = parseInt(this.route.snapshot.paramMap.get('movieId'));

      this.moviesService.getMovie(movieId).subscribe(result => {
        this.movie = result;
      })
      this.initializeDates();
      this.theatresService.GetTheatresForMovieAtLocation(locationId, movieId).subscribe(result => {
        this.theatres = result
        this.groups = this.groupBy(this.theatres, "id");
        this.mergeObjects();
      }, error => console.error(error));

    }
  }

  groups: any;

  mergeObjects() {
    
    Object.keys(this.groups).map((x, y) => {
      let newX = this.groups[x][0];
      for (let t = 1; t < this.groups[x].length; ++t) {
        newX.screenID += "|" + this.groups[x][t].screenID;
        newX.showTime += "|" + this.groups[x][t].showTime;
      }
    });
  }

  groupBy: any = (items, key) =>
    items.reduce(
      (result, item) => ({
        ...result,
        [item[key]]: [...(result[item[key]] || []), item],
      }),
      {}
    );

  
}
