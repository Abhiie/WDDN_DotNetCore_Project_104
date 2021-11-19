using Microsoft.EntityFrameworkCore.Migrations;

namespace VotingCore.Migrations
{
    public partial class CandidateMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateName = table.Column<string>(nullable: false),
                    CandidateNumber = table.Column<string>(nullable: false),
                    CandidateEmailAddress = table.Column<string>(nullable: false),
                    Position = table.Column<string>(nullable: false),
                    Vote = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidates");
        }
    }
}
