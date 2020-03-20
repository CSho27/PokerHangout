using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PokerHangout.Data
{
    public class PokerHangoutContext : DbContext
    {
        public PokerHangoutContext (DbContextOptions<PokerHangoutContext> options)
            : base(options)
        {
        }
    }
}
