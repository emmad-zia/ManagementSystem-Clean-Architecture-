using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CleanArchitectureSample : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 1009);

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Did", "DName", "Description", "IsActive" },
                values: new object[,]
                {
                    { 1, "Customer Support", "Handles customer queries and issues", false },
                    { 2, "Legal", "Manages legal affairs and compliance", false },
                    { 3, "Procurement", "Oversees purchasing and vendor management", false },
                    { 4, "Training", "Conducts employee training and development", false },
                    { 5, "Security", "Ensures physical and digital security", false },
                    { 6, "IT", "Information Technology", false },
                    { 7, "HR", "Human Resource", false },
                    { 8, "Admin", "Administration", false },
                    { 9, "Finance", "Finance", false },
                    { 10, "Sales", "Sales", false },
                    { 11, "Marketing", "Marketing", false },
                    { 12, "Production", "Production", false },
                    { 13, "R&D", "Research and Development", false },
                    { 14, "Quality", "Quality", false },
                    { 15, "Logistics", "Logistics", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Did",
                keyValue: 15);

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
        }
    }
}
