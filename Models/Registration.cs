using System.ComponentModel.DataAnnotations;

namespace SimpleLoginRegistration.Models {
    public class RegistrationModel {

        [Required(ErrorMessage = "First name is required.")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters.")]
        [Display(Name = "First Name:")] 
        public string FirstName {get;set;}

        [Required(ErrorMessage = "Last name is required.")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters.")]
        [Display(Name = "Last Name:")] 
        public string LastName {get;set;}

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Please submit a valid email address.")]
        [Display(Name = "Email Address:")] 
        public string Email { get; set; }

        [Required(ErrorMessage = "Password field is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")] 
        public string Password { get; set; }

        [Required(ErrorMessage = "The confirm password field is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        [DataType(DataType.Password)]
        [Compare("Password",  ErrorMessage = "The password fields do not match.")]
        [Display(Name = "Confirm Password:")] 
        public string ConfirmPassword { get; set; }
    }
}