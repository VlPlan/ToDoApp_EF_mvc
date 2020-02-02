using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDo.App.DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    AverageFreeTime = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubtaskFromTask",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaskId = table.Column<int>(nullable: false),
                    SubTaskId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubtaskFromTask", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubTasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    _Task_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PriorityLevel = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    SubtaskId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Tasks_SubTasks_SubtaskId",
                        column: x => x.SubtaskId,
                        principalTable: "SubTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Tasks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "AverageFreeTime", "Firstname", "Lastname" },
                values: new object[] { 1, 33, 4.0, "Slave", "Konev" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "AverageFreeTime", "Firstname", "Lastname" },
                values: new object[] { 2, 26, 2.0, "Marina", "Mihajlova" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "AverageFreeTime", "Firstname", "Lastname" },
                values: new object[] { 3, 30, 1.0, "Igor", "Terzic" });

            migrationBuilder.InsertData(
                table: "_Tasks",
                columns: new[] { "Id", "Description", "PriorityLevel", "Status", "SubtaskId", "Title", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, "After Work tasks", 1, 2, null, "My wednesday activities", 1, 1 },
                    { 2, "check recieved emails from our buyers", 0, 2, null, "Check Emails", 0, 2 },
                    { 4, "Meeting with clients at 9am", 0, 2, null, "Work activities", 0, 2 },
                    { 3, "Gym training on Saturday", 2, 2, null, "Training", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "SubTasks",
                columns: new[] { "Id", "Description", "Status", "Title", "_Task_Id" },
                values: new object[,]
                {
                    { 1, "shopping", 2, "Go to supermarket", 1 },
                    { 2, "sport", 2, "Gym", 1 },
                    { 3, "check colleague's mail while he is on holiday", 2, "Check my colleague email", 2 },
                    { 5, "Sign new agreement for cooperation for 2019", 2, "Agreement", 4 },
                    { 4, "pay membership for Gym", 2, "Gym membership", 3 }
                });

            migrationBuilder.InsertData(
                table: "SubtaskFromTask",
                columns: new[] { "Id", "SubTaskId", "TaskId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 2 },
                    { 5, 5, 4 },
                    { 4, 4, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX__Tasks_SubtaskId",
                table: "_Tasks",
                column: "SubtaskId");

            migrationBuilder.CreateIndex(
                name: "IX__Tasks_UserId",
                table: "_Tasks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubtaskFromTask_SubTaskId",
                table: "SubtaskFromTask",
                column: "SubTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_SubtaskFromTask_TaskId",
                table: "SubtaskFromTask",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks__Task_Id",
                table: "SubTasks",
                column: "_Task_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubtaskFromTask_SubTasks_SubTaskId",
                table: "SubtaskFromTask",
                column: "SubTaskId",
                principalTable: "SubTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubtaskFromTask__Tasks_TaskId",
                table: "SubtaskFromTask",
                column: "TaskId",
                principalTable: "_Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks__Tasks__Task_Id",
                table: "SubTasks",
                column: "_Task_Id",
                principalTable: "_Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Tasks_SubTasks_SubtaskId",
                table: "_Tasks");

            migrationBuilder.DropTable(
                name: "SubtaskFromTask");

            migrationBuilder.DropTable(
                name: "SubTasks");

            migrationBuilder.DropTable(
                name: "_Tasks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
