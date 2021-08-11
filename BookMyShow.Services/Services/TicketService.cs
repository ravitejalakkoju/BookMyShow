using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.DBModels;
using BookMyShow.Models.User.Customer;
using BookMyShow.Services.Interfaces;
using AutoMapper;

namespace BookMyShow.Services
{
    public class TicketService: ITicketService
    {
        private readonly DBContext _context;
        private readonly IMapper _mapper;

        public TicketService(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public TicketDTO Get(int ticketId)
        {
            return _mapper.Map<TicketDTO>(_context.SingleOrDefault<Ticket>(ticketId));
        }

        public IEnumerable<TicketDTO> GetAllPerBooking(int bookingId)
        {
            PetaPoco.NetCore.Sql query = PetaPoco.NetCore.Sql.Builder
                                        .Select("*")
                                        .From("Ticket")
                                        .Where("BookingID = @0", bookingId);

            return _mapper.Map <IEnumerable<TicketDTO>>(_context.Query<Ticket>(query));
        }

        public void Create(TicketDTO ticketDTO)
        {
            Ticket ticket = _mapper.Map<Ticket>(ticketDTO);

            _context.Insert("Ticket", "ID", ticket);
        }
    }
}
