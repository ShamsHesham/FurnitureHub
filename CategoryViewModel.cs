using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace FurnitureStore.PL.ViewModels
{
    public class CategoryViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile ImageFile { get; set; } // Add this property for image upload
        [ValidateNever]
        public string Image { get; set; } // If you need to store image path, keep this property
        public DateTime DateofCreation { get; set; } = DateTime.Now;
    }
}
