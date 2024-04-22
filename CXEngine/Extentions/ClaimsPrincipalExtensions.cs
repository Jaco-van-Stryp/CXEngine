namespace CXEngine;
using System.Security.Claims;

public static class ClaimsPrincipalExtensions
{
    public static string GetUsername(this ClaimsPrincipal User)
    {
        return User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    }
}
