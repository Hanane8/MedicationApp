using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicationApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public List<OrderItem> OrderedMedications { get; set; }

        // Kundinformation
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Totalt belopp för beställningen
        public decimal TotalAmount { get; set; }

        // Datum och tid för beställning
        public DateTime OrderDate { get; set; }

        public Order()
        {
            // Initierar listan för att undvika nullreferenser
            OrderedMedications = new List<OrderItem>();
        }
    }

    // En separat klass för individuella mediciner i beställningen
    
}
