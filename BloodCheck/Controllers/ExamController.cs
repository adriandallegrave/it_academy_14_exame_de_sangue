using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using Microsoft.AspNetCore.Cors;
using BloodCheck.Data;
using BloodCheck.DTOs;
using BloodCheck.Models;
using Microsoft.AspNetCore.Cors;

namespace BloodCheck.Controllers;

[ApiController]
[Route("api/[controller]")]
[EnableCors("AllowAll")]
public class ExamController : ControllerBase
{
    private readonly ILogger<ExamController> _logger;
    private readonly IExamRepository _examRepository;

    public ExamController(ILogger<ExamController> logger, IExamRepository examRepository)
    {
        _logger = logger;
        _examRepository =  examRepository;
    }

    // GET api/exam/{id}
    [HttpGet("{id:int}")] 
    public async Task<ActionResult<ExamDTO>> GetByIdAsync(int id)
    {
        var exam = await _examRepository.GetAsync(id);
        if (exam is null)
        {
            return NotFound();
        }
        return Ok(ExamDTO.FromExam(exam));
    }

    // GET api/exam
    [HttpGet]
    public async Task<IEnumerable<ExamDTO>> GetAllAsync()
    {
        var examAux = await _examRepository.GetAllAsync();
        return examAux.Select(ExamDTO.FromExam);
    }
}
