using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicationApp.Models
{
    public class MedicationData
    {
        public static List<Medication> GetMedications()
        {
            return new List<Medication>
            {
                new Medication { Id = 1, Name = "Alvedon", Description = "Pain relief", Price = 50 },
                new Medication { Id = 2, Name = "Panodil", Description = "Reduces fever", Price = 55 },
                new Medication { Id = 3, Name = "Ibuprofen", Description = "Anti-inflammatory", Price = 70 },
                new Medication { Id = 4, Name = "Diclofenac", Description = "Joint pain relief", Price = 90 },
                new Medication { Id = 5, Name = "Paracetamol", Description = "General pain relief", Price = 60 },
                new Medication { Id = 6, Name = "Voltaren", Description = "Reduces swelling", Price = 85 },
                new Medication { Id = 7, Name = "Aspirin", Description = "Blood thinner", Price = 45 }
            };
        }
    }

}
