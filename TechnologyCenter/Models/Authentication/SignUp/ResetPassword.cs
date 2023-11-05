using System.ComponentModel.DataAnnotations;

namespace TechnologyCenter.Web.Models.Authentication.SignUp
{
    public class ResetPassword
    {
        [Required(ErrorMessage = "enter the new password")]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "The Password and Confirmation Password dont Match. ")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        public string? Eamil { get; set; }
        public string? Token { get; set; }


    }
}
