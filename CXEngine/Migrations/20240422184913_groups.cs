using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CXEngine.Migrations
{
    /// <inheritdoc />
    public partial class groups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Business",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Group",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "WorkItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupID",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkItems_UserId",
                table: "WorkItems",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_GroupID",
                table: "User",
                column: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Group_GroupID",
                table: "User",
                column: "GroupID",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItems_User_UserId",
                table: "WorkItems",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Group_GroupID",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_User_UserId",
                table: "WorkItems");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropIndex(
                name: "IX_WorkItems_UserId",
                table: "WorkItems");

            migrationBuilder.DropIndex(
                name: "IX_User_GroupID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "WorkItems");

            migrationBuilder.DropColumn(
                name: "GroupID",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "Business",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
