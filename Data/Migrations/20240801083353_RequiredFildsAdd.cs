using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstWebServer.Data.Migrations
{
    /// <inheritdoc />
    public partial class RequiredFildsAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "MyModel",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "MyModel",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "MyModel",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "MyModel");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "MyModel");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "MyModel");
        }
    }
}
