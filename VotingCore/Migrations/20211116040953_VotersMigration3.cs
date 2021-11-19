using Microsoft.EntityFrameworkCore.Migrations;

namespace VotingCore.Migrations
{
    public partial class VotersMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "isVoted",
                table: "Voters",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Contact_number",
                table: "Voters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "isVoted",
                table: "Voters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Contact_number",
                table: "Voters",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
