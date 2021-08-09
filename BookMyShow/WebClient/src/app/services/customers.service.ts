import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { of } from 'rxjs';
import { ICustomer } from '../Interfaces/ICustomer';

@Injectable({
  providedIn: 'root'
})
export class CustomersService {
  currentCustomerId: number = 2;

  updateCustomerId(id: number) {
    this.currentCustomerId = id;
  }

  getCustomerDetails(customerID: number) {
    return this.http.get<ICustomer>('https://localhost:44352/api/customers/' + customerID);
  }

  createCustomer(customer: ICustomer) {
  }

  updateCustomer(customer: ICustomer) {
    return this.http.put<ICustomer>('https://localhost:44352/api/customers/' + customer.id, customer);
  }

  constructor(private http: HttpClient) { }
}
