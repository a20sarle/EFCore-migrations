using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkExample.Migrations
{
    public partial class TestColumnFromCLI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "testcolumn",
                table: "workers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "testcolumn",
                table: "workers");
        }
    }
}
