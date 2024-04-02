namespace PracticeProj.Models
{
    public enum Category
    {
        Food,
        Entertainment,
        Bills,
        Payments
    }
    public class Expenses
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Category Category { get; set; }
        
    }
}
