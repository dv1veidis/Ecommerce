using EcommerceProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceProject.DataAccess;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
           
    }
    public DbSet<Category> Categories { get; set; }
}
