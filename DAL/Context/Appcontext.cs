using System;
using System.Collections.Generic;
using System.Text;
using librarysystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


namespace DAL.Context
{
    public class AppContext:DbContext
    {

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connection = "Server=localhost;DataBase=Kotopi;Trusted_Connection=true;TrustServerCertificate=true";
			optionsBuilder.UseSqlServer(connection);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
			base.OnModelCreating(modelBuilder);
		}

		//local contailners 
		public DbSet<BookLine>bookLines { get; set; }
		public DbSet<Book>books { get; set; }
		public DbSet<Customer>customers { get; set; }
		public DbSet<Employee> employees { get; set; }
		public DbSet<Order> orders { get; set; }
		public DbSet<OrderBook>orderBooks { get; set; }
		public DbSet<Payment> payments { get; set; }
		public DbSet<Office> offices { get; set; }
		public DbSet<Publisher> publishers{ get; set; }


	}
}
