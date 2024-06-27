using System.Runtime.InteropServices;

namespace FurnitureStore.PL.ViewModels
{
    public class CheckoutViewModel
    {
        
        public IEnumerable<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();

        public decimal TotalPrice { get; set; }

        public int CartItemCount { get; set; }

        public Customers customers { get; set; }

        //public string FirstName { get; set; }

        //public string Email { get; set; }

        public string Address { get; set; }


        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        // Payment information

        public string CardName { get; set; }

        public string CardNumber { get; set; }

        public string ExpMonth { get; set; }

        public string ExpYear { get; set; }
        
    }
}
