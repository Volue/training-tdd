using Microsoft.AspNetCore.Mvc;
using Training.TDD.Api.Model;

namespace Training.TDD.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SignInController : ControllerBase
{
    [HttpGet("validate-password")]
    public ValidationResponse Get(string password)
    {
        throw new NotImplementedException();
    }
}