using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lup_Mara_Lab2.Data;
using Lup_Mara_Lab2.Models;

namespace Lup_Mara_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Lup_Mara_Lab2.Data.Lup_Mara_Lab2Context _context;

        public IndexModel(Lup_Mara_Lab2.Data.Lup_Mara_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
