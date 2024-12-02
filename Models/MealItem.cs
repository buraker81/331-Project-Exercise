using System.ComponentModel.DataAnnotations;

namespace DietAppWebApi.Models;

public class MealItem
{
    [Key]
    public int Id { get; set; }
    
    [Required,MaxLength(20)] public string? Name { get; set; }
    public double PortionSize { get; set; }
    public double CaloriePerGram { get; set; }
    public double ProteinPerGram { get; set; }
    public double CarbPerGram { get; set; }
    public double FatPerGram { get; set; }
    
    
    
}