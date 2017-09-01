using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using HRManagement.DAL;

namespace HRManagement.Migrations
{
    [DbContext(typeof(HRMDbContext))]
    [Migration("20170806025458_ExpensesModel")]
    partial class ExpensesModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HRManagement.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("HRManagement.Model.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("HRManagement.Model.ClientLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientLocations");
                });

            // modelBuilder.Entity("HRManagement.Model.Description", b =>
            //     {
            //         b.Property<int>("Id")
            //             .ValueGeneratedOnAdd();

            //         b.Property<string>("Name");

            //         b.HasKey("Id");

            //         b.ToTable("Descriptions");
            //     });

            modelBuilder.Entity("HRManagement.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("UserTypeId");

                    b.HasKey("Id");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HRManagement.Model.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<int?>("ClientLocationId");

                    b.Property<int>("EmployeeId");

                    b.Property<int>("LocationId");

                    b.Property<int>("PurposeId");

                    b.Property<int>("StatusId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ClientLocationId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PurposeId");

                    b.HasIndex("StatusId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("HRManagement.Model.ExpenseDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("Date");

                    // b.Property<int>("DescriptionId");

                    b.Property<int>("ExpenseId");

                    b.Property<string>("Note");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    // b.HasIndex("DescriptionId");

                    b.HasIndex("ExpenseId");

                    b.ToTable("ExpenseDetails");
                });

            modelBuilder.Entity("HRManagement.Model.Purpose", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Purposes");
                });

            modelBuilder.Entity("HRManagement.Model.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("HRManagement.Model.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("HRManagement.Model.ClientLocation", b =>
                {
                    b.HasOne("HRManagement.Model.Client", "Client")
                        .WithMany("ClientLocations")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HRManagement.Model.Employee", b =>
                {
                    b.HasOne("HRManagement.Model.UserType", "UserType")
                        .WithMany("Employees")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HRManagement.Model.Expense", b =>
                {
                    b.HasOne("HRManagement.Model.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HRManagement.Model.ClientLocation", "ClientLocation")
                        .WithMany()
                        .HasForeignKey("ClientLocationId");

                    b.HasOne("HRManagement.Model.Employee", "Employee")
                        .WithMany("Expenses")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HRManagement.Model.Purpose", "Purpose")
                        .WithMany("Expenses")
                        .HasForeignKey("PurposeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HRManagement.Model.Status", "Status")
                        .WithMany("Expenses")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HRManagement.Model.ExpenseDetail", b =>
                {
                    b.HasOne("HRManagement.Model.Category", "Category")
                        .WithMany("ExpenseDetails")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    // b.HasOne("HRManagement.Model.Description", "Description")
                    //     .WithMany("ExpenseDetails")
                    //     .HasForeignKey("DescriptionId")
                    //     .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HRManagement.Model.Expense", "Expense")
                        .WithMany("ExpenseDetails")
                        .HasForeignKey("ExpenseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
