using System.ComponentModel.DataAnnotations;
namespace DietAppWebApi.Models;

public class User
{
    [Key] public int Id { get; set; }
    [Required] [MaxLength(20)] 
    public string Username { get; set; } = default!;
    [Required, MaxLength(20), MinLength(8)]  
    public string Password { get; set; } = default!;
    [Required, Range(100, 250)] 
    public double Height { get; set; }
    [Required, Range(20, 300)] 
    public decimal Weight { get; set; }
    [Required] public Gender UserGender { get; set; }
    [Required, EnumDataType(typeof(GoalType))] 
    public GoalType Goal { get; set; } = default!;
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }

    public List<Meal> Meals { get; set; } = new List<Meal>();

    public enum GoalType
    {
        GainWeight,
        LoseWeight,
        Stable
    };

    public enum Gender
    {
        Male,
        Female
    };
}