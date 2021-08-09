import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CustomerRoutingModule } from './customer-routing.module';
import { CustomerProfileComponent } from './customer-profile/customer-profile.component';
import { CustomerAuthFormComponent } from './customer-auth-form/customer-auth-form.component';
import { CustomerBookingsComponent } from './customer-bookings/customer-bookings.component';
import { CustomerBookingDetailsComponent } from './customer-booking-details/customer-booking-details.component';
import { CustomerProfileFormComponent } from './customer-profile-form/customer-profile-form.component';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    CustomerProfileComponent,
    CustomerAuthFormComponent,
    CustomerBookingsComponent,
    CustomerBookingDetailsComponent,
    CustomerProfileFormComponent
  ],
  imports: [
    CommonModule,
    CustomerRoutingModule,
    ReactiveFormsModule
  ],
  exports: [
    CustomerProfileComponent
  ]
})
export class CustomerModule { }
