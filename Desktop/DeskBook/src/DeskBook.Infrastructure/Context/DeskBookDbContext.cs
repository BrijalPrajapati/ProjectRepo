using System.Reflection;
using DeskBook.Infrastructure.Model.Designation;
using Microsoft.EntityFrameworkCore;

namespace DeskBook.Infrastructure.Context;

public class DeskBookDbContext : DbContext
{
    public DbSet<DesignationModel> designations { get; set; }
    public DeskBookDbContext(DbContextOptions<DeskBookDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
