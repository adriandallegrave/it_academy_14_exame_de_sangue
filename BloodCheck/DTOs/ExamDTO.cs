using System.ComponentModel.DataAnnotations;
using BloodCheck.Models;

namespace BloodCheck.DTOs;

public class ExamDTO
{
    public int examId { get; set; }

    [Required]
    [MaxLength(6)]
    public decimal price { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string? description { get; set; }
    
    [Required]
    [MaxLength(2)]
    public int deliveryDays { get; set; }

    public ExamDTO(int examId, decimal price, string description, int deliveryDays)
    {
        this.examId = examId;
        this.price = price;
        this.description = description;
        this.deliveryDays = deliveryDays;
    }

    public static ExamDTO FromExam(Exam exam)
    {
        return new ExamDTO(exam.examId, exam.price, exam.description!, exam.deliveryDays);
    }
}
