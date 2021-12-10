using System.ComponentModel.DataAnnotations;
using BloodCheck.Models;
namespace BloodCheck.DTOs;

public class RequestDTO
{
     public int requestId { get; set; }

    // Create foreign key Patient (Request many to 1 Patient).
    public int patientId { get; set; }
    public Patient? Patient { get; set; }

    // Create foreign key Doctor (Request many to 1 Doctor).
    public int doctorId { get; set; }
    public Doctor? Doctor { get; set; }

    public DateTime requestDate { get; set; }

    // List and interface to generate foreign key (Request many to many Exam).
    public List<RequestExam> RequestExams { get; set; } = null!;
    public ICollection<Exam> Exams { get; set; } = null!;

    //nao sabemos se precisa adicionar o objeto medico e paciente
    public RequestDTO(int requestId, int patientId, int doctorId, DateTime requestDate)
    {
        this.requestId = requestId;
        this.patientId = patientId;
        this.doctorId = doctorId;
        this.requestDate = requestDate;
    }

    public static RequestDTO FromRequest(Request request)
    {
        return new RequestDTO
        (
            request.requestId,
            request.patientId,
            request.doctorId,
            request.requestDate
        );
    }
}
