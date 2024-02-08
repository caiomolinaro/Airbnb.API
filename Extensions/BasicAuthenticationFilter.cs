using Airbnb.API.DataModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Server.HttpSys;
using System.Net.Http.Headers;
using System.Text;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Airbnb.API.Extensions;

public class BasicAuthenticationFilter : IAuthorizationFilter
{
    private readonly string authRealm;
    private UserManager<ApplicationUser> userManager;
    private SignInManager<ApplicationUser> signInManager;

    public BasicAuthenticationFilter(string realm, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        this.authRealm = realm;
        this.userManager = userManager;
        this.signInManager = signInManager;

        if (string.IsNullOrWhiteSpace(authRealm))
        {
            throw new ArgumentNullException(nameof(realm), @"Please provide a non-empty realm value.");
        }
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        try
        {
            string authHeader = context.HttpContext.Request.Headers["Authorization"]!;
            if (authHeader != null)
            {
                var authHeaderValue = AuthenticationHeaderValue.Parse(authHeader);
                if (authHeaderValue.Scheme.Equals(AuthenticationSchemes.Basic.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    var credentials = Encoding.UTF8
                                        .GetString(Convert.FromBase64String(authHeaderValue.Parameter ?? string.Empty))
                                        .Split(':', 2);
                    if (credentials.Length == 2)
                    {
                        var isAuthorized = IsAuthorized(context, credentials[0], credentials[1]);
                        if (isAuthorized.Result)
                        {
                            return;
                        }
                    }
                }
            }

            ReturnUnauthorizedResult(context);
        }
        catch (FormatException)
        {
            ReturnUnauthorizedResult(context);
        }
    }

    public async Task<bool> IsAuthorized(AuthorizationFilterContext context, string username, string password)
    {
        ApplicationUser appUser = await userManager.FindByNameAsync(username);
        if (appUser != null)
        {
            SignInResult result = await signInManager.PasswordSignInAsync(appUser, password, false, false);
            if (result.Succeeded)
            {
                return true;
            }
        }
        return false;
    }

    private void ReturnUnauthorizedResult(AuthorizationFilterContext context)
    {
        // Return 401 and a basic auth challenge (this will cause browser to show login dialog)
        context.HttpContext.Response.Headers["WWW-Authenticate"] = $"Basic realm=\"{authRealm}\"";
        context.Result = new UnauthorizedResult();
    }
}