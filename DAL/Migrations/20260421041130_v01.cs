using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class v01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookLines",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Bookpdf = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookLines", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pointstrial = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "offices",
                columns: table => new
                {
                    Code = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_offices", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "publishers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Birthdate = table.Column<DateOnly>(type: "date", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publishers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Orderdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Totalprice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Customerid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_orders_customers_Customerid",
                        column: x => x.Customerid,
                        principalTable: "customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Payeddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Customerid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_payments_customers_Customerid",
                        column: x => x.Customerid,
                        principalTable: "customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Birthofdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Managerid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Officecode = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_employees_employees_Managerid",
                        column: x => x.Managerid,
                        principalTable: "employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_employees_offices_Officecode",
                        column: x => x.Officecode,
                        principalTable: "offices",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisheddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publishednum = table.Column<int>(type: "int", nullable: false),
                    publishedhome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.ID);
                    table.ForeignKey(
                        name: "FK_books_bookLines_BookineId",
                        column: x => x.BookineId,
                        principalTable: "bookLines",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_books_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_books_publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "publishers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "orderBooks",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Bookid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Orderid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderBooks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_orderBooks_books_Bookid",
                        column: x => x.Bookid,
                        principalTable: "books",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_orderBooks_orders_Orderid",
                        column: x => x.Orderid,
                        principalTable: "orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_BookineId",
                table: "books",
                column: "BookineId");

            migrationBuilder.CreateIndex(
                name: "IX_books_EmployeeId",
                table: "books",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_books_PublisherId",
                table: "books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_Managerid",
                table: "employees",
                column: "Managerid");

            migrationBuilder.CreateIndex(
                name: "IX_employees_Officecode",
                table: "employees",
                column: "Officecode");

            migrationBuilder.CreateIndex(
                name: "IX_orderBooks_Bookid",
                table: "orderBooks",
                column: "Bookid");

            migrationBuilder.CreateIndex(
                name: "IX_orderBooks_Orderid",
                table: "orderBooks",
                column: "Orderid");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Customerid",
                table: "orders",
                column: "Customerid");

            migrationBuilder.CreateIndex(
                name: "IX_payments_Customerid",
                table: "payments",
                column: "Customerid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderBooks");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "bookLines");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "publishers");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "offices");
        }
    }
}
