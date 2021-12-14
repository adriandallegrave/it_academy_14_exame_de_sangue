using Microsoft.AspNetCore.Mvc;
using BloodCheck.Models;
using Microsoft.AspNetCore.Cors;

namespace BloodCheck.Controllers;

[ApiController]
[Route("[controller]")]
[EnableCors("AllowAll")]
public class BloodCheckController : ControllerBase
{
    private readonly ILogger<BloodCheckController> _logger;
    private readonly BloodCheckContext _context;

    public BloodCheckController(ILogger<BloodCheckController> logger, BloodCheckContext context)
    {
        _logger = logger;
        _context = context;
    }
}
