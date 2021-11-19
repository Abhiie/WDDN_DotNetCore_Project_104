using Microsoft.EntityFrameworkCore.Migrations;

namespace VotingCore.Migrations
{
    public partial class Votedinfo4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VoterId",
                table: "VotedInfos");

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "VotedInfos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "VotedInfos");

            migrationBuilder.AddColumn<int>(
                name: "VoterId",
                table: "VotedInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
