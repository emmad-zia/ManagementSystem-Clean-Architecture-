using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class OrgFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Cid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Cid);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Did = table.Column<int>(type: "int", nullable: false),
                    DName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Did);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Sid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Sid);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Eid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Male"),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    DOB = table.Column<DateTime>(type: "Date", nullable: false),
                    Did = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Eid);
                    table.ForeignKey(
                        name: "FK_Employee_Department_Did",
                        column: x => x.Did,
                        principalTable: "Department",
                        principalColumn: "Did");
                });

            migrationBuilder.CreateTable(
                name: "StudentCourse",
                columns: table => new
                {
                    SCid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sid = table.Column<int>(type: "int", nullable: false),
                    Cid = table.Column<int>(type: "int", nullable: false),
                    DOE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Term = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marks = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => x.SCid);
                    table.ForeignKey(
                        name: "FK_StudentCourse_Course_Cid",
                        column: x => x.Cid,
                        principalTable: "Course",
                        principalColumn: "Cid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourse_Student_Sid",
                        column: x => x.Sid,
                        principalTable: "Student",
                        principalColumn: "Sid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Did", "DName", "Description", "IsActive" },
                values: new object[,]
                {
                    { 1000, "IT", "Information Technology", false },
                    { 1001, "HR", "Human Resource", false },
                    { 1002, "Admin", "Administration", false },
                    { 1003, "Finance", "Finance", false },
                    { 1004, "Sales", "Sales", false },
                    { 1005, "Marketing", "Marketing", false },
                    { 1006, "Production", "Production", false },
                    { 1007, "R&D", "Research and Development", false },
                    { 1008, "Quality", "Quality", false },
                    { 1009, "Logistics", "Logistics", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Did",
                table: "Employee",
                column: "Did");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_Cid",
                table: "StudentCourse",
                column: "Cid");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_Sid",
                table: "StudentCourse",
                column: "Sid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "StudentCourse");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
