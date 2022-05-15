using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace First_site_V2.Storage.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_People_ProfileLogin",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_ProfileLogin",
                table: "People");

            migrationBuilder.DropColumn(
                name: "ProfileLogin",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "FriendListId",
                table: "People",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Login = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Login);
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_FriendListId",
                table: "People",
                column: "FriendListId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Friends_FriendListId",
                table: "People",
                column: "FriendListId",
                principalTable: "Friends",
                principalColumn: "Login",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Friends_FriendListId",
                table: "People");

            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_People_FriendListId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "FriendListId",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "ProfileLogin",
                table: "People",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_ProfileLogin",
                table: "People",
                column: "ProfileLogin");

            migrationBuilder.AddForeignKey(
                name: "FK_People_People_ProfileLogin",
                table: "People",
                column: "ProfileLogin",
                principalTable: "People",
                principalColumn: "Login");
        }
    }
}
