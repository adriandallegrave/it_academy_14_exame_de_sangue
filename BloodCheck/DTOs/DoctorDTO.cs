using BloodCheck.Models;

namespace BloodCheck.DTOs;

public class DoctorDTO
{
    public int DoctorId { get; set; }
    public string Crm { get; set; }
    public string Name { get; set; }

    public DoctorDTO(int id, string crm, string name)
    {
        DoctorId = id; 
        Crm = crm;
        Name = name;
    }

    public static DoctorDTO FromDoctor(Doctor doctor)
    {
        return new DoctorDTO(doctor.DoctorId, doctor.Crm!, doctor.Name!);
    }
}
