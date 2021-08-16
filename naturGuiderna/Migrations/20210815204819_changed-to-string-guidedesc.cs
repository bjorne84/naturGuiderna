using Microsoft.EntityFrameworkCore.Migrations;

namespace naturGuiderna.Migrations
{
    public partial class changedtostringguidedesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experience_Activity_Activities_ActivityId",
                table: "Experience_Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Experience_Activity_Experiences_ExperienceId",
                table: "Experience_Activity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Experience_Activity",
                table: "Experience_Activity");

            migrationBuilder.RenameTable(
                name: "Experience_Activity",
                newName: "Experience_Activities");

            migrationBuilder.RenameIndex(
                name: "IX_Experience_Activity_ActivityId",
                table: "Experience_Activities",
                newName: "IX_Experience_Activities_ActivityId");

            migrationBuilder.AlterColumn<string>(
                name: "GuideDescription",
                table: "Guides",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experience_Activities",
                table: "Experience_Activities",
                columns: new[] { "ExperienceId", "ActivityId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Activities_Activities_ActivityId",
                table: "Experience_Activities",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Activities_Experiences_ExperienceId",
                table: "Experience_Activities",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experience_Activities_Activities_ActivityId",
                table: "Experience_Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Experience_Activities_Experiences_ExperienceId",
                table: "Experience_Activities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Experience_Activities",
                table: "Experience_Activities");

            migrationBuilder.RenameTable(
                name: "Experience_Activities",
                newName: "Experience_Activity");

            migrationBuilder.RenameIndex(
                name: "IX_Experience_Activities_ActivityId",
                table: "Experience_Activity",
                newName: "IX_Experience_Activity_ActivityId");

            migrationBuilder.AlterColumn<int>(
                name: "GuideDescription",
                table: "Guides",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experience_Activity",
                table: "Experience_Activity",
                columns: new[] { "ExperienceId", "ActivityId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Activity_Activities_ActivityId",
                table: "Experience_Activity",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Activity_Experiences_ExperienceId",
                table: "Experience_Activity",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
