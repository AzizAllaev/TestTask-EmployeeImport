using Microsoft.EntityFrameworkCore;

namespace TestTask_EmployeeImport.Models
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=Employee_Data_Import_DB;Trusted_Connection=True;TrustServerCertificate=True");
		}
		public DbSet<Employee> Employees { get; set; }
	}
}
