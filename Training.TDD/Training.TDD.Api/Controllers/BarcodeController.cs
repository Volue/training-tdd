using Microsoft.AspNetCore.Mvc;
using Training.TDD.Api.Model;

namespace Training.TDD.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BarcodeController : ControllerBase
{
    [HttpPost("scan")]
    public TotalValueResponse Get(IEnumerable<string> barcodes)
    {
        throw new NotImplementedException();
    }
}