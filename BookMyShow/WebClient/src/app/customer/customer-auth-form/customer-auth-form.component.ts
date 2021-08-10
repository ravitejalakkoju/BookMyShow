import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CustomerFormValidatorService } from '../../services/customer-form-validator.service';
import { CustomersService } from '../../services/customers.service';

@Component({
  selector: 'app-customer-auth-form',
  templateUrl: './customer-auth-form.component.html',
  styleUrls: ['./customer-auth-form.component.sass']
})
export class CustomerAuthFormComponent implements OnInit {

  hasAccount: boolean;

  authForm = this.fb.group({
    'id': ['', Validators.required],
    'firstName': ['', Validators.required],
    'lastName': [''],
    'email': ['', [Validators.required, this.formValidator.patternValidator(/[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}/)]],
    'password': ['', Validators.required],
    'displayPicture': [''],
    'status': ['0', Validators.required]
  })

  constructor(private router: Router,
    private fb: FormBuilder,
    private formValidator: CustomerFormValidatorService,
    private customerService: CustomersService) {
    if(this.router.url.includes("login")) this.hasAccount = true
    else if(this.router.url.includes("signup")) this.hasAccount = false
  }

  ngOnInit(): void {
  }

  getAction(){
    if(this.hasAccount) return "LogIn"
    else return "SignUp"
  }

  get firstName() {
    return this.authForm.get('firstName')
  }

  get email() {
    return this.authForm.get('email')
  }

  get password() {
    return this.authForm.get('password')
  }

  onSubmit() {
    let customer: any = this.authForm.value;
    /*
     if (!this.hasAccount) {
      customer['status'] = Status[customer['status']]
      this.customerService.createCustomer(customer)
    }
     */
    console.log(customer);
  }
}

enum Status {
  Regular = 0,
  Premium
}


