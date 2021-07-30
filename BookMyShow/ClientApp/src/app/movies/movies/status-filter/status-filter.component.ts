import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-status-filter',
  templateUrl: './status-filter.component.html',
  styleUrls: ['./status-filter.component.sass']
})
export class StatusFilterComponent implements OnInit {

  showStatusSelector: boolean = false;
  selectedStatus: string;
  released: string = "released";
  releasedSoon: string = "releasingSoon";

  constructor() { }

  toggleStatusSelector(){
    this.showStatusSelector = !this.showStatusSelector
  }

  statusChange(value: string){
    this.selectedStatus = value;
  }

  reset(){
    this.selectedStatus = null;
  }

  ngOnInit(): void {
  }

}
