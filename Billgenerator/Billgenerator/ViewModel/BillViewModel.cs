using Billgenerator.Models;

namespace Billgenerator.ViewModel
{
    public class BillViewModel
    {
        public int CustmoerId { get; set; }
        public string CustomerName { get; set; }
        public PaymentType PaymentType { get; set; }
        public int ItemId { get; set; }

        public string ItemName { get; set;}
        public decimal ItemPrice { get; set; }
        public int Quantity { get; set; }
        public int DiscountPercentage { get; set; }
        public decimal GrandTotal { get; set; } 

         

      
    }
}
