import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { ICustomer } from '../../Interfaces/ICustomer';
import { CustomersService } from '../../services/customers.service';
import { CustomerFormValidatorService } from '../../services/customer-form-validator.service';

@Component({
  selector: 'app-customer-profile-form',
  templateUrl: './customer-profile-form.component.html',
  styleUrls: ['./customer-profile-form.component.sass']
})
export class CustomerProfileFormComponent implements OnInit {
  creationDate: any;
  customerForm = this.fb.group({
    'id': ['', Validators.required],
    'firstName': ['', Validators.required],
    'lastName': [''],
    'email': ['', [Validators.required, this.formValidator.patternValidator(/[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}/)]],
    'password': ['', Validators.required],
    'displayPicture': [''],
    'status': ['', Validators.required],
    'creationDate': ['', Validators.required]
  });

  customerId: number;
  submit: boolean = false;

  constructor(private route: ActivatedRoute,
    private customerService: CustomersService,
    private fb: FormBuilder,
    private formValidator: CustomerFormValidatorService) {
    this.route.parent.params.subscribe(
      params => {
        this.customerId = params.id;
        this.customerService.getCustomerDetails(this.customerId).subscribe(result => {
          this.creationDate = result.creationDate;
          this.customerForm.setValue({
            id: result.id,
            firstName: result.firstName,
            lastName: result.lastName,
            email: result.email,
            password: result.password,
            displayPicture: result.displayPicture,
            status: Status[result.status],
            creationDate: new Date(result.creationDate).toUTCString()
          })
        }, error => console.log(error))
      }
    );
  }

  ngOnInit(): void {
    this.submit = false;
  }

  get firstName() {
    return this.customerForm.get('firstName')
  }

  get email() {
    return this.customerForm.get('email')
  }

  get password() {
    return this.customerForm.get('password')
  }

  onSubmit() {
    let customer: any = this.customerForm.value;
    this.submit = true;
    if (this.customerForm.valid) {
      console.log(customer);
      customer['status'] = Status[customer['status']]
      customer['creationDate'] = this.creationDate;
      this.customerService.updateCustomer(customer as ICustomer).subscribe(result => {
        alert("Profile Updated Successfully");
      }, error => console.error(error))
    }
  }

}

enum Status {
  Regular = 0,
  Premium
}
