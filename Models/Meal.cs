using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DietAppWebApi.Models;

public class Meal
{
    [Key]
    public int Id { get; set; }
    [ForeignKey(nameof(User)), Required]
    public int UserId { get; set; }
    [Required]
    public MealTypes MealType { get; set; } = default!;
    public float TotalCalories { get; set; }
    public float TotalProteins { get; set; }
    public float TotalCarbs { get; set; }
    public float Fats { get; set; }
    [Required] public List<MealItem> MealItems { get; set; } = [];
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    public enum MealTypes {
        Breakfast,
        Lunch,
        Dinner,
        Snack
    }
}