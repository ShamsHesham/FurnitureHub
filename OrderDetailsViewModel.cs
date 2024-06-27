using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureStore.PL.ViewModels
{
    public class OrderDetailsViewModel
    {

        //public IEnumerable<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();

        //public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public IEnumerable<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();

        public decimal TotalPrice { get; set; }
        //public int Id { get; set; }


        //public int OrderID { get; set; }

        //public int ProductItemID { get; set; }
        //public int Quantity { get; set; }
        //public decimal Price { get; set; }
    }
}
