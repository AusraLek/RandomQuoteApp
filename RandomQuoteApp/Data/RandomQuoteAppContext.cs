using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RandomQuoteApp.Models;

namespace RandomQuoteApp.Data
{
    public class RandomQuoteAppContext : DbContext
    {
        public RandomQuoteAppContext (DbContextOptions<RandomQuoteAppContext> options)
            : base(options)
        {
        }

        public DbSet<RandomQuoteApp.Models.Quote> Quotes { get; set; } = default!;
    }
}
