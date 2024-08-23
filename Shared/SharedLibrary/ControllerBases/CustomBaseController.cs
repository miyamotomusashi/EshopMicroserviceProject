using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Dtos;

namespace SharedLibrary.ControllerBases
{
  public class CustomBaseController : ControllerBase
  {
    public IActionResult CreateActionResultInstance<T>(ResponseDto<T> response)
    {
      return new ObjectResult(response)
      {
        StatusCode = response.StatusCode


      };

    }
  }
}
