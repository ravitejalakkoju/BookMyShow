import { IBooking } from '../Interfaces/IBooking';

export interface IBookingByCustomer extends IBooking{
  seats: string,
  screenCode: string,
  theatreName: string,
  showTime: Date,
  movieName: string,
  locationName: string,
  movieAPIID: string
}
