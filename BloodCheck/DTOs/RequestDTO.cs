using System.ComponentModel.DataAnnotations;
using BloodCheck.Models;

namespace BloodCheck.DTOs;

public class RequestDTO
{
     public int RequestId { get; set; }

    // Create foreign key Patient (Request many to 1 Patient).
    [Required]
    public int PatientId { get; set; }

    // public Patient? Patient { get; set; }

    // Create foreign key Doctor (Request many to 1 Doctor).
    [Required]
    public int DoctorId { get; set; }

    //public Doctor? Doctor { get; set; }
    [Required]
    public DateTime RequestDate { get; set; }

    [Required]
    public List<int> ExamsIDs { get; set; } = null!;

    //nao sabemos se precisa adicionar o objeto medico e paciente
    public RequestDTO(int requestId, int patientId, int doctorId, DateTime requestDate)
    {
        this.RequestId = requestId;
        this.PatientId = patientId;
        this.DoctorId = doctorId;
        this.RequestDate = requestDate;
    }

    public static RequestDTO FromRequest(Request request)
    {
        return new RequestDTO
        (
            request.RequestId,
            request.PatientId,
            request.DoctorId,
            request.RequestDate
        );
    }
}
