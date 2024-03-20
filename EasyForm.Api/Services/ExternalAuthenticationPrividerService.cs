using EasyForm.Api.Service.Abstraction;
using EasyForm.Domain.Const;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Microsoft.Extensions.Logging;

namespace EasyForm.Api.Service;

public class ExternalAuthenticationPrividerService : IExternalAuthenticationProviderService
{
    private readonly IConfiguration _configuration;

    public ExternalAuthenticationPrividerService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    #region Public Methods

    public async Task<bool> IsValidIdTokenAsync(string idp, string idToken)
    {
        var isValid = false;

        switch (idp)
        {
            case nameof(AuthenticationProvider.Google):
                isValid = await isValidGoogleIdTokenAsync(idToken);
                break;
            default:
                break;
        }

        return isValid;
    }

    #endregion

    #region Private Methods

    private async Task<bool> isValidGoogleIdTokenAsync(string idToken)
    {
        try
        {
            var validationSettings = new GoogleJsonWebSignature.ValidationSettings
            {
                Audience = new string[] { _configuration["Authentication:Google:ClientId"] ?? "" },
            };
            var payload = await GoogleJsonWebSignature.ValidateAsync(idToken, validationSettings);

            if (payload != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (System.Exception ex)
        {
            return false;
        }
    }

    #endregion
}