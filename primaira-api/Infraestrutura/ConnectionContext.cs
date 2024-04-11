using Microsoft.EntityFrameworkCore;
using primaira_api.Models;

namespace primaira_api.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            "Server=localhost; Port=5432; Database= employee_sample; " +
            "User Id = postgres; Password = bruno123;");
    }
}
