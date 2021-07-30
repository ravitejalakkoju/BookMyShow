import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-seat-selection',
  templateUrl: './seat-selection.component.html',
  styleUrls: ['./seat-selection.component.sass']
})
export class SeatSelectionComponent implements OnInit {

  levels: number;
  seatsPerLevel: number;

  seatBooked: boolean[][];
  selectedSeats: string[] = [];
  disableBooking: boolean = false;

  constructor() { }

  ngOnInit(): void {
    this.levels = 10
    this.seatsPerLevel = 20
    this.seatBooked = [];

    for (let level = 0; level < this.levels; level++) {
      this.seatBooked[level] = []
      for (let seat = 0; seat < this.seatsPerLevel; seat++) {
        this.seatBooked[level][seat] = false;
      }      
    }
    
  }

  bookSeat(seat: any){
    if(this.selectedSeats.length < 5){
      let position: any = seat.split(',');
      if(!this.seatBooked[this.levels-position[0]-1][position[1]]) { 
        this.seatBooked[this.levels-position[0]-1][position[1]] = true;
        let selectedSeat: string = this.numToChar(this.levels-position[0]-1) + '' + position[1];
        this.selectedSeats.push(selectedSeat);
      } else {
        this.seatBooked[this.levels-position[0]-1][position[1]] = false;
        let selectedSeat: string = this.numToChar(this.levels-position[0]-1) + '' + position[1];
        this.selectedSeats = this.selectedSeats.filter(el => el != selectedSeat);
      }
    } else {
      this.disableBooking = true;
    }
  }

  numToChar(num: number){
    return String.fromCharCode(65 + num)
  }
}
