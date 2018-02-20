using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FiveMinutes.Migrations
{
    public partial class CreateUserRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserRelationship",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Accepted = table.Column<bool>(nullable: false),
                    FriendID = table.Column<string>(nullable: false),
                    UserID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRelationship", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRelationship");
        }
    }
}
