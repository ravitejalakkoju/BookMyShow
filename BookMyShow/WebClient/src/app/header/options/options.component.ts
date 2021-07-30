import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-options',
  templateUrl: './options.component.html',
  styleUrls: ['./options.component.sass']
})
export class OptionsComponent implements OnInit {

  @Output() toggleOptions: EventEmitter<any> = new EventEmitter();
  
  lock: boolean = true;
  hasLogged: boolean = false;
  action: string = (this.hasLogged ? "LogOut" : "LogIn");

  constructor() { }

  ngOnInit(): void {
  }

}
