using System;
using System.Collections.Generic;
using System.Text;
using librarysystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


namespace DAL.Context
{
    public class AppdbContext:DbContext
    {

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connection = "Server=localhost;DataBase=Kotopi;Trusted_Connection=true;TrustServerCertificate=true";
			optionsBuilder.UseSqlServer(connection);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppdbContext).Assembly);
			base.OnModelCreating(modelBuilder);
		}

		//local contailners 
		public virtual DbSet<BookLine>bookLines { get; set; }
		public virtual DbSet<Book>books { get; set; }
		public virtual DbSet<Customer>customers { get; set; }
		public virtual DbSet<Employee> employees { get; set; }
		public virtual DbSet<Order> orders { get; set; }
		public virtual DbSet<OrderBook>orderBooks { get; set; }
		public virtual DbSet<Payment> payments { get; set; }
		public virtual DbSet<Office> offices { get; set; }
		public virtual DbSet<Publisher> publishers{ get; set; }


	}
}
