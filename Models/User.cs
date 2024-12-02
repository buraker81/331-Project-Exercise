using System.ComponentModel.DataAnnotations;
namespace DietAppWebApi.Models;

public class User
{
    [Key] public int Id { get; set; }
    [Required] [MaxLength(20)] public string Username { get; set; } = default!;
    [Required] [Range(8, 20)] public string Password { get; set; } = default!;
    [Required] [Range(100, 250)] public double Height { get; set; } = default!;
    [Required] [Range(20, 300)] public decimal Weight { get; set; } = default!;

    [Required]
    [EnumDataType(typeof(UserGoal))]
    public UserGoal Goal { get; set; } = default!;

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public List<Meal> Meals { get; set; } = new List<Meal>();

    public enum UserGoal
    {
        GainWeight,
        LoseWeight,
        Stable
    };
}