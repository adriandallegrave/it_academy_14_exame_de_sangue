using System.ComponentModel.DataAnnotations;
using BloodCheck.Models;

namespace BloodCheck.DTOs;

public class PutRequestDTO
{
    public int RequestId { get; set; }

    [Required]
    [MaxLength(6)]
    public string? Crm {get; set;}

    // [Required]
    // public List<int> ExamsIDs { get; set; } = null!;

    //nao sabemos se precisa adicionar o objeto medico e paciente
    public PutRequestDTO(int requestId, string crm)
    {
        this.RequestId = requestId;
        this.Crm = crm;
    }

    // public static PutRequestDTO FromPutRequest(Request request)
    // {
    //     return new PutRequestDTO
    //     (
    //         request.RequestId,
    //         request.DoctorId,
    //         request.RequestDate
    //     );
    // }
}
