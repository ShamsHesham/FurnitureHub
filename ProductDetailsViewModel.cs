namespace FurnitureStore.PL.ViewModels
{
    public class ProductDetailsViewModel
    {
        
            public Category category { get; set; }
            public Product product { get; set; }

            public int Quantity { get; set; }
            public int CartItemCount { get; set; }

    }
}
