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
    public class DetailsModel : PageModel
    {
        private readonly RandomQuoteApp.Data.RandomQuoteAppContext _context;

        public DetailsModel(RandomQuoteApp.Data.RandomQuoteAppContext context)
        {
            _context = context;
        }

      public Quote Quote { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Quotes == null)
            {
                return NotFound();
            }

            var quote = await _context.Quotes.FirstOrDefaultAsync(m => m.Id == id);
            if (quote == null)
            {
                return NotFound();
            }
            else 
            {
                Quote = quote;
            }
            return Page();
        }
    }
}
