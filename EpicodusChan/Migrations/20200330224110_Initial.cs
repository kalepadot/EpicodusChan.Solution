using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EpicodusChan.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Entry = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    GroupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Date", "Entry", "GroupName", "Title", "UserName" },
                values: new object[,]
                {
                    { 1, "04/20/2020", "Jeremy has the coolest cat ever, who happens to be named Haru", "Animals", "Cats Named Haru", "JDawg" },
                    { 2, "04/19/2020", "My name Jef and I really want 2 black cats named Huginn and Muninn", "Animals", "Huginn & Muninn", "GMoney" },
                    { 3, "03/31/2020", "I would love to have a dog named Freya, not sure what breed to get.", "Animals", "Freya", "GMoney" },
                    { 4, "04/7/2020", "I want to know, once and for all which is better. Mac or PC? (Hint:It's mac)", "Technology", "PC vs Mac", "DWizzle" },
                    { 5, "04/01/2020", "I'm taking a class on statistics and for a project I am taking a poll of peoples favorite fruits. Please comment below your answer!", "General Discussion", "Favorite Fruit?", "GMoney" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
