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
    public class TicketService
    {
        private readonly ICustomerWrapper _customerWrapper;
        private readonly IMapper _mapper;

        public TicketService(ICustomerWrapper customerWrapper, IMapper mapper)
        {
            _customerWrapper = customerWrapper;
            _mapper = mapper;
        }

        public void CreateTicket(TicketDTO ticketDTO)
        {
            _customerWrapper.TicketRepository.Insert(_mapper.Map<Ticket>(ticketDTO));
        }
    }
}
