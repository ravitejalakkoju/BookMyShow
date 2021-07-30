import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerAuthFormComponent } from './customer-auth-form/customer-auth-form.component';
import { CustomerBookingDetailsComponent } from './customer-booking-details/customer-booking-details.component';
import { CustomerBookingsComponent } from './customer-bookings/customer-bookings.component';
import { CustomerProfileFormComponent } from './customer-profile-form/customer-profile-form.component';
import { CustomerProfileComponent } from './customer-profile/customer-profile.component';

const routes: Routes = [
  {path: '', redirectTo: 'login', pathMatch: 'full'},
  {path: 'login', component: CustomerAuthFormComponent},
  {path: 'signup', component: CustomerAuthFormComponent},
  {path: ':id', component: CustomerProfileComponent, children: [
    {path: '', redirectTo: 'profile'},
    {path: 'bookings', component: CustomerBookingsComponent, children: [
      {path: ':bookingId', component: CustomerBookingDetailsComponent}
    ]},
    {path: 'profile', component: CustomerProfileFormComponent}  
  ]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CustomerRoutingModule { }
