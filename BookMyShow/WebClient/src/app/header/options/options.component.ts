import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { ICustomer } from '../../Interfaces/ICustomer';
import { CustomersService } from '../../services/customers.service';

@Component({
  selector: 'app-options',
  templateUrl: './options.component.html',
  styleUrls: ['./options.component.sass']
})
export class OptionsComponent implements OnInit {

  @Output() toggleOptions: EventEmitter<any> = new EventEmitter();
  
  hasLogged: boolean = false;

  currentCustomer: ICustomer;

  constructor(private customerService: CustomersService) {
    this.currentCustomer = this.customerService.currentCustomer;
    this.customerService.currentCustomerChange.subscribe(value => {
      this.currentCustomer = value;
    })
  }

  logout($event) {
    this.customerService.updateCurrentCustomer(null);
    this.toggleOptions.emit($event);
  }

  ngOnInit(): void {
    if (this.currentCustomer) this.hasLogged = true;
    else this.hasLogged = false;
  }

}
