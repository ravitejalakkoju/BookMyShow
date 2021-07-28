import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: Location[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Location[]>(baseUrl + 'api/location').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }
}

interface Location {
  id: BigInteger;
  name: string;
  stateID: BigInteger;
  typeID: BigInteger;
}
