import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, ActivationStart, Router, RouterOutlet } from '@angular/router';
import { Subscription } from 'rxjs';
import { BookingsService } from 'src/app/services/bookings.service';

@Component({
  selector: 'app-customer-bookings',
  templateUrl: './customer-bookings.component.html',
  styleUrls: ['./customer-bookings.component.sass']
})
export class CustomerBookingsComponent implements OnInit {

  currentId: number;
  currentIdSubscription: Subscription;
  
  @ViewChild(RouterOutlet) outlet: RouterOutlet;

  constructor(private router: Router,
    private _bookingsService: BookingsService) {  
      this.currentId = this._bookingsService.currentId
    }

  ngOnInit(): void {
    this.router.events.subscribe(e => {
      if (e instanceof ActivationStart && e.snapshot.outlet === "customer-bookings")
        this.outlet.deactivate();
    });
    this._bookingsService.currentIdChange.subscribe(value => {
      this.currentId = value
    })
  }

  nullifyCurrentId(){
    this._bookingsService.updateCurrentId(null);
  }

}
