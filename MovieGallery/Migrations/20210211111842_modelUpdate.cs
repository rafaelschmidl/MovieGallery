using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieGallery.Migrations
{
    public partial class modelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IMDBImageUrl",
                table: "Movie",
                newName: "ImageName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Movie",
                newName: "IMDBImageUrl");
        }
    }
}
