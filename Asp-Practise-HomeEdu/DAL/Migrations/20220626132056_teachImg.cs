using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp_Practise_HomeEdu.DAL.Migrations
{
    public partial class teachImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Teachers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Teachers");
        }
    }
}
