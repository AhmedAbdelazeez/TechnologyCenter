using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using TechnologyCenter.Web.Models.Authentication.SignUp;

namespace TechnologyCenter.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<AspNetUser> _usermanger;
        private readonly RoleManager<AspNetRole> _rolemanger;
        private SignInManager<AspNetUser> _signinManager;
        private readonly IConfiguration _configuration;
        private readonly IEmailServices _emailService;
        
        public UsersController(UserManager<AspNetUser> usermanger, RoleManager<AspNetRole> rolemanger, 
            SignInManager<AspNetUser> signinManager,
            IConfiguration configuration,
            IEmailServices emailService)
        {
            _usermanger = usermanger;
            _rolemanger = rolemanger;
            _signinManager = signinManager;
            _configuration = configuration;
            _emailService = emailService;
        }


        [HttpPost("Regesteration")]
        public async Task<IActionResult> Register([FromBody] RegisterUser registerUser)
        {
            try
            {
                // Check if the user already exists
                var userExist = await _usermanger.FindByEmailAsync(registerUser.Email);
                if (userExist != null)
                {
                    return StatusCode(StatusCodes.Status403Forbidden,
                        new Response { Status = "Error", Message = "User already exists!" });
                }

                // Create the user in the database
                AspNetUser user = new()
                {
                    ArabicFullName = registerUser.ArabicFullName!,
                    Email = registerUser.Email,
                    SecurityStamp = Guid.NewGuid().ToString(),

                    // UserName = new MailAddress(registerUser.Email!).User,
                    TwoFactorEnabled = true
                };

                var result = await _usermanger.CreateAsync(user, registerUser.Password);
                if (!result.Succeeded)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        new Response { Status = "Error", Message = "Username or password is incorrect" });
                }

                await _usermanger.AddToRoleAsync(user, "User");


                // Add Token to Verify the email....
                var token = await _usermanger.GenerateEmailConfirmationTokenAsync(user);
                var confirmationLink = Url.Action(nameof(ConfirmEmail), "Authentication", new { token, email = user.Email }, Request.Scheme);
                var message = new Message(new string[] { user.Email! }, "Confirmation email link", confirmationLink!);
                _emailService.SendEmail(message);

                return StatusCode(StatusCodes.Status200OK,
                    new Response { Status = "Success", Message = $"User created & Email Sent to {user.Email} Successfully" });
            }
            catch (Exception ex)
            {


                return StatusCode(StatusCodes.Status500InternalServerError,
                    new Response { Status = "Error", Message = "An error occurred during registration: " + ex.Message });
            }
        }

        [HttpGet("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string token, string email)
        {
            var user = await _usermanger.FindByEmailAsync(email);
            if (user != null)
            {
                var result = await _usermanger.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    return StatusCode(StatusCodes.Status200OK,
                      new Response { Status = "Success", Message = "Email Verified Successfully" });
                }
            }
            return StatusCode(StatusCodes.Status500InternalServerError,
                       new Response { Status = "Error", Message = "This User Doesnot exist!" });
        }
    }
}
