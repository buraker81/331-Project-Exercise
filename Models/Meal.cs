using System.ComponentModel.DataAnnotations;

namespace DietAppWebApi.Models;

public class Meal
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; } = default!;
}