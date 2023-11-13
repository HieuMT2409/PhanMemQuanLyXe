using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThueXeOTo.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "ID",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
