import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-customer-auth-form',
  templateUrl: './customer-auth-form.component.html',
  styleUrls: ['./customer-auth-form.component.sass']
})
export class CustomerAuthFormComponent implements OnInit {

  hasAccount: boolean;

  constructor(private router: Router) { 
    if(this.router.url.includes("login")) this.hasAccount = true
    else if(this.router.url.includes("signup")) this.hasAccount = false
  }

  ngOnInit(): void {
  }

  getAction(){
    if(this.hasAccount) return "LogIn"
    else return "SignUp"
  }
}


