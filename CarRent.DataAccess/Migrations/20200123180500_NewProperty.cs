using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRent.DataAccess.Migrations
{
    public partial class NewProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Finished",
                table: "Orders",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
