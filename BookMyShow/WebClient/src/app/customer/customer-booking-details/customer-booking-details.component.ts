import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BookingsService } from 'src/app/services/bookings.service';
import { IBookingByCustomer } from '../../Interfaces/IBookingByCustomer';
import { IMovieDetails } from '../../Interfaces/IMovieDetails';
import { MoviesService } from '../../services/movies.service';

@Component({
  selector: 'app-customer-booking-details',
  templateUrl: './customer-booking-details.component.html',
  styleUrls: ['./customer-booking-details.component.sass']
})
export class CustomerBookingDetailsComponent implements OnInit {

  currentId: number;
  currentIdSubscription: any;

  bookingDetails: IBookingByCustomer;
  movieDetails: IMovieDetails;

  constructor(private _activatedRoute: ActivatedRoute,
    private bookingsService: BookingsService,
    private movieService: MoviesService) {
    this.currentId = +this._activatedRoute.snapshot.paramMap.get('bookingId');
    this.bookingsService.updateCurrentId(this.currentId);
  }

  ngOnInit(): void {
    this.currentIdSubscription = this._activatedRoute.params.subscribe(params => {
      this.currentId = +params['bookingId']
      this.bookingsService.updateCurrentId(this.currentId);
      this.bookingsService.getBookingDetails(this.currentId).subscribe(result => {
        this.bookingDetails = result;
        this.movieService.getMovieDetails(result.movieAPIID).subscribe(result => {
          this.movieDetails = result;
        }, error => console.error(error))

      }, error => console.error(error))
    });
  }

  
}
