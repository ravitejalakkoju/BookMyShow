import { Injectable } from '@angular/core';

import { Observable, of, Subject} from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Locator } from 'protractor';

@Injectable({
  providedIn: 'root'
})

export class LocationService {

  currentLocation: Location = null;
  currentLocationChange: Subject<Location> = new Subject<Location>();

  pickLocation: boolean = false;
  pickLocationChange: Subject<boolean> = new Subject<boolean>();

  constructor(private http: HttpClient) { }

  updateCurrentLocation(location: Location) {
    this.currentLocation = location;
    this.currentLocationChange.next(this.currentLocation);
  }

  updatePickLocationChange(choice: boolean){
    this.pickLocation = choice;
    this.pickLocationChange.next(this.pickLocation);
  }

  getLocations() {
    return this.http.get<Location[]>('https://localhost:44352/' + 'api/locations');
  }

}

interface Location {
  id: number;
  name: string;
}
