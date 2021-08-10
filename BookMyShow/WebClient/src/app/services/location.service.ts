import { Injectable } from '@angular/core';

import { Observable, of, Subject} from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Locator } from 'protractor';
import { ILocation } from '../Interfaces/ILocation';

@Injectable({
  providedIn: 'root'
})

export class LocationService {

  currentLocation: ILocation = null;
  currentLocationChange: Subject<ILocation> = new Subject<ILocation>();

  pickLocation: boolean = false;
  pickLocationChange: Subject<boolean> = new Subject<boolean>();

  constructor(private http: HttpClient) { }

  updateCurrentLocation(location: ILocation) {
    this.currentLocation = location;
    this.currentLocationChange.next(this.currentLocation);
  }

  updatePickLocationChange(choice: boolean){
    this.pickLocation = choice;
    this.pickLocationChange.next(this.pickLocation);
  }

  getLocations() {
    return this.http.get<ILocation[]>('https://localhost:44352/' + 'api/locations');
  }

}
