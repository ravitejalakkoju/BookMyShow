import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { LocationService } from '../../services/location.service';

import { ILocation } from '../../Interfaces/ILocation';

@Component({
  selector: 'app-location-picker',
  templateUrl: './location-picker.component.html',
  styleUrls: ['./location-picker.component.sass']
})
export class LocationPickerComponent implements OnInit {

  @Input() cityDetails: ILocation;

  @Output() toggleLocationPicker: EventEmitter<any> = new EventEmitter();
  @Output() citySelector: EventEmitter<any> = new EventEmitter();

  selectedCity: ILocation;
  viewCities: boolean = false

  locations: ILocation[] = [];
  locationSearch: ILocation[] = [];

  constructor(private router: Router, private locationService: LocationService) {
  }

  toggleViewCities() {
    this.viewCities = !this.viewCities
  }

  isSelected(id: number, name: string) {
    this.selectedCity = { id: id, name: name };
    this.router.navigate(['explore', name.toLowerCase(), 'movies']);
    this.citySelector.emit(this.selectedCity)
  }

  ngOnInit(): void {
    this.selectedCity = this.cityDetails;
    this.getLocations();
  }

  getLocations() {
    this.locationService.getLocations().subscribe(result => {
      this.locations = result;
    }, error => console.error(error));;
  }

  searchLocation(inputStr: any) {
    this.locationSearch = [];
    this.locations.forEach(l => {
      if (l.name.includes(inputStr.value)) {
        this.locationSearch.push(l);
      }
    })
  }
}


