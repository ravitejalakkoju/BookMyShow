using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco.NetCore;
using System.Data;

namespace BookMyShow.Services
{
    public class DBContext: Database
    {
        public DBContext(IDbConnection connection): base(connection)
        {
        }
    }
}
