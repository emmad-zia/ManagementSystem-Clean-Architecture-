using Entities.DAos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class OrgDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=EMMAD-ZIA;Database=CLA_ManagementSystem;User Id=sa;Password=Pakistan12;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region Configure Department DAO
            //set Department table name as Department
            modelBuilder.Entity<Department>().ToTable("Department");
            //set Did as primary key
            modelBuilder.Entity<Department>().HasKey(d => d.Did);
            //set Did as non identity column
            modelBuilder.Entity<Department>().Property(d => d.Did).ValueGeneratedNever();
            //set DName as required
            modelBuilder.Entity<Department>().Property(d => d.DName).IsRequired();
            //set DName string lentgh to 50
            modelBuilder.Entity<Department>().Property(d => d.DName).HasMaxLength(50);
            //set Description string lentgh to 500
            modelBuilder.Entity<Department>().Property(d => d.Description).HasMaxLength(500);
            #endregion

            #region Configure Employee DAO
            //set Employee table name as Employee
            modelBuilder.Entity<Employee>().ToTable("Employee");
            //set Eid as primary key
            modelBuilder.Entity<Employee>().HasKey(e => e.Eid);
            //set Eid as identity column starting from 100
            modelBuilder.Entity<Employee>().Property(e => e.Eid).UseIdentityColumn(increment: 1, seed: 100);
            //set EName as required
            modelBuilder.Entity<Employee>().Property(e => e.EmpName).IsRequired();
            //set default value for Gender as Male
            modelBuilder.Entity<Employee>().Property(e => e.Gender).HasDefaultValue("Male");
            //set Email as unique
            //modelBuilder.Entity<Employee>().HasIndex(e => e.Email).IsUnique();
            //set DOB as Date type
            modelBuilder.Entity<Employee>().Property(e => e.DOB).HasColumnType("Date");
            #endregion

            #region StudentCourse

            //set Did as foreign key with cascade on Delete (1:M relationship)
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.DepartmentNav)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.Did);
            //.OnDelete(DeleteBehavior.Cascade); //no support for cascade on update for now

            //set Student table name as Student
            modelBuilder.Entity<Student>().ToTable("Student");
            //set Sid as primary key
            modelBuilder.Entity<Student>().HasKey(s => s.Sid);

            //set Course table name as Course
            modelBuilder.Entity<Course>().ToTable("Course");
            //set Cid as primary key
            modelBuilder.Entity<Course>().HasKey(c => c.Cid);

            modelBuilder.Entity<StudentCourse>().ToTable("StudentCourse");
            modelBuilder.Entity<StudentCourse>().HasKey(sc => sc.SCid);


            //set 1:M relationship between Student and StudentCourse
            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.StudentNav)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.Sid);

            //set 1:M relationship between Course and StudentCourse
            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.CourseNav)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.Cid);

            //set composite primary key for StudentCourse   
            //modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.Sid, sc.Cid }); 
            #endregion

            modelBuilder.Entity<Department>()
                     .HasData(
                        new Department { Did = 1, DName = "Customer Support", Description = "Handles customer queries and issues" },
                        new Department { Did = 2, DName = "Legal", Description = "Manages legal affairs and compliance" },
                        new Department { Did = 3, DName = "Procurement", Description = "Oversees purchasing and vendor management" },
                        new Department { Did = 4, DName = "Training", Description = "Conducts employee training and development" },
                        new Department { Did = 5, DName = "Security", Description = "Ensures physical and digital security" },
                        new Department { Did = 6, DName = "IT", Description = "Information Technology" },
                        new Department { Did = 7, DName = "HR", Description = "Human Resource" },
                        new Department { Did = 8, DName = "Admin", Description = "Administration" },
                        new Department { Did = 9, DName = "Finance", Description = "Finance" },
                        new Department { Did = 10, DName = "Sales", Description = "Sales" },
                        new Department { Did = 11, DName = "Marketing", Description = "Marketing" },
                        new Department { Did = 12, DName = "Production", Description = "Production" },
                        new Department { Did = 13, DName = "R&D", Description = "Research and Development" },
                        new Department { Did = 14, DName = "Quality", Description = "Quality" },
                        new Department { Did = 15, DName = "Logistics", Description = "Logistics" }
                        );


        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
