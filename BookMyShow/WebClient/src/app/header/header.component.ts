import { Component, OnInit } from '@angular/core';

import { LocationService } from '../services/location.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.sass']
})
export class HeaderComponent implements OnInit {

  isExpanded: boolean = false;
  isLogged: boolean = false;

  selectedCity: string = "Select City"; 

  locationPicker: boolean;
  locationPickerSubscription: any;
  
  options: boolean = false;

  constructor(private _locationService: LocationService) { 
      this.locationPicker = this._locationService.pickLocation;
      this.locationPickerSubscription = this._locationService.pickLocationChange.subscribe(value => {
        this.locationPicker = value
      })
  }
  
  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
  
  toggleLocationPicker(){
    this.locationPicker = !this.locationPicker;
    this._locationService.updatePickLocationChange(this.locationPicker);
  }

  toggleOptions(){
    this.options = !this.options;
  }

  capitalizeFirstLetter(str: string) {
    return str.charAt(0).toUpperCase() + str.slice(1);
  }

  selectCity(value: string){
    this.selectedCity = this.capitalizeFirstLetter(value);
    this._locationService.updateCurrentLocation(value);
    this._locationService.updatePickLocationChange(false);
  }

  ngOnInit(): void {
  }

}
