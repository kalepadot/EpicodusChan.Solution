using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EpicodusChan.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(nullable: true),
                    Topic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GroupId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Entry = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName", "Topic" },
                values: new object[] { 1, "Talk About Your Pet", "Pets" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName", "Topic" },
                values: new object[] { 2, "Talking Tech", "Tech" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupName", "Topic" },
                values: new object[] { 3, "Study Buddies", "Education" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Date", "Entry", "GroupId", "Title", "UserName" },
                values: new object[,]
                {
                    { 1, "04/20/2020", "Jeremy has the coolest cat ever, who happens to be named Haru", 1, "Cats Named Haru", "JDawg" },
                    { 2, "04/19/2020", "My name Jef and I really want 2 black cats named Huginn and Muninn", 1, "Huginn & Muninn", "GMoney" },
                    { 3, "03/31/2020", "I would love to have a dog named Freya, not sure what breed to get.", 1, "Freya", "GMoney" },
                    { 4, "04/7/2020", "I want to know, once and for all which is better. Mac or PC? (Hint:It's mac)", 2, "PC vs Mac", "DWizzle" },
                    { 5, "04/01/2020", "I'm taking a class on statistics and for a project I am taking a poll of peoples favorite fruits. Please comment below your answer!", 3, "Favorite Fruit?", "GMoney" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_GroupId",
                table: "Messages",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
