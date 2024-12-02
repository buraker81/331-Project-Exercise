using DietAppWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DietAppWebApi.Repository;

public class DietDb: DbContext
{
    public DietDb(DbContextOptions<DietDb> options): base(options){ }
    
    public DbSet<User> Users { get; set; }
    
}