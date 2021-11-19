using Microsoft.EntityFrameworkCore.Migrations;

namespace VotingCore.Migrations
{
    public partial class VotersMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Voters_PanNumber_Contact_number",
                table: "Voters");

            migrationBuilder.CreateIndex(
                name: "IX_Voters_PanNumber",
                table: "Voters",
                column: "PanNumber",
                unique: true,
                filter: "[PanNumber] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Voters_PanNumber",
                table: "Voters");

            migrationBuilder.CreateIndex(
                name: "IX_Voters_PanNumber_Contact_number",
                table: "Voters",
                columns: new[] { "PanNumber", "Contact_number" },
                unique: true,
                filter: "[PanNumber] IS NOT NULL");
        }
    }
}
