import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IBooking } from '../../Interfaces/IBooking';
import { ICustomer } from '../../Interfaces/ICustomer';
import { IScreen } from '../../Interfaces/IScreen';
import { ISeat } from '../../Interfaces/ISeat';
import { ITicket } from '../../Interfaces/ITicket';
import { BookingsService } from '../../services/bookings.service';
import { CustomersService } from '../../services/customers.service';
import { MoviesService } from '../../services/movies.service';
import { ScreensService } from '../../services/screens.service';
import { SeatService } from '../../services/seat.service';
import { TheatresService } from '../../services/theatres.service';
import { TicketService } from '../../services/ticket.service';

@Component({
  selector: 'app-seat-selection',
  templateUrl: './seat-selection.component.html',
  styleUrls: ['./seat-selection.component.sass']
})
export class SeatSelectionComponent implements OnInit {

  isLogged: boolean = false;

  theatreName: string;
  movieName: string;
  screen: IScreen;
  seats: ISeat[] = [];

  selectedSeats: ISeat[] = [];
  currentCustomer: ICustomer = this.customerService.currentCustomer;

  constructor(private route: ActivatedRoute,
    private theatreService: TheatresService,
    private movieService: MoviesService,
    private screenService: ScreensService,
    private customerService: CustomersService,
    private bookingService: BookingsService,
    private ticketService: TicketService,
    private seatService: SeatService,
    private router: Router) {
    this.customerService.currentCustomerChange.subscribe(value => {
      this.currentCustomer = value;
    })
  }

  ngOnInit(): void {
    let t: any = this.route.snapshot.paramMap.get('theatreId');
    this.theatreService.GetTheatre(t).subscribe(result => {
      this.theatreName = result.name
    }, error => console.error(error))


    let s: any = this.route.snapshot.paramMap.get('screenId');
    this.screenService.GetScreen(s).subscribe(result => {
      this.screen = result;
      this.movieService.getMovie(result.movieID).subscribe(result => {
        this.movieName = result.name
      }, error => console.error(error))

      this.seatService.GetSeatsInScreen(result.id).subscribe(result => {
        this.seats = result
      }, error => console.error(error))

    }, error => console.error(error))

    this.isLogged = !(this.currentCustomer == null)
  }

  toggleSeatSelection(seatCode: string) {
    let seat: ISeat = this.seats.find(s => s.code == seatCode);
    if (seat.active == 1 && this.selectedSeats.length < 5) {
      seat.active = 0;
      this.selectedSeats.push(seat)
    } else {
      seat.active = 1;
      this.selectedSeats = this.selectedSeats.filter(s => s != seat)
    }
  }

  confirmBooking() {
    let booking = {
      amount: this.selectedSeats.length * this.screen.seatPrice,
      customerID: this.customerService.currentCustomer.id
    }
    this.bookingService.createBookingForCustomer(booking as IBooking).subscribe(result => {
      console.log(parseInt(result.toString()));
      this.selectedSeats.forEach(seat => {
        let bookingID: number = parseInt(result.toString());
        this.ticketService.createTicketsForBooking({ seatID: seat.id, bookingID: bookingID } as ITicket).subscribe(result => {
          this.router.navigate(['user/customer', booking.customerID, 'bookings', bookingID ])
        }, error => console.error(error))
      })
      
    }, error => console.error(error));
  }

  loginRequiredAlert() {
    alert('You need to be logged in to book tickets');
  }

  numToChar(num: number){
    return String.fromCharCode(65 + num)
  }
}
