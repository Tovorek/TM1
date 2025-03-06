using TaskManagementSystem.Data;
using TaskManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TaskManagementSystem.Services
{
    public class QuoteService
    {
        
        
            private readonly AppDbContext _context;

            public QuoteService(AppDbContext context)
            {
                _context = context;
            }

            public List<Quote> GetAllQuotes()
            {
                return _context.Quotes.ToList();
            }

            public void AddQuote(Quote quote)
            {
                _context.Quotes.Add(quote);
                _context.SaveChanges();
            }
        


    }
}