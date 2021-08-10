import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IScreen } from '../Interfaces/IScreen';
import { ISeat } from '../Interfaces/ISeat';

@Injectable({
  providedIn: 'root'
})
export class ScreensService {

  constructor(private http: HttpClient) { }

  GetScreen(id: number) {
    return this.http.get<IScreen>('https://localhost:44352/api/screens/' + id);
  }

}
