using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BloodCheck.Models;
using BloodCheck.DTOs;

namespace BloodCheck.Controllers;

[ApiController]
[Route("api/[controller]")]
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