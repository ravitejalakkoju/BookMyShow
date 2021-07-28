using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShowAPI.DBModels;
using PetaPoco.NetCore;
using Microsoft.Extensions.Configuration;
using BookMyShow.Services;

namespace BookMyShowAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheatresController : ControllerBase
    {
        private readonly Database _context;

        public TheatresController(DBContext context)
        {
            _context = context;
        }
        // TheatresList - LocationID
        // Theatre - id
        // TheatreScreens - TheatreID
        // ShowsInTheatre - TheatreID, MovieID
        // SeatPrice - TheatreID, ScreenID
        public IEnumerable<Theatre> GetTheatre(int id)
        {
            //var connection = new System.Data.SqlClient.SqlConnection(this.Configuration.GetConnectionString("BookMyShowConnection"));
            //var dataContext = new Database(connection);
            var theatre = _context.Query<Theatre>("Select * from Theatre where ID = 1");

            return theatre;
        }
    }
}
