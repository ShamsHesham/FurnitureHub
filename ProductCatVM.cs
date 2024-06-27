namespace FurnitureStore.PL.ViewModels
{
    public class ProductCatVM
    {
        public IEnumerable<Category> categories { get; set; }
        public IEnumerable<Product> products { get; set; }

        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

        public List<int> SelectedCategories { get; set; }
        public int CartItemCount { get; set; }
    }
}