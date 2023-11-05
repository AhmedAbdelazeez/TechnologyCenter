using System.ComponentModel.DataAnnotations;

namespace TechnologyCenter.Web.Models.Authentication.SignUp
{
    public class RegisterUser
    {
       

        [Required(ErrorMessage = " Full Arabic Name Is Required")]

        public string? ArabicFullName { get; set; }

        [Required(ErrorMessage = "Email  Is Required")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        public string? Password { get; set; }

        [Compare("Password",ErrorMessage ="Password And Confirm Password Not Matshing")]
        public string? ConfirmPassword { get; set; }

    }
}
