import { Component, OnInit } from '@angular/core';
import {formatDate} from '@angular/common';

@Component({
  selector: 'app-date-filter',
  templateUrl: './date-filter.component.html',
  styleUrls: ['./date-filter.component.sass']
})
export class DateFilterComponent implements OnInit {

  showDateSelector: boolean = false;
  selectedDate: string;
  currentDate: string;
  nextDate: string;

  constructor() { 
    let date = new Date();
    this.currentDate = formatDate(date, 'yyyy-MM-dd', 'en');
    this.nextDate = formatDate(date.setDate(date.getDate() + 1), 'yyyy-MM-dd', 'en');
  }
  
  toggleDateSelector(){
    this.showDateSelector = !this.showDateSelector
  }

  dateChange(value: string){
    this.selectedDate = value;
  }

  reset(){
    this.selectedDate = null;
  }


  ngOnInit(): void {
  }

}
