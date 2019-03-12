using System.ComponentModel.DataAnnotations;

namespace SimpleLoginRegistration.Models {
    public class LoginModel {

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Please submit a valid email address.")]
        [Display(Name = "Email Address:")] 
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = "Password field is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")] 
        public string LoginPassword { get; set; }
    }
}