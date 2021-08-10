import { Component, OnInit } from '@angular/core';

import { LocationService } from '../services/location.service';
import { ILocation } from '../Interfaces/ILocation';
import { ICustomer } from '../Interfaces/ICustomer';
import { CustomersService } from '../services/customers.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.sass']
})
export class HeaderComponent implements OnInit {

  isExpanded: boolean = false;

  selectedCity: ILocation = { id: -1, name: "Select City" };

  locationPicker: boolean;
  locationPickerSubscription: any;

  loggedCustomer: ICustomer = this.customerService.currentCustomer;
  loggedCustomerSubscription: any;

  options: boolean = false;

  constructor(private locationService: LocationService, private customerService: CustomersService) {
    this.locationPicker = this.locationService.pickLocation;
    this.locationPickerSubscription = this.locationService.pickLocationChange.subscribe(value => {
        this.locationPicker = value
    })
    this.loggedCustomerSubscription = this.customerService.currentCustomerChange.subscribe(value => {
      this.loggedCustomer = value
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
    this.locationService.updatePickLocationChange(this.locationPicker);
  }

  toggleOptions(){
    this.options = !this.options;
  }

  capitalizeFirstLetter(str: string) {
    return str.charAt(0).toUpperCase() + str.slice(1);
  }

  selectCity(value: ILocation) {
    this.selectedCity = value;
    this.locationService.updateCurrentLocation(value);
    this.locationService.updatePickLocationChange(false);
  }

  ngOnInit(): void {}

}

