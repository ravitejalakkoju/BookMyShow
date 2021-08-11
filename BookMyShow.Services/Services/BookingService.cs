using System;
using System.Collections.Generic;
using BookMyShow.DBModels;
using BookMyShow.Models.User.Customer;
using AutoMapper;
using BookMyShow.Services.Interfaces;

namespace BookMyShow.Services
{
    public class BookingService: IBookingService
    {
        private readonly DBContext _context;
        private readonly IMapper _mapper;

        public BookingService(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public BookingByCustomerDTO Get(int bookingId)
        {
            return _mapper.Map<BookingByCustomerDTO>(_context.SingleOrDefault<BookingByCustomer>(bookingId));
        }

        public IEnumerable<BookingByCustomerDTO> GetAllByCustomer(int customerId)
        {
            PetaPoco.NetCore.Sql query = PetaPoco.NetCore.Sql.Builder
                                        .Select("*")
                                        .From("BookingByCustomer")
                                        .Where("CustomerID = @0", customerId);

            return _mapper.Map<IEnumerable<BookingByCustomerDTO>>(_context.Query<BookingByCustomer>(query));
        }

        public Object Create(BookingDTO bookingDto)
        {
            Booking booking = _mapper.Map<Booking>(bookingDto);

            return _context.Insert("Booking", "ID", true, booking);
        }
    }
}
