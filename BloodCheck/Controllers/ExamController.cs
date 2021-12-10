using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using Microsoft.AspNetCore.Cors;
using BloodCheck.Data;
using BloodCheck.DTOs;
using BloodCheck.Models;

namespace BloodCheck.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExamController : ControllerBase
{
    private readonly ILogger<ExamController> _logger;
    private readonly IExamRepository _examRepository;

    public ExamController(ILogger<ExamController> logger, IExamRepository examRepository)
    {
        _logger = logger;
        _examRepository =  examRepository;
    }

    // TO-DO: GET api/exam/{idRequest}

    // GET /bloodcheck/{id}
    [HttpGet("{id:int}")] 
    public async Task<ActionResult<ExamDTO>> GetById(int id)
    {
        var exam = await _examRepository.GetAsync(id);
        if (exam is null)
        {
            return NotFound($"Exame #{id} nao encontrado");
        }
        return ExamDTO.FromExam(exam);
    }

    [HttpGet]
    public async Task<IEnumerable<ExamDTO>> GetAllAsync()
    {
        var examAux = await _examRepository.GetAllAsync();
        return examAux.Select(ExamDTO.FromExam);
    }
}
