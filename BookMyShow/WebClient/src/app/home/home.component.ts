import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LocationService } from '../services/location.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})
export class HomeComponent implements OnInit {

  constructor(private _router: Router,
    private _locationService: LocationService) {
   }

  ngOnInit(): void {
    if(this._locationService.currentLocation == null){ 
      this._locationService.updatePickLocationChange(true);
    }
    if (this._locationService.currentLocation) this._router.navigate(['explore/' + this._locationService.currentLocation.name.toLowerCase() + '/movies']);
  }

  goToMovies() {
    if (this._locationService.currentLocation == null) {
      this._locationService.updatePickLocationChange(true);
    }
  }

}
