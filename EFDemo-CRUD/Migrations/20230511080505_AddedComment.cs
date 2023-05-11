using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDemo_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class AddedComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "tblBatches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "tblBatches");
        }
    }
}
