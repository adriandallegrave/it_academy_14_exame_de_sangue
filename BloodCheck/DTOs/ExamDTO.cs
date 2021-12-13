using System.ComponentModel.DataAnnotations;
using BloodCheck.Models;

namespace BloodCheck.DTOs;

public class ExamDTO
{
    public int ExamId { get; set; }

    [Required]
    [MaxLength(6)]
    public decimal Price { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string? Description { get; set; }
    
    [Required]
    [MaxLength(2)]
    public int DeliveryDays { get; set; }

    public ExamDTO(int examId, decimal price, string description, int deliveryDays)
    {
        this.ExamId = examId;
        this.Price = price;
        this.Description = description;
        this.DeliveryDays = deliveryDays;
    }

    public static ExamDTO FromExam(Exam exam)
    {
        return new ExamDTO(exam.ExamId, exam.Price, exam.Description!, exam.DeliveryDays);
    }
}
