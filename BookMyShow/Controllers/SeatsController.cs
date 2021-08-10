using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Models.DTO;
using BookMyShow.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatsController : ControllerBase
    {
        private readonly SeatService _seatService;

        public SeatsController(SeatService seatService)
        {
            _seatService = seatService;
        }

        [HttpGet("{screenId:int}")]
        public IEnumerable<SeatDTO> Get(int screenId)
        {
            return _seatService.GetSeatsInScreen(screenId);
        }

        [HttpGet]
        public IEnumerable<SeatsInScreenDTO> GetSeatCountPerScreen()
        {
            return _seatService.GetSeatCountPerScreen();
        }
    }
}
