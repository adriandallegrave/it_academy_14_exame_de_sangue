using Microsoft.AspNetCore.Mvc;

namespace BloodCheck.Controllers;

[ApiController]
[Route("[controller]")]
public class BloodCheckController : ControllerBase
{

    private readonly ILogger<BloodCheckController> _logger;

    public BloodCheckController(ILogger<BloodCheckController> logger)
    {
        _logger = logger;
    }


}
