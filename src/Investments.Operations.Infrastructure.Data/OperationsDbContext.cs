using Investments.Operations.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Investments.Operations.Infrastructure.Data;

public class OperationsDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<Operation> Operations { get; set; }
    
    public OperationsDbContext(DbContextOptions<OperationsDbContext> options) 
        : base(options)
    {
    }
}