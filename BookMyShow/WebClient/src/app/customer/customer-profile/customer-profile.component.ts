import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CustomersService } from '../../services/customers.service';

@Component({
  selector: 'app-customer-profile',
  templateUrl: './customer-profile.component.html',
  styleUrls: ['./customer-profile.component.sass']
})
export class CustomerProfileComponent implements OnInit {

  customerProfile: string;

  constructor(private customerService: CustomersService,
    private route: ActivatedRoute) {
    let customerId = parseInt(this.route.snapshot.paramMap.get("id"));
    this.customerService.getCustomerDetails(customerId).subscribe(result => {
      this.customerProfile = result.displayPicture;
    }, error => console.error(error))
  }

  ngOnInit(): void {
  }

}
