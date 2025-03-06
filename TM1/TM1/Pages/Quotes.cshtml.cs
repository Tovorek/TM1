using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskManagementSystem.Services;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Pages
{
    public class QuotesModel : PageModel
    {
        private readonly QuoteService _quoteService;

        public QuotesModel(QuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        public List<Quote> Quotes { get; set; }

        public void OnGet()
        {
            Quotes = _quoteService.GetAllQuotes();
        }
    }
}