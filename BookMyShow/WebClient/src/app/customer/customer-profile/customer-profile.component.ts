import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ICustomer } from '../../Interfaces/ICustomer';
import { CustomersService } from '../../services/customers.service';

@Component({
  selector: 'app-customer-profile',
  templateUrl: './customer-profile.component.html',
  styleUrls: ['./customer-profile.component.sass']
})
export class CustomerProfileComponent implements OnInit {

  customerProfile: ICustomer = this.customerService.currentCustomer;;

  constructor(private customerService: CustomersService,
    private route: ActivatedRoute,
    private router: Router) {
    /* let customerId = parseInt(this.route.snapshot.paramMap.get("id"));
    this.customerService.getCustomerDetails(customerId).subscribe(result => {
      this.customerProfile = result.displayPicture;
    }, error => console.error(error)) */
    this.customerService.currentCustomerChange.subscribe(value => {
      this.customerProfile = value;
    })
  }

  ngOnInit(): void {
    if (this.customerProfile == null) {
      alert("Login is required");
      this.router.navigate(['user/customer/login']);
    }
  }

}
