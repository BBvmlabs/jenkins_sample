using Microsoft.EntityFrameworkCore;

namespace MVCProject.Models.Task_4
{
	public class Data_BaseContext: DbContext
	{
		public DbSet<DB_Model1> Database_model1 { get; set; }
		public Data_BaseContext(DbContextOptions options) : base(options) 
		{ }

	}
}
