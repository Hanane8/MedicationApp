using MedicationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicationApp.ViewModels
{
    public class CheckoutViewModel
    {
        public Order CurrentOrder { get; set; }

        public CheckoutViewModel()
        {
            CurrentOrder = new Order
            {
                OrderedMedications = new List<OrderItem>()
            };
        }

        public void AddMedicationToOrder(string name, int quantity, decimal unitPrice)
        {
            var item = new OrderItem
            {
                MedicationName = name,
                Quantity = quantity,
                UnitPrice = unitPrice
            };
            CurrentOrder.OrderedMedications.Add(item);
            UpdateTotalAmount();
        }

        private void UpdateTotalAmount()
        {
            CurrentOrder.TotalAmount = CurrentOrder.OrderedMedications.Sum(item => item.TotalPrice);
        }
    }
}
