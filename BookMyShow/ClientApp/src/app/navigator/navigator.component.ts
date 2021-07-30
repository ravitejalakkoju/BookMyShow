import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Location } from '@angular/common';

import { LocationService } from '../services/location.service';

@Component({
  selector: 'app-navigator',
  templateUrl: './navigator.component.html',
  styleUrls: ['./navigator.component.sass']
})
export class NavigatorComponent implements OnInit {

  moviesRouterLink: string = 'none';
  isExpanded = false;
  _subscription: any;

  constructor(private _locationService: LocationService) { 
    this._subscription = this._locationService.currentLocationChange.subscribe((value) => {
      this.moviesRouterLink = 'explore/' + value + '/movies'
    })
  }

  ngOnInit(): void {
  }

  moviesNavigatorClick($event){
    if(this.moviesRouterLink == 'none'){ 
      $event.stopPropagation();
      $event.preventDefault()
      this._locationService.updatePickLocationChange(true);
    }
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
