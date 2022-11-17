using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TutorSearchSystem.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_Manager_ManagersId",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_Fee_Manager_UpdateBy",
                table: "Fee");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Tutor_OwnerId",
                table: "Image");

            migrationBuilder.DropTable(
                name: "TuteeTransaction");

            migrationBuilder.DropIndex(
                name: "IX_Image_OwnerId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Class_ManagersId",
                table: "Class");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "OwnerRole",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Feedback");

            migrationBuilder.DropColumn(
                name: "StudyForm",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "ManagersId",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Account");

            migrationBuilder.RenameColumn(
                name: "UpdateBy",
                table: "Fee",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Fee_UpdateBy",
                table: "Fee",
                newName: "IX_Fee_CreatedBy");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "TutorTransaction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "FeePrice",
                table: "TutorTransaction",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "ConfirmedBy",
                table: "Tutor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ConfirmedDate",
                table: "Tutor",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Tutor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SocialIdUrl",
                table: "Tutor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Tutee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Subject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Subject",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ManageBy",
                table: "Subject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Membership",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Membership",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Membership",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Manager",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Manager",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ImageType",
                table: "Image",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerEmail",
                table: "Image",
                type: "nvarchar(256)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConfirmedBy",
                table: "Feedback",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ConfirmedDate",
                table: "Feedback",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Feedback",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Feedback",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Fee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Fee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Enrollment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsTakeFeedback",
                table: "Enrollment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ExtraImages",
                table: "Course",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Course",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MaxTutee",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Precondition",
                table: "Course",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Class_Has_Subject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Class_Has_Subject",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Class_Has_Subject",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Class_Has_Subject",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Class",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Class",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TokenNotification",
                table: "Account",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "Email");

            migrationBuilder.CreateTable(
                name: "CourseDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Schedule = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LearningOutcome = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseDetail_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SendToUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notification_Account_SendToUser",
                        column: x => x.SendToUser,
                        principalTable: "Account",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReportType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportType_Manager_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Manager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReportType_Manager_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Manager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReportType_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TutorUpdateProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvatarImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EducationLevel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    School = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SocialIdUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateImages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmedBy = table.Column<int>(type: "int", nullable: true),
                    ConfirmedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Points = table.Column<int>(type: "int", nullable: true),
                    MembershipId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    RequestUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TutorUpdateProfile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TuteeReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportTypeId = table.Column<int>(type: "int", nullable: false),
                    EnrollmentId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmedBy = table.Column<int>(type: "int", nullable: true),
                    ConfirmedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuteeReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TuteeReport_Enrollment_EnrollmentId",
                        column: x => x.EnrollmentId,
                        principalTable: "Enrollment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TuteeReport_Manager_ConfirmedBy",
                        column: x => x.ConfirmedBy,
                        principalTable: "Manager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TuteeReport_ReportType_ReportTypeId",
                        column: x => x.ReportTypeId,
                        principalTable: "ReportType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TutorReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportTypeId = table.Column<int>(type: "int", nullable: false),
                    TutorId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmedBy = table.Column<int>(type: "int", nullable: true),
                    ConfirmedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TutorReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TutorReport_Manager_ConfirmedBy",
                        column: x => x.ConfirmedBy,
                        principalTable: "Manager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TutorReport_ReportType_ReportTypeId",
                        column: x => x.ReportTypeId,
                        principalTable: "ReportType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TutorReport_Tutor_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TutorTransaction_CourseId",
                table: "TutorTransaction",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_ConfirmedBy",
                table: "Tutor",
                column: "ConfirmedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_CreatedBy",
                table: "Subject",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_ManageBy",
                table: "Subject",
                column: "ManageBy");

            migrationBuilder.CreateIndex(
                name: "IX_Membership_CreatedBy",
                table: "Membership",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Manager_CreatedBy",
                table: "Manager",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Image_OwnerEmail",
                table: "Image",
                column: "OwnerEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_ConfirmedBy",
                table: "Feedback",
                column: "ConfirmedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_CourseId",
                table: "Feedback",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Fee_UpdatedBy",
                table: "Fee",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Has_Subject_CreatedBy",
                table: "Class_Has_Subject",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Class_CreatedBy",
                table: "Class",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Class_UpdatedBy",
                table: "Class",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CourseDetail_CourseId",
                table: "CourseDetail",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_SendToUser",
                table: "Notification",
                column: "SendToUser");

            migrationBuilder.CreateIndex(
                name: "IX_ReportType_CreatedBy",
                table: "ReportType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ReportType_RoleId",
                table: "ReportType",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportType_UpdatedBy",
                table: "ReportType",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TuteeReport_ConfirmedBy",
                table: "TuteeReport",
                column: "ConfirmedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TuteeReport_EnrollmentId",
                table: "TuteeReport",
                column: "EnrollmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TuteeReport_ReportTypeId",
                table: "TuteeReport",
                column: "ReportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TutorReport_ConfirmedBy",
                table: "TutorReport",
                column: "ConfirmedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TutorReport_ReportTypeId",
                table: "TutorReport",
                column: "ReportTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TutorReport_TutorId",
                table: "TutorReport",
                column: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Manager_CreatedBy",
                table: "Class",
                column: "CreatedBy",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Manager_UpdatedBy",
                table: "Class",
                column: "UpdatedBy",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Has_Subject_Manager_CreatedBy",
                table: "Class_Has_Subject",
                column: "CreatedBy",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fee_Manager_CreatedBy",
                table: "Fee",
                column: "CreatedBy",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fee_Manager_UpdatedBy",
                table: "Fee",
                column: "UpdatedBy",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Course_CourseId",
                table: "Feedback",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Manager_ConfirmedBy",
                table: "Feedback",
                column: "ConfirmedBy",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Account_OwnerEmail",
                table: "Image",
                column: "OwnerEmail",
                principalTable: "Account",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Manager_Manager_CreatedBy",
                table: "Manager",
                column: "CreatedBy",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Membership_Manager_CreatedBy",
                table: "Membership",
                column: "CreatedBy",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Manager_CreatedBy",
                table: "Subject",
                column: "CreatedBy",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Manager_ManageBy",
                table: "Subject",
                column: "ManageBy",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutor_Manager_ConfirmedBy",
                table: "Tutor",
                column: "ConfirmedBy",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TutorTransaction_Course_CourseId",
                table: "TutorTransaction",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_Manager_CreatedBy",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_Class_Manager_UpdatedBy",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_Class_Has_Subject_Manager_CreatedBy",
                table: "Class_Has_Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Fee_Manager_CreatedBy",
                table: "Fee");

            migrationBuilder.DropForeignKey(
                name: "FK_Fee_Manager_UpdatedBy",
                table: "Fee");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Course_CourseId",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Manager_ConfirmedBy",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Account_OwnerEmail",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Manager_Manager_CreatedBy",
                table: "Manager");

            migrationBuilder.DropForeignKey(
                name: "FK_Membership_Manager_CreatedBy",
                table: "Membership");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Manager_CreatedBy",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Manager_ManageBy",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutor_Manager_ConfirmedBy",
                table: "Tutor");

            migrationBuilder.DropForeignKey(
                name: "FK_TutorTransaction_Course_CourseId",
                table: "TutorTransaction");

            migrationBuilder.DropTable(
                name: "CourseDetail");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "TuteeReport");

            migrationBuilder.DropTable(
                name: "TutorReport");

            migrationBuilder.DropTable(
                name: "TutorUpdateProfile");

            migrationBuilder.DropTable(
                name: "ReportType");

            migrationBuilder.DropIndex(
                name: "IX_TutorTransaction_CourseId",
                table: "TutorTransaction");

            migrationBuilder.DropIndex(
                name: "IX_Tutor_ConfirmedBy",
                table: "Tutor");

            migrationBuilder.DropIndex(
                name: "IX_Subject_CreatedBy",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_ManageBy",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Membership_CreatedBy",
                table: "Membership");

            migrationBuilder.DropIndex(
                name: "IX_Manager_CreatedBy",
                table: "Manager");

            migrationBuilder.DropIndex(
                name: "IX_Image_OwnerEmail",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Feedback_ConfirmedBy",
                table: "Feedback");

            migrationBuilder.DropIndex(
                name: "IX_Feedback_CourseId",
                table: "Feedback");

            migrationBuilder.DropIndex(
                name: "IX_Fee_UpdatedBy",
                table: "Fee");

            migrationBuilder.DropIndex(
                name: "IX_Class_Has_Subject_CreatedBy",
                table: "Class_Has_Subject");

            migrationBuilder.DropIndex(
                name: "IX_Class_CreatedBy",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Class_UpdatedBy",
                table: "Class");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "TutorTransaction");

            migrationBuilder.DropColumn(
                name: "FeePrice",
                table: "TutorTransaction");

            migrationBuilder.DropColumn(
                name: "ConfirmedBy",
                table: "Tutor");

            migrationBuilder.DropColumn(
                name: "ConfirmedDate",
                table: "Tutor");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Tutor");

            migrationBuilder.DropColumn(
                name: "SocialIdUrl",
                table: "Tutor");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Tutee");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "ManageBy",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Membership");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Membership");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Manager");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Manager");

            migrationBuilder.DropColumn(
                name: "ImageType",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "OwnerEmail",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "ConfirmedBy",
                table: "Feedback");

            migrationBuilder.DropColumn(
                name: "ConfirmedDate",
                table: "Feedback");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Feedback");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Feedback");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Fee");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Fee");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "IsTakeFeedback",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "ExtraImages",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "MaxTutee",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Precondition",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Class_Has_Subject");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Class_Has_Subject");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Class_Has_Subject");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Class_Has_Subject");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "TokenNotification",
                table: "Account");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Fee",
                newName: "UpdateBy");

            migrationBuilder.RenameIndex(
                name: "IX_Fee_CreatedBy",
                table: "Fee",
                newName: "IX_Fee_UpdateBy");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Membership",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OwnerRole",
                table: "Image",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Feedback",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudyForm",
                table: "Course",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ManagersId",
                table: "Class",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Account",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Account",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Account",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TuteeTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FeeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TotalAmount = table.Column<float>(type: "real", nullable: false),
                    TuteeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuteeTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TuteeTransaction_Fee_FeeId",
                        column: x => x.FeeId,
                        principalTable: "Fee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TuteeTransaction_Tutee_TuteeId",
                        column: x => x.TuteeId,
                        principalTable: "Tutee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_OwnerId",
                table: "Image",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_ManagersId",
                table: "Class",
                column: "ManagersId");

            migrationBuilder.CreateIndex(
                name: "IX_TuteeTransaction_FeeId",
                table: "TuteeTransaction",
                column: "FeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TuteeTransaction_TuteeId",
                table: "TuteeTransaction",
                column: "TuteeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Manager_ManagersId",
                table: "Class",
                column: "ManagersId",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fee_Manager_UpdateBy",
                table: "Fee",
                column: "UpdateBy",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Tutor_OwnerId",
                table: "Image",
                column: "OwnerId",
                principalTable: "Tutor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
