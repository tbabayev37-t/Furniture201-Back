using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Furniture201.Migrations
{
    /// <inheritdoc />
    public partial class AddedBlogs2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Employees_EmployeId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_EmployeId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "EmployeId",
                table: "Blogs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_EmployeeId",
                table: "Blogs",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Employees_EmployeeId",
                table: "Blogs",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Employees_EmployeeId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_EmployeeId",
                table: "Blogs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeId",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_EmployeId",
                table: "Blogs",
                column: "EmployeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Employees_EmployeId",
                table: "Blogs",
                column: "EmployeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
