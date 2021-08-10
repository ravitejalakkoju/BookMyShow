import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, ActivationStart, Router, RouterOutlet } from '@angular/router';
import { Subscription } from 'rxjs';
import { BookingsService } from 'src/app/services/bookings.service';
import { IBooking } from '../../Interfaces/IBooking';
import { IBookingByCustomer } from '../../Interfaces/IBookingByCustomer';

@Component({
  selector: 'app-customer-bookings',
  templateUrl: './customer-bookings.component.html',
  styleUrls: ['./customer-bookings.component.sass']
})
export class CustomerBookingsComponent implements OnInit {

  currentId: number = -1;
  customerId: number;
  currentIdSubscription: Subscription;

  customerBookings: IBookingByCustomer[] = [];

  @ViewChild(RouterOutlet) outlet: RouterOutlet;

  constructor(private router: Router,
    private _bookingsService: BookingsService,
    private route: ActivatedRoute) {
    this.currentId = this._bookingsService.currentId
    this.route.parent.params.subscribe(
      params => {
         this.customerId = params.id;
      }
    );
    }

  ngOnInit(): void {
    this._bookingsService.currentIdChange.subscribe(value => {
      this.currentId = value
    })
    this._bookingsService.getBookingsByCustomer(this.customerId).subscribe(result => {
      this.customerBookings = result;
    }, error => console.error(error));
  }

  ngOnChanges(): void {

  }

  compareDate(bookingDateTime: Date) {
    let bookingDate: Date = new Date(bookingDateTime)
    let todaysDate: Date = new Date();
    if (bookingDate.getTime() < todaysDate.getTime()) {
      return true;
    } else return false;
  }

  nullifyCurrentId(){
    this._bookingsService.updateCurrentId(null);
  }

}
