using Microsoft.AspNetCore.Mvc;

namespace EasyForm.Api.Controllers;

public class UsersController : ApiBaseController
{
    [HttpGet("/me")]
    public ActionResult Me()
    {
        return Ok();
    }
}