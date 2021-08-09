using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;
using BookMyShow.Models.DTO;
using BookMyShow.Services.Repositories.Interfaces;
using AutoMapper;

namespace BookMyShow.Services
{
    public class BookingService
    {
        private readonly ICustomerWrapper _customerWrapper;
        private readonly IMapper _mapper;

        public BookingService(ICustomerWrapper customerWrapper, IMapper mapper)
        {
            _customerWrapper = customerWrapper;
            _mapper = mapper;
        }

        public BookingByCustomerDTO GetBookingDetails(int bookingId)
        {
            return _mapper.Map<BookingByCustomerDTO>(_customerWrapper.BookingRepository.Get(bookingId));
        }

        public IEnumerable<BookingByCustomerDTO> GetBookingsByCustomer(int customerId)
        {
            return _mapper.Map<IEnumerable<BookingByCustomerDTO>>(_customerWrapper.BookingRepository.GetAllByCustomer(customerId));
        }

        public Object CreateBooking(BookingDTO bookingDto)
        {
            return _customerWrapper.BookingRepository.Insert(_mapper.Map<Booking>(bookingDto));
        }
    }
}
