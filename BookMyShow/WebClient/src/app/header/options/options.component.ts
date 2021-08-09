import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { CustomersService } from '../../services/customers.service';

@Component({
  selector: 'app-options',
  templateUrl: './options.component.html',
  styleUrls: ['./options.component.sass']
})
export class OptionsComponent implements OnInit {

  @Output() toggleOptions: EventEmitter<any> = new EventEmitter();
  
  hasLogged: boolean = false;
  action: string = (this.hasLogged ? "LogOut" : "LogIn");

  currentCustomer: number = this.customerService.currentCustomerId;

  constructor(private customerService: CustomersService) { }

  ngOnInit(): void {
  }

}
