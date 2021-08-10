import { Icu } from '@angular/compiler/src/i18n/i18n_ast';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ICustomer } from '../../Interfaces/ICustomer';
import { CustomerFormValidatorService } from '../../services/customer-form-validator.service';
import { CustomersService } from '../../services/customers.service';

@Component({
  selector: 'app-customer-auth-form',
  templateUrl: './customer-auth-form.component.html',
  styleUrls: ['./customer-auth-form.component.sass']
})
export class CustomerAuthFormComponent implements OnInit {

  hasAccount: boolean;
  submit: boolean = false;

  authForm = this.fb.group({
    'id': ['0', Validators.required],
    'firstName': ['', Validators.required],
    'lastName': [''],
    'email': ['', [Validators.required, this.formValidator.patternValidator(/[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}/)]],
    'password': ['', Validators.required],
    'displayPicture': [null],
    'status': ['0', Validators.required],
    'creationDate': ['2021-08-08T00:00:00Z']
  })

  constructor(private router: Router,
    private fb: FormBuilder,
    private formValidator: CustomerFormValidatorService,
    private customerService: CustomersService) {
    if(this.router.url.includes("login")) this.hasAccount = true
    else if(this.router.url.includes("signup")) this.hasAccount = false
  }

  ngOnInit(): void {
    this.submit = false;
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
    this.submit = true;
    if (!this.hasAccount) {
      if (this.authForm.valid) {
        this.customerService.createCustomer(customer as ICustomer).subscribe(result => {
          if (result) alert(result);
          else this.router.navigate(['user/customer/login']);
        }, error => console.error(error));
      }
    } else {
      this.authForm.patchValue({
        firstName: "none"
      });
      if (this.authForm.valid) {
        let customer: ICustomer;
        this.customerService.loginCustomer(this.authForm.value['email'], this.authForm.value['password']).subscribe(result => {
          customer = result;
          if (customer) {
            this.customerService.updateCurrentCustomer(result);
            this.router.navigate(['user/customer/' + customer.id]);
          } else {
            alert("Incorrect UserName or Password");
          }
        }, error =>  console.error(error));
      }
    }
        
  }
}


