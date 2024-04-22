using Microsoft.AspNetCore.Mvc;
using ShortLinks_Final.Data;

namespace CXEngine;

[ApiController]
[Route("api/[controller]")]
public class UserController
{
    private readonly DataContext _context;
    private readonly ITokenService _tokenService;
    public UserController(DataContext context, ITokenService tokenService)
    {
        _context = context;
        _tokenService = tokenService;
    }


}
