using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RepPatternDb.Models;

namespace RepPatternDb.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Employee>? Employees {get;set;}
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
