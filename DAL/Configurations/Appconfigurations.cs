using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using librarysystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class Appconfigurations
    {
        public class BookLineConfiguration : IEntityTypeConfiguration<BookLine>
        {
            public void Configure(EntityTypeBuilder<BookLine> builder)
            {
                //properties
                builder.HasKey(BL => BL.ID);
                builder.Property(BL => BL.Bookpdf).IsRequired();

                //relationships
                builder.HasMany(BL => BL.Books)
                    .WithOne(B => B.BookLine)
                    .HasForeignKey(B => B.BookineId)
                    .OnDelete(DeleteBehavior.NoAction);
            }

        }
		public class BookConfiguration : IEntityTypeConfiguration<Book>
		{
			public void Configure(EntityTypeBuilder<Book> builder)
			{
				//properties
				builder.HasKey(B => B.ID);
				builder.Property(B => B.Title).IsRequired(false);
				builder.Property(B => B.Description).IsRequired(false);
				builder.Property(B => B.publishedhome).IsRequired(false);
				builder.Property(B => B.Image).IsRequired(false);

				//relationships
				builder.HasOne(B => B.Publisher).WithMany(P => P.Books)
					.HasForeignKey(B => B.PublisherId)
					.OnDelete(DeleteBehavior.NoAction);

				builder.HasOne(B => B.Employee).WithMany(E => E.Books)
					.HasForeignKey(B => B.EmployeeId)
					.OnDelete(DeleteBehavior.NoAction);

				builder.HasMany(B => B.OrderBooks).
					WithOne(Or => Or.Book)
					.OnDelete(DeleteBehavior.NoAction);

				}
		}

		public class CustomerConfiguration:IEntityTypeConfiguration<Customer>
		{
			public void Configure(EntityTypeBuilder<Customer> builder)
			{
				//properties
				builder.HasKey(c => c.Id);
				builder.Property(c => c.Name).HasMaxLength(100).IsRequired(false);
				builder.Property(c => c.Image).IsRequired(false);

				//relationships

				builder.HasMany(c => c.Orders).WithOne(o => o.Customer)
					.HasForeignKey(o => o.Customerid)
					.OnDelete(DeleteBehavior.NoAction);

				builder.HasMany(c => c.Payments)
					.WithOne(p => p.Customer)
					.HasForeignKey(p => p.Customerid)
					.OnDelete(DeleteBehavior.NoAction);

			}
		}

		public class EmployeeConfiguration:IEntityTypeConfiguration<Employee>
		{
			public void Configure(EntityTypeBuilder<Employee>builder)
			{
				//properties
				builder.HasKey(e => e.ID);
				builder.Property(e => e.Name).IsRequired().HasMaxLength(100);

				//relationships
				builder.HasOne(e => e.Manager).WithMany(m => m.Employees)
					.HasForeignKey(e => e.Managerid)
					.OnDelete(DeleteBehavior.NoAction);

				builder.HasOne(e => e.Office)
					.WithMany(O => O.Employees)
					.HasForeignKey(e => e.Officecode)
					.OnDelete(DeleteBehavior.Cascade);


				//stored_procedures &triggers
			}
		}
		public class OfficeConfiguration:IEntityTypeConfiguration<Office>
		{
			public void Configure(EntityTypeBuilder<Office>builder)
			{
				//properties
				builder.HasKey(o => o.Code);
				builder.Property(o => o.Name).HasMaxLength(100).IsRequired();
				builder.Property(o => o.Adress).HasMaxLength(255).IsRequired(false);

				//triggers & stored procedures

			}
		}

		public class OrderConfiguration:IEntityTypeConfiguration<Order>
		{
			public void Configure(EntityTypeBuilder<Order>builder)
			{
				//properties
				builder.HasKey(o => o.ID);
				builder.Property(o => o.Status).IsRequired(false).HasMaxLength(50);

				//triggers and stored procedures

				//relations
				builder.HasMany(o => o.OrderBooks)
					.WithOne(ob => ob.Order).HasForeignKey(or => or.Orderid)
					.OnDelete(DeleteBehavior.Cascade);

			}
		}
		public class OrderBookConfiguration:IEntityTypeConfiguration<OrderBook>
		{
			public void Configure(EntityTypeBuilder<OrderBook>builder)
			{
				//properties
				builder.HasKey(o => o.ID);

				//trigger and stored procedures
			}
		}

		public class PaymentConfiguration:IEntityTypeConfiguration<Payment>
		{
			public void Configure(EntityTypeBuilder<Payment>builder)
			{
				//properties
				builder.HasKey(p => p.Id);
				builder.Property(p => p.PaymentType).IsRequired().HasMaxLength(255);
			
				//triggers and stored procedures

			}
		}

		public class PublisherConfiguration:IEntityTypeConfiguration<Publisher>
		{
			public void Configure(EntityTypeBuilder<Publisher>builder)
			{
				//properties
				builder.HasKey(p => p.ID);
				builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
				builder.Property(p => p.Image).IsRequired(false);
				builder.Property(p => p.Type).IsRequired().HasMaxLength(60);


				//triggers ,constraints and stored procedures

			}
		}

	}


}

