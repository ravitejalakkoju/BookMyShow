import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BookingsService } from 'src/app/services/bookings.service';

@Component({
  selector: 'app-customer-booking-details',
  templateUrl: './customer-booking-details.component.html',
  styleUrls: ['./customer-booking-details.component.sass']
})
export class CustomerBookingDetailsComponent implements OnInit {

  currentId: number;
  currentIdSubscription: any;


  constructor(private _activatedRoute: ActivatedRoute,
    private _bookingsService: BookingsService) { 
      this._bookingsService.updateCurrentId(+this._activatedRoute.snapshot.paramMap.get('bookingId'));
  }

  ngOnInit(): void {
    this.currentIdSubscription = this._activatedRoute.params.subscribe(params => {
      this.currentId = +params['bookingId']
      this._bookingsService.updateCurrentId(this.currentId);
    });
  }

}
