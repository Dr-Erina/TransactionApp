using System.ComponentModel;
using System.ComponentModel.DataAnnotations; //for validation requirement


namespace TransactionApp.Models
{
    public class TransactionModel
    {

        //data needed for the transaction

        [Key] // primary key for the transaction
        public Guid Id { get; set; }

        //Reference Number Data Annotation
        [Required(ErrorMessage = "Reference number is required")]
        [StringLength(20, ErrorMessage = "Reference number cannot exceed a maximum of 20")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z0-9]*$", ErrorMessage ="Reference number must be alphanumeric")] //Regex for alphanumeric charactersa
        public string ReferenceNumber { get; set; } = null!;

        //Quantity Data Annotation
        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, long.MaxValue, ErrorMessage="Quantity must be greater than 0")] 
        public long Quantity { get; set; } 

        //Amount Data Annotation
        [Required (ErrorMessage ="Amount is required")]
        [Range(1, 9999999999)] //to ensure that the value is not 0
        public decimal Amount { get; set; }

        //Name Data Annotation
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")] //The maximum length of name is 100
        public string Name { get; set; } = null!;

        //Transaction Data Annotation
        [DisplayName("Transaction Date")]
        [Required (ErrorMessage ="Transaction Date is Required")]
        public DateTime TransactionDate { get; set; }

        //Symbol Data Annotation
        [StringLength(5, MinimumLength = 3, ErrorMessage = "Symbol value must be between 3 and 5 characters.")]
        [RegularExpression(@"^^[a-zA-Z][a-zA-Z0-9]{3,5}$ ", ErrorMessage ="Symbol must be between 3 and 5 characters")]
        public string Symbol { get; set; } = null!;

        //Side Order Data Annotation
        [Required(ErrorMessage = "Order Side is Required")]
        [DisplayName("Order Side")]
        [RegularExpression("^(Buy|Sell)$", ErrorMessage = "Order side must be either 'Buy' or 'Sell' ")] //only should accept buy and sell values
        public string OrderSide { get; set; } = null!; //null forgiving operator

        //Order Status Data Annotation
        [Required (ErrorMessage = "Order Status is Required")]
        [DisplayName("Order Status")]
        [RegularExpression ("^(Open|Matched|Cancelled)$", ErrorMessage =" Order status must be either Open, matched and cancelled")]
        public string OrderStatus { get; set; } = null!;




    }
}
