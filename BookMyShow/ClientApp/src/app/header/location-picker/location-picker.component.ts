import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-location-picker',
  templateUrl: './location-picker.component.html',
  styleUrls: ['./location-picker.component.sass']
})
export class LocationPickerComponent implements OnInit {

  @Input() cityName: string;

  @Output() toggleLocationPicker: EventEmitter<any> = new EventEmitter();
  @Output() citySelector: EventEmitter<any> = new EventEmitter();
  
  selectedCity: string = null
  viewCities: boolean = false 

  locations: Location[] = [];

  constructor(private router: Router, http: HttpClient) {
    let baseUrl: string = 'https://localhost:44352/';

    http.get<Location[]>(baseUrl + 'api/location').subscribe(result => {
      this.locations = result;
    }, error => console.error(error));
  }

  toggleViewCities(){
    this.viewCities = !this.viewCities
  }

  isSelected(value: string){
    this.selectedCity = value
    this.router.navigate(['explore', value, 'movies']);
    this.citySelector.emit(this.selectedCity)
  }

  isChecked(value: string){
    if(this.selectedCity == value) return true;
    else return false;
  }

  ngOnInit(): void {
    this.selectedCity = this.cityName
  }

}

interface Location {
  id: BigInteger;
  name: string;
  stateID: BigInteger;
  typeID: BigInteger;
}