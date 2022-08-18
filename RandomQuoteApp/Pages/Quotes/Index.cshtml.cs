using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RandomQuoteApp.Data;
using RandomQuoteApp.Models;

namespace RandomQuoteApp.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly RandomQuoteApp.Data.RandomQuoteAppContext _context;

        public IndexModel(RandomQuoteApp.Data.RandomQuoteAppContext context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Quote != null)
            {
                Quote = await _context.Quote.ToListAsync();
            }
        }
    }
}
