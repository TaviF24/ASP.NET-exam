using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Models1",
                newName: "LastName");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Models1",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Models1",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Models1",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Models1");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Models1");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Models1");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Models1",
                newName: "Name");
        }
    }
}
