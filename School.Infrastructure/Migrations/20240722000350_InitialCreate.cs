#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DID);
                });

            migrationBuilder.CreateTable(
                name: "Grads",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grads", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "classRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Did = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_classRooms_Departments_Did",
                        column: x => x.Did,
                        principalTable: "Departments",
                        principalColumn: "DID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salary = table.Column<double>(type: "float", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Did = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.id);
                    table.ForeignKey(
                        name: "FK_teachers_Departments_Did",
                        column: x => x.Did,
                        principalTable: "Departments",
                        principalColumn: "DID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    SubID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    GradID = table.Column<int>(type: "int", nullable: false),
                    DepId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.SubID);
                    table.ForeignKey(
                        name: "FK_subjects_Departments_DepId",
                        column: x => x.DepId,
                        principalTable: "Departments",
                        principalColumn: "DID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_subjects_Grads_GradID",
                        column: x => x.GradID,
                        principalTable: "Grads",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    StudID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ClsRoomID = table.Column<int>(type: "int", nullable: false),
                    DID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.StudID);
                    table.ForeignKey(
                        name: "FK_students_Departments_DID",
                        column: x => x.DID,
                        principalTable: "Departments",
                        principalColumn: "DID");
                    table.ForeignKey(
                        name: "FK_students_classRooms_ClsRoomID",
                        column: x => x.ClsRoomID,
                        principalTable: "classRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassRoomTeacher",
                columns: table => new
                {
                    Teachersid = table.Column<int>(type: "int", nullable: false),
                    roomsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRoomTeacher", x => new { x.Teachersid, x.roomsId });
                    table.ForeignKey(
                        name: "FK_ClassRoomTeacher_classRooms_roomsId",
                        column: x => x.roomsId,
                        principalTable: "classRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassRoomTeacher_teachers_Teachersid",
                        column: x => x.Teachersid,
                        principalTable: "teachers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Degrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<double>(type: "float", nullable: false),
                    AcademicGrad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Degrees_subjects_SubjId",
                        column: x => x.SubjId,
                        principalTable: "subjects",
                        principalColumn: "SubID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectTeacher",
                columns: table => new
                {
                    Teachersid = table.Column<int>(type: "int", nullable: false),
                    subjectsSubID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTeacher", x => new { x.Teachersid, x.subjectsSubID });
                    table.ForeignKey(
                        name: "FK_SubjectTeacher_subjects_subjectsSubID",
                        column: x => x.subjectsSubID,
                        principalTable: "subjects",
                        principalColumn: "SubID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectTeacher_teachers_Teachersid",
                        column: x => x.Teachersid,
                        principalTable: "teachers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubject",
                columns: table => new
                {
                    StudentsStudID = table.Column<int>(type: "int", nullable: false),
                    SubjectsSubID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubject", x => new { x.StudentsStudID, x.SubjectsSubID });
                    table.ForeignKey(
                        name: "FK_StudentSubject_students_StudentsStudID",
                        column: x => x.StudentsStudID,
                        principalTable: "students",
                        principalColumn: "StudID",
                        onDelete: ReferentialAction.Restrict
                        );
                    table.ForeignKey(
                        name: "FK_StudentSubject_subjects_SubjectsSubID",
                        column: x => x.SubjectsSubID,
                        principalTable: "subjects",
                        principalColumn: "SubID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_classRooms_Did",
                table: "classRooms",
                column: "Did");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoomTeacher_roomsId",
                table: "ClassRoomTeacher",
                column: "roomsId");

            migrationBuilder.CreateIndex(
                name: "IX_Degrees_SubjId",
                table: "Degrees",
                column: "SubjId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_ClsRoomID",
                table: "students",
                column: "ClsRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_students_DID",
                table: "students",
                column: "DID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_SubjectsSubID",
                table: "StudentSubject",
                column: "SubjectsSubID");

            migrationBuilder.CreateIndex(
                name: "IX_subjects_DepId",
                table: "subjects",
                column: "DepId");

            migrationBuilder.CreateIndex(
                name: "IX_subjects_GradID",
                table: "subjects",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTeacher_subjectsSubID",
                table: "SubjectTeacher",
                column: "subjectsSubID");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_Did",
                table: "teachers",
                column: "Did");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassRoomTeacher");

            migrationBuilder.DropTable(
                name: "Degrees");

            migrationBuilder.DropTable(
                name: "StudentSubject");

            migrationBuilder.DropTable(
                name: "SubjectTeacher");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "subjects");

            migrationBuilder.DropTable(
                name: "teachers");

            migrationBuilder.DropTable(
                name: "classRooms");

            migrationBuilder.DropTable(
                name: "Grads");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
