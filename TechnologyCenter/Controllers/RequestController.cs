using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechnologyCenter.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
       private readonly REMVC3Context _context;

        public RequestController(REMVC3Context context)
        {
            _context = context;
        }

        [HttpGet("GetRequestbyId")]
        public async Task<IActionResult> Getrequest(int id)
        {
            var requst= await _context.Requests.SingleOrDefaultAsync(x=>x.Id==id);
            if (requst==null) 
                return NotFound("User Not Found");
            
            return Ok(requst);
        }

        [HttpGet("GetUserbyId")]
        public async Task<IActionResult> GetUser(string id)
        {
            var user = await _context.Users
               
                .SingleOrDefaultAsync(x => x.Id == id);

            if (user == null)
                return NotFound("User Not Found");

            return Ok(user);
        }


        [HttpGet("GetAddressandnamebyId")]
        public async Task<IActionResult> GetAddress(int id)
        {
            var user = await _context.Addresses
                
                .SingleOrDefaultAsync(x => x.Id == id);

            if (user == null)
                return NotFound("User Not Found");

            return Ok(user);
        }


    }
}
