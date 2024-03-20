using EasyForm.Api.Dto;
using EasyForm.Api.Service.Abstraction;
using EasyForm.Domain.Const;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyForm.Api.Controllers;

[Route("Users")]
public class UsersController : ApiBaseController
{
    private readonly IExternalAuthenticationProviderService _externalAuthenticationProviderService;

    public UsersController(IExternalAuthenticationProviderService externalAuthenticationProviderService)
    {
        _externalAuthenticationProviderService = externalAuthenticationProviderService;
    }

    [AllowAnonymous]
    [HttpPost("Token")]
    public async Task<ActionResult> TokenAsync([FromBody] GetTokenDto request)
    {
        var isValid = await _externalAuthenticationProviderService.IsValidIdTokenAsync(nameof(AuthenticationProvider.Google), request.IdToken);
        return Ok();
    }
}