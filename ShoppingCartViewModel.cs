namespace FurnitureStore.PL.ViewModels
{
    public class ShoppingCartViewModel
    {
        public  IEnumerable <ShoppingCart> ShoppingCarts { get; set; } 

        public decimal TotalPrice { get; set; }
        public int CartItemCount { get; set; }
    }
}
