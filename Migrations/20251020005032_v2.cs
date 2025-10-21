using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeetCode.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "LeetCodeQuestions",
                newName: "Link");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Link",
                table: "LeetCodeQuestions",
                newName: "Status");
        }
    }
}
