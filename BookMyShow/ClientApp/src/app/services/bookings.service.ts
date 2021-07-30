import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BookingsService {
  
  currentId: number;
  currentIdChange: Subject<number> = new Subject<number>();

  updateCurrentId(value: number){
    this.currentId = value
    this.currentIdChange.next(this.currentId)
  }

  constructor() { }
}
