using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManagement.Infrastructure.Migrations
{
    public partial class V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Campaigns_CampaignId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "CampaignId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ExerciseProgram",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Campaigns_CampaignId",
                table: "AspNetUsers",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Campaigns_CampaignId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ExerciseProgram",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "CampaignId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Campaigns_CampaignId",
                table: "AspNetUsers",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
