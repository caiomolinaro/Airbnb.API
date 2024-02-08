using Airbnb.API.DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Airbnb.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private UserManager<ApplicationUser> userManager;
    private SignInManager<ApplicationUser> signInManager;

    public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        this.userManager = userManager;
        this.signInManager = signInManager;
    }

    [HttpPost]
    public async Task<IActionResult> Post(User user)
    {
        ApplicationUser appUser = new ApplicationUser
        {
            UserName = user.Name,
            Email = user.Email
        };

        IdentityResult result = await userManager.CreateAsync(appUser, user.Password!);
        if (result.Succeeded)
        {
            return Ok();
        }
        else
        {
            return Problem();
        }
    }
}