using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_NET_INMN2_hybryda__PA1_Z1.Models;

namespace ASP_NET_INMN2_hybryda__PA1_Z1.Data
{
    public class PA1_Z1_Context : DbContext
    {
        public PA1_Z1_Context (DbContextOptions<PA1_Z1_Context> options)
            : base(options)
        {
        }

        public DbSet<ASP_NET_INMN2_hybryda__PA1_Z1.Models.Miasto> Miasta { get; set; } = default!;
    }
}
