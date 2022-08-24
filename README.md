# BookMyShow

Book My Show Application:

App Idea: Booking Tickets for Movies

App Features: </br>
•	Customer can Buy Tickets for Shows </br>
•	Customer must login to buy tickets. </br>
•	Customer can select theatres based on location  </br> 
•	Customer can select date and check availability of seats  </br>
•	Customer can use personal profile and can update the details  </br> 
•	Customer can check personal booking history  </br> 
•	 Customer can search for his required movie  </br> 
•	 Customer can filter his requirements (Date, Categories, Age, Price)  </br> 
•	Customer can use various payment portals (namesake)  </br> 

App Tech:  </br> 
•	Angular (SASS and Bootstrap for Styling)  </br>
•	.Net Core  </br>
•	SQL Server  </br>
•	PetaPoco( Micro-ORM ) –  </br>
o	Provides faster data access.  </br>
o	MicroORM’s provide raw speed compared to ORM’s. </br>
•	Autofac( Dependency Injector ) –  </br>
o	Clear documentation, feature rich and larger community. </br>
•	Code Repository – Git </br>
•	Deployment – Azure (Not Sure) </br>
•	NLB – Network Load Balancer (Not Necessary for now) </br>

App Sketch:  </br>
•	NavBar, Sub-NavBar, Recent releases </br>
•	Home Page (Best of services …) </br>
•	Movies Page (Based on location(mandatory) …) </br>
•	Search section (search for shows etc…) </br>
•	Location Picker Section (Pick or auto detect location) </br>
•	Booking Page (Contains about, booking proceeds, cast details etc …) </br>
•	Booking Selection Page (various availability and provisions to book the shows) </br>
•	Theatre Seat Selection Page </br>
•	Payment page (confirm and block the booking) </br>
•	Confirmation Page (Display confirm message and ticket) </br>
  </br>
App Specifications: </br>
•	Customer can either be logged in or not </br>
•	Customer searches for his movie choice </br>
•	Customer selects the movie </br>
•	Customer selects his preferred date </br>
•	Customer selects the theatre </br>
•	Customer selects the screen and show </br>
•	Customer is requested to login if he/she’s not </br>
•	Customer is directed to seat selection (selected seats are blocked) </br>
•	Customer is redirected to Payment Gateway and makes the payment </br>
•	Customer Bookings are confirmed and redirect to confirmation page </br>
•	Customer ticket is now displayed in Booking History </br>
•	Customer will now be notified ahead of time for the show </br>

App System Design: </br>
There will be two main components in the system </br>
1.	Book My Show App  </br>
2.	Theatre Web-App (Serves to provide theatre list and availability) </br>
BMS app can connect to Theatre API from any device </br>
Theatre API needs its own server and database to provide its details (could try web scraping BMS or any  </br>external API) </br>
The App contacts the Theatre API to obtain the details and sync based on the customer selections and  </br>bookings. </br>
We’ll request the available seats from Theatres API and book using the API’s. </br>
We will block the tickets based on the IO Request and blocking. </br>
•	We can follow OS Scheduling Algorithms for the blocking and unblocking requests </br>
 </br>
Theatre API Requirements:  </br>
•	List of cities </br>
•	Get Available Seats </br>
•	Get Show Timings </br>
•	Block Seats </br>
•	Unblock Seats </br>
•	Book Seats </br>
•	Etc. </br>

Database Structure: </br>
Predicate: </br>
•	Location is independent </br>
    o	Location is identified by ID </br>
    o	Location have 0-to-n theatres </br>
•	Movie is independent </br>
    o	Movie is identified by ID </br>
    o	Movie have genres and allows languages </br>
    o	Each movie gets 0-to-n screens </br>
•	User is independent </br>
    o	User is identified by ID </br>
    o	User can initiate 0-to-n number of bookings </br>
•	Theatre is dependent on, Location </br>
    o	Theatre is identified by ID </br>
    o	Each Theatre will have 0-to-n Screens </br>
•	Screen is dependent on, Theatre and Movie </br>
    o	Screen is identified by ID </br>
    o	Each screen gets 1 movie </br>
    o	Each screen have 0-to-n seats </br>
•	Seat is dependent on, Screen </br>
    o	Seat is identified by ID and ScreenID, SeatCode </br>
    o	Seat have 0-to-n tickets for x number of days </br>
•	Ticket is dependent on, Seat </br>
    o	Ticket is identified by ID and SeatID, BookingID </br>
    o	Each Ticket is assigned to 1 Seat </br>
•	Booking is dependent on, User </br>
    o	Booking is identified by ID </br>
    o	Each booking has 0-to-5 tickets </br>
•	Movie_Genre_Mapping  and Movie_Language_Mapping  maps movies to genres and languages respectively </br>

