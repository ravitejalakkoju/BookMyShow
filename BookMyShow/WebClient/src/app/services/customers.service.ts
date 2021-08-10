import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { of, Subject } from 'rxjs';
import { ICustomer } from '../Interfaces/ICustomer';

@Injectable({
  providedIn: 'root'
})
export class CustomersService {

  currentCustomer: ICustomer = null;
  currentCustomerChange: Subject<ICustomer> = new Subject<ICustomer>();

  updateCurrentCustomer(customer: ICustomer) {
    this.currentCustomer = customer;
    this.currentCustomerChange.next(this.currentCustomer);
  }

  loginCustomer(email: string, password: string) {
    return this.http.get<ICustomer>('https://localhost:44352/api/customers/GetCustomer?email=' + email + '&password=' + password);
  }

  getCustomerDetails(customerID: number) {
    return this.http.get<ICustomer>('https://localhost:44352/api/customers/' + customerID + '?s=id');
  }

  getCustomerDetailsByEmail(email: string) {
    return this.http.get<ICustomer>('https://localhost:44352/api/customers/' + email + '?s=email');
  }

  createCustomer(customer: ICustomer) {
    return this.http.post<ICustomer>('https://localhost:44352/api/customers', customer);
  }

  updateCustomer(customer: ICustomer) {
    return this.http.put<ICustomer>('https://localhost:44352/api/customers/' + customer.id, customer);
  }

  constructor(private http: HttpClient) {
    this.currentCustomerChange.subscribe((value) => {
      this.currentCustomer = value;
    })
  }
}
