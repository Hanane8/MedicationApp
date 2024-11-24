using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicationApp.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public string MedicationName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Totalt pris för detta läkemedel (UnitPrice * Quantity)
        public decimal TotalPrice => UnitPrice * Quantity;
    }
}
