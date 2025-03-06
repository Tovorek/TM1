namespace TaskManagementSystem.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string QuoteType { get; set; }
        public string Description { get; set; }
        public string Sales { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Premium { get; set; }
    }
}