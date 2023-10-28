using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_NET_INMN2_hybryda__PA1_Z1.Data;
using ASP_NET_INMN2_hybryda__PA1_Z1.Models;

namespace ASP_NET_INMN2_hybryda__PA1_Z1.Pages.Miasta
{
    public class IndexModel : PageModel
    {
        private readonly ASP_NET_INMN2_hybryda__PA1_Z1.Data.PA1_Z1_Context _context;

        public IndexModel(ASP_NET_INMN2_hybryda__PA1_Z1.Data.PA1_Z1_Context context)
        {
            _context = context;
        }

        public IList<Miasto> Miasta { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Miasta != null)
            {
                Miasta = await _context.Miasta.ToListAsync();
            }
        }
    }
}
