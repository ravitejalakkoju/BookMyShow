import { formatDate } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-theatres',
  templateUrl: './theatres.component.html',
  styleUrls: ['./theatres.component.sass']
})
export class TheatresComponent implements OnInit {

  dates: string[];
  selectedDate: string = null;
  currentDate: Date = new Date();
  
  initializeDates(){
    this.selectedDate = formatDate(this.currentDate, 'yyyy-MM-dd', 'en');
    for (let index = 0; index <= 14; index++) {
      let date = new Date();
      this.dates.push(formatDate(date.setDate(date.getUTCDate()+index), 'yyyy-MM-dd', 'en')); 
    }
  }

  selectDate(e: { value: string; }){
    this.selectedDate = e.value;
  }

  theatres: Theatre[] = [];

  constructor(http: HttpClient) {
    let baseUrl: string = 'https://localhost:44352/';

    http.get<Theatre[]>(baseUrl + 'api/theatres').subscribe(result => {
      this.theatres = result;
    }, error => console.error(error)); 
    this.dates = []
    this.initializeDates();
  }

  ngOnInit(): void {
  }

}

interface Theatre{
  id: number,
  name: string,
  locationID: number
}
