## Book My Show Application Clone

This project is an Angular and .NET Core based application that allows customers to buy tickets for movies. Some of the features of the application include selecting theatres based on location, checking availability of seats, using personal profiles to update information, checking personal booking history, filtering by various criteria, and using various payment portals. The application is deployed using Azure, and uses Git as the code repository.

###### App Features
- Buy tickets for shows
- Login required to purchase tickets
- Select theatres based on location
- Select date and check availability of seats
- Personal profile to update information
- View personal booking history
- Search for required movies
- Filter requirements by date, categories, age, and price
- Use various payment portals

###### App Tech
- Angular (SASS and Bootstrap for styling)
- .NET Core
- SQL Server
- PetaPoco (Micro-ORM)
- Autofac (Dependency Injector)
- Git (Code Repository)
- Azure (Deployment)

###### App Sketch
- NavBar, Sub-NavBar, Recent releases
- Home Page (Best of services ...)
- Movies Page (Based on location(mandatory) ...)
- Search section (search for shows etc...)
- Location Picker Section (Pick or auto-detect location)
- Booking Page (Contains about, booking proceeds, cast details etc...)
- Booking Selection Page (various availability and provisions to book the shows)
- Theatre Seat Selection Page
- Payment page (confirm and block the booking)
- Confirmation Page (Display confirm message and ticket)

###### App Specifications
- Customers can log in or buy tickets without logging in
- Customers search for their movie choice
- Customers select the movie, date, and theatre
- Customers select the screen and show
- Customers are prompted to log in if they haven't already
- Customers are directed to seat selection, where selected seats are blocked
- Customers are redirected to the payment gateway to make the payment
- Bookings are confirmed and customers are redirected to the confirmation page
- Tickets are displayed in booking history
- Customers are notified ahead of time for the show

###### App System Design

The system has two main components: the Book My Show app and the Theatre Web-App, which provides a list of theatres and availability. The BMS app can connect to the Theatre API from any device. The Theatre API needs its own server and database to provide its details. The BMS app contacts the Theatre API to obtain details and sync based on customer selections and bookings. Available seats are requested from the Theatre API and booked using the API's. Tickets are blocked based on the I/O request and blocking. OS scheduling algorithms are used for blocking and unblocking requests.

###### Theatre API Requirements
- List of cities
- Get available seats
- Get show timings
- Block seats
- Unblock seats
- Book seats

###### Database Structure
- Location is independent and identified by ID
  - Location has 0-to-n theatres
- Movie is independent and identified by ID
  - Movie has genres and allows languages
  - Each movie gets 0-to-n screens
- User is independent and identified by ID
  - User can initiate 0-to-n number of bookings
- Theatre is dependent on location and identified by ID
  - Each theatre will have 0-to-n screens
- Screen is dependent on theatre and movie, identified by ID, and has 0-to-n seats
- Seat is dependent on screen and identified by ID and ScreenID, SeatCode
  - Seat has 0-to-n tickets for x number of days
- Ticket is dependent on seat and identified by ID and SeatID, BookingID
  - Each ticket is assigned to 1 seat
- Booking is dependent on user and identified by ID
  - Each booking has 0-to-5 tickets
- Movie_Genre_Mapping and Movie_Language_Mapping maps movies to genres and languages respectively

