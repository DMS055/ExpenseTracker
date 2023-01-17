using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerDOTNET.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int Amount { get; set; }

        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
