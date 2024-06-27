using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace FurnitureStore.PL.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal  Price { get; set; }
        public DateTime DateofCreation { get; set; } = DateTime.Now;
        [ValidateNever]
        public string ImageURL { get; set; }

        [ValidateNever]
        public IFormFile ImageFile { get; set; }
        [Display(Name = " Select a Category")]
        public int CategoryID { get; set; }
        public List<Category>? CategoryList { get; set; }
    }
}
