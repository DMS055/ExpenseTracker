using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerDOTNET.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
    }
}
