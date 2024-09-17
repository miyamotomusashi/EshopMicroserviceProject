using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServiceIdentityServer.Dtos;
using ServiceIdentityServer.Models;
using SharedLibrary.Dtos;
using System.Linq;
using System.Threading.Tasks;
 
namespace ServiceIdentityServer.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase
  {
    private readonly UserManager<ApplicationUser> _userManager;

    [HttpPost]
    public async Task<IActionResult> SignUp(SignUpDTO signupDto)
    {
      var user = new ApplicationUser
      {
        UserName = signupDto.UserName,
        Email = signupDto.Email,
        City = signupDto.City
      };

      var result = await _userManager.CreateAsync(user,signupDto.Password);
      if(!result.Succeeded)
      {
        return BadRequest(ResponseDto<NoContentDto>.Fail(result.Errors.Select(x => x.Description).ToList(),400));
      }

      return NoContent();
    

  }
  }
}
