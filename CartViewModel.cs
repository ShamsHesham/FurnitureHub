namespace FurnitureStore.PL.ViewModels
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public ICollection<CartItem> Items { get; set; }
        public decimal Price { get; set; }
        public decimal ShippingPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
