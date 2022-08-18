using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandomQuoteApp.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string? Author { get; set; }
    }
}
