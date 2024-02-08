using Microsoft.AspNetCore.Mvc;

namespace Airbnb.API.Extensions;

public class BasicAuthenticationAttribute : TypeFilterAttribute
{
    public BasicAuthenticationAttribute(string realm = @"MyRealm") : base(typeof(BasicAuthenticationFilter))
    {
        Arguments = new object[] { realm };
    }
}