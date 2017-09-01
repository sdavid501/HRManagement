using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManagement.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into UserTypes(Name) Values('Admin')");
            migrationBuilder.Sql("Insert into UserTypes(Name) Values('HR')");
            migrationBuilder.Sql("Insert into UserTypes(Name) Values('Consultant')");

            
            migrationBuilder.Sql("Insert into Purposes(Name) Values('Interview')");
            migrationBuilder.Sql("Insert into Purposes(Name) Values('Relocation')");

            migrationBuilder.Sql("Insert into Categories(Name) Values('Air Fare')");
            migrationBuilder.Sql("Insert into Categories(Name) Values('Gas')");
            migrationBuilder.Sql("Insert into Categories(Name) Values('Hotel Stay')");
            migrationBuilder.Sql("Insert into Categories(Name) Values('Meals')");
            migrationBuilder.Sql("Insert into Categories(Name) Values('Telephone')");
            migrationBuilder.Sql("Insert into Categories(Name) Values('Toll/Parking')");
            migrationBuilder.Sql("Insert into Categories(Name) Values('Train/Taxi/Rental')");
            migrationBuilder.Sql("Insert into Categories(Name) Values('Others')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Employees");
            migrationBuilder.Sql("Delete from UserTypes");
            migrationBuilder.Sql("Delete from ExpenseDetails");
            migrationBuilder.Sql("Delete from Categories");
            migrationBuilder.Sql("Delete from Expenses");
            migrationBuilder.Sql("Delete from Purposes");
            migrationBuilder.Sql("Delete from Status");
            migrationBuilder.Sql("Delete from ClientLocations");
            migrationBuilder.Sql("Delete from Clients");
        }
    }
}
