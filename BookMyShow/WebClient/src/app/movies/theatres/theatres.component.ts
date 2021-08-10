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
import { ISeatsInScreen } from '../../Interfaces/ISeatsInScreen';
import { SeatService } from '../../services/seat.service';
import { Hash } from 'crypto';

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

  seatsInScreen: object = null;
  
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

  checkShowTimeAvailability(showTime: string) {
    let date: Date = new Date('1/1/1999 ' + showTime);
    let currentMinutes = this.currentDate.getHours() * 60 + this.currentDate.getMinutes();
    let showMinutes = date.getHours() * 60 + date.getMinutes();
    return showMinutes > currentMinutes;
  }

  isShowTimes(showTimes: string) {
    let showTimesArray: string[] = showTimes.split("|");
    let isAvailable: boolean = true;
    showTimesArray.forEach((el, index) => {
      if (!this.checkShowTimeAvailability(el)) isAvailable = false;
    })
    return isAvailable;
  }

  constructor(private theatresService: TheatresService,
    private locationService: LocationService,
    private moviesService: MoviesService,
    private route: ActivatedRoute,
    private seatService: SeatService,
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

        this.theatres = result.filter(t => this.isShowTimes(t.showTimes))

        this.seatService.GetSeatCountInScreens().subscribe(result => {
          this.seatsInScreen = result.reduce(function (map, obj) {
            map[obj.screenID] = obj.seatCount;
            return map;
          }, {});

        }, error => console.error(error))

      }, error => console.error(error));

    }
  }


  
}
