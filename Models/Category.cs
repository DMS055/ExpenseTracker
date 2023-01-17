using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerDOTNET.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "navchar(50)")]
        public string Title { get; set; }

        [Column(TypeName = "navchar(5)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "navchar(10)")]
        public string Type { get; set; } = "Expense";
    }
}
