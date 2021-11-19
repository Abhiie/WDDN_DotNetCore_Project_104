using Microsoft.EntityFrameworkCore.Migrations;

namespace VotingCore.Migrations
{
    public partial class VotersMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Voters",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(nullable: true),
                    Lname = table.Column<string>(nullable: true),
                    PanNumber = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: true),
                    Contact_number = table.Column<int>(nullable: false),
                    isVoted = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voters", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Voters_PanNumber_Contact_number",
                table: "Voters",
                columns: new[] { "PanNumber", "Contact_number" },
                unique: true,
                filter: "[PanNumber] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Voters");
        }
    }
}
