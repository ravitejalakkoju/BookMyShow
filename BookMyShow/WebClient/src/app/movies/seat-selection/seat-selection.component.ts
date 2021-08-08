import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IScreen } from '../../Interfaces/IScreen';
import { ISeat } from '../../Interfaces/ISeat';
import { MoviesService } from '../../services/movies.service';
import { ScreensService } from '../../services/screens.service';
import { SeatService } from '../../services/seat.service';
import { TheatresService } from '../../services/theatres.service';

@Component({
  selector: 'app-seat-selection',
  templateUrl: './seat-selection.component.html',
  styleUrls: ['./seat-selection.component.sass']
})
export class SeatSelectionComponent implements OnInit {

  login: boolean = true;

  theatreName: string;
  movieName: string;
  screen: IScreen;
  seats: ISeat[] = [];

  selectedSeats: ISeat[] = [];
  disableBooking: boolean = false;

  constructor(private route: ActivatedRoute,
    private theatreService: TheatresService,
    private movieService: MoviesService,
    private screenService: ScreensService) { }

  ngOnInit(): void {
    let t: any = this.route.snapshot.paramMap.get('theatreId');
    this.theatreService.GetTheatre(t).subscribe(result => {
      this.theatreName = result.name
    }, error => console.error(error))


    let s: any = this.route.snapshot.paramMap.get('screenId');
    this.screenService.GetScreen(s).subscribe(result => {
      this.screen = result;
      console.log(result);
      this.movieService.getMovie(result.movieID).subscribe(result => {
        this.movieName = result.name
      }, error => console.error(error))

      this.screenService.GetSeatsInScreen(result.id).subscribe(result => {
        this.seats = result
      }, error => console.error(error))

      console.log(this.screen);
    }, error => console.error(error))
  }

  toggleSeatSelection(seatCode: string) {
    let seat: ISeat = this.seats.find(s => s.code == seatCode);
    if (this.selectedSeats.length < 5) {
      if (seat.active == 1) {
        seat.active = 0;
        this.selectedSeats.push(seat)
      } else {
        seat.active = 1;
        this.selectedSeats = this.selectedSeats.filter(s => s != seat)
      }
    }
  }

  confirmBooking() {

  }

  numToChar(num: number){
    return String.fromCharCode(65 + num)
  }
}
