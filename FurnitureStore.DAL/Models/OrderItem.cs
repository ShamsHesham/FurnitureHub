using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.DAL.Models
{
    public class OrderItem
    {
        public int Id { get; set; }


        [ForeignKey("Order")]
        public int OrderID { get; set; }

        [ForeignKey("Product")]
        public int ProductItemID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
