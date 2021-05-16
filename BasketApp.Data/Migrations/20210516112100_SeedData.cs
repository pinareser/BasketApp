using BasketApp.Data.Properties;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BasketApp.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(Resources.ResourceManager.GetString("SeedData_Up"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(Resources.ResourceManager.GetString("SeedData_Down"));
        }
    }
}
