using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.DAL.Models
{
    public class CartItem
    {
        public int Id { get; set; }
       
       
        public int Quantity { get; set; }

        [ForeignKey("ProductId")]
        public int ProductItemID { get; set; }
        public Product? ProductItem { get; set; }

        [ForeignKey("CartId")]
        public int CartID { get; set; }
        public Cart? Cart { get; set; }
    }
}
