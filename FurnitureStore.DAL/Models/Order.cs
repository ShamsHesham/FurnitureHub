using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.DAL.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }
        public string?DeliveryAddress { get; set; }
        public decimal TotalPrice { get; set; }

        
        public string CustomerID { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ApplicationUser Customer { get; set; }
        public ICollection<Payment> payment { get; set; }
    }
}
