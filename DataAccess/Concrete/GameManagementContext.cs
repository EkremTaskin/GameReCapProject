using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
	public class GameManagementContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GameManagement;Trusted_Connection=true");
		}

		public DbSet<Game> Games { get; set; }

		public DbSet<Launcher> Launchers { get; set; }

		public DbSet<Entity.Concrete.Type> Types { get; set; }
	}
}
