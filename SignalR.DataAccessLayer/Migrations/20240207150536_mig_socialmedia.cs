using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    public partial class mig_socialmedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialMediae",
                table: "SocialMediae");

            migrationBuilder.RenameTable(
                name: "SocialMediae",
                newName: "SocialMedia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialMedia",
                table: "SocialMedia",
                column: "SocialMediaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialMedia",
                table: "SocialMedia");

            migrationBuilder.RenameTable(
                name: "SocialMedia",
                newName: "SocialMediae");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialMediae",
                table: "SocialMediae",
                column: "SocialMediaID");
        }
    }
}
