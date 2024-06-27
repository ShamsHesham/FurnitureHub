using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.DAL.Models
{
    public class Cart
    {
        public int Id { get; set; }

        [ForeignKey("CustomerId")]
        public string CustomerID { get; set; }

        public ICollection<ShoppingCart>? CartItem { get; set; }

        //public Customers? Customer { get; set; }

       
    }
}
