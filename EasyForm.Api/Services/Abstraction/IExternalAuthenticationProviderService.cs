namespace EasyForm.Api.Service.Abstraction;

public interface IExternalAuthenticationProviderService
{
    public Task<bool> IsValidIdTokenAsync(string idp, string idToken);
}
