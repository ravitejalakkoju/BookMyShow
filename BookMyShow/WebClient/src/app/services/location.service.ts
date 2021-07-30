import { Injectable } from '@angular/core';

import { Observable, of, Subject} from 'rxjs';
import { ActivatedRoute } from '@angular/router'

@Injectable({
  providedIn: 'root'
})

export class LocationService {

  currentLocation: string = null;
  currentLocationChange: Subject<string> = new Subject<string>();

  pickLocation: boolean = false;
  pickLocationChange: Subject<boolean> = new Subject<boolean>();

  constructor() { }

  updateCurrentLocation(location: string){
    this.currentLocation = location;
    this.currentLocationChange.next(this.currentLocation);
  }

  updatePickLocationChange(choice: boolean){
    this.pickLocation = choice;
    this.pickLocationChange.next(this.pickLocation);
  }
  
  getLocations(){
    let locations: string[] = ["Amritsar", 'Ghatkeshwar', 'Hyderabad'];
    return locations;
  }
}
