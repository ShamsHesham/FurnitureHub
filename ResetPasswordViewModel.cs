using System.ComponentModel.DataAnnotations;

namespace FurnitureStore.PL.ViewModels
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Password Is Required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm Password Is Required")]
        [Compare("NewPassword", ErrorMessage = "Confirm Password does not match Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }



       
    }
}
