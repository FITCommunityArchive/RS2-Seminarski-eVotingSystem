using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eVotingSystem.WebAPI.Migrations
{
    public partial class testtt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectionCycles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectionCycles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectionRegions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SuperiorRegionId = table.Column<int>(nullable: true),
                    SuperiorElectionRegionId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectionRegions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectionRegions_ElectionRegions_SuperiorElectionRegionId",
                        column: x => x.SuperiorElectionRegionId,
                        principalTable: "ElectionRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ElectionUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ElectionRegionId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    VotingBegginingTime = table.Column<DateTime>(nullable: false),
                    VotingEndTime = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectionUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectionUnits_ElectionRegions_ElectionRegionId",
                        column: x => x.ElectionRegionId,
                        principalTable: "ElectionRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ElectiveLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElectionPositionName = table.Column<string>(nullable: true),
                    ElectionRegionId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectiveLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectiveLists_ElectionRegions_ElectionRegionId",
                        column: x => x.ElectionRegionId,
                        principalTable: "ElectionRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PoliticalOrganizations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    Ordinal = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    PoliticalOrientation = table.Column<int>(nullable: false),
                    FileId = table.Column<int>(nullable: true),
                    PictureId = table.Column<int>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoliticalOrganizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoliticalOrganizations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PoliticalOrganizations_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PoliticalOrganizations_Files_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true),
                    CardId = table.Column<string>(nullable: true),
                    JMBG = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false),
                    UserTypes = table.Column<int>(nullable: false),
                    ElectionUnitId = table.Column<int>(nullable: true),
                    FileId = table.Column<int>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_ElectionUnits_ElectionUnitId",
                        column: x => x.ElectionUnitId,
                        principalTable: "ElectionUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ElectionCycleElectiveLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElectionCycleId = table.Column<int>(nullable: false),
                    ElectiveListId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectionCycleElectiveLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectionCycleElectiveLists_ElectionCycles_ElectionCycleId",
                        column: x => x.ElectionCycleId,
                        principalTable: "ElectionCycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ElectionCycleElectiveLists_ElectiveLists_ElectiveListId",
                        column: x => x.ElectiveListId,
                        principalTable: "ElectiveLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PoliticalOrganizationId = table.Column<int>(nullable: true),
                    Ordinal = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    ResumeId = table.Column<int>(nullable: true),
                    PictureId = table.Column<int>(nullable: true),
                    NationalityId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidates_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidates_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidates_Files_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidates_PoliticalOrganizations_PoliticalOrganizationId",
                        column: x => x.PoliticalOrganizationId,
                        principalTable: "PoliticalOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidates_Files_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(nullable: true),
                    RecieverId = table.Column<int>(nullable: false),
                    ReceiverId = table.Column<int>(nullable: true),
                    Header = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    TimeOfSending = table.Column<DateTime>(nullable: false),
                    PictureId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Files_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Users_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Voters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    IsVoted = table.Column<bool>(nullable: false),
                    NationalityId = table.Column<int>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    SchoolingDegreeLevel = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voters_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ElectionOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateId = table.Column<int>(nullable: true),
                    PoliticalOrganizationId = table.Column<int>(nullable: true),
                    ElectionOptionType = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectionOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectionOptions_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ElectionOptions_PoliticalOrganizations_PoliticalOrganizationId",
                        column: x => x.PoliticalOrganizationId,
                        principalTable: "PoliticalOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ElectiveListElectionOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElectiveListId = table.Column<int>(nullable: false),
                    ElectionOptionId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectiveListElectionOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectiveListElectionOptions_ElectionOptions_ElectionOptionId",
                        column: x => x.ElectionOptionId,
                        principalTable: "ElectionOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ElectiveListElectionOptions_ElectiveLists_ElectiveListId",
                        column: x => x.ElectiveListId,
                        principalTable: "ElectiveLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<Guid>(nullable: false),
                    ElectionOptionId = table.Column<int>(nullable: false),
                    ElectiveListId = table.Column<int>(nullable: false),
                    ElectionUnitId = table.Column<int>(nullable: true),
                    NationalityId = table.Column<int>(nullable: true),
                    VoterCityId = table.Column<int>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    SchoolingDegreeLevel = table.Column<int>(nullable: false),
                    TimeOfVoting = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votes_ElectionOptions_ElectionOptionId",
                        column: x => x.ElectionOptionId,
                        principalTable: "ElectionOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Votes_ElectionUnits_ElectionUnitId",
                        column: x => x.ElectionUnitId,
                        principalTable: "ElectionUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Votes_ElectiveLists_ElectiveListId",
                        column: x => x.ElectiveListId,
                        principalTable: "ElectiveLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Votes_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Votes_Cities_VoterCityId",
                        column: x => x.VoterCityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_CityId",
                table: "Candidates",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_NationalityId",
                table: "Candidates",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_PictureId",
                table: "Candidates",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_PoliticalOrganizationId",
                table: "Candidates",
                column: "PoliticalOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_ResumeId",
                table: "Candidates",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectionCycleElectiveLists_ElectionCycleId",
                table: "ElectionCycleElectiveLists",
                column: "ElectionCycleId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectionCycleElectiveLists_ElectiveListId",
                table: "ElectionCycleElectiveLists",
                column: "ElectiveListId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectionOptions_CandidateId",
                table: "ElectionOptions",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectionOptions_PoliticalOrganizationId",
                table: "ElectionOptions",
                column: "PoliticalOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectionRegions_SuperiorElectionRegionId",
                table: "ElectionRegions",
                column: "SuperiorElectionRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectionUnits_ElectionRegionId",
                table: "ElectionUnits",
                column: "ElectionRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectiveListElectionOptions_ElectionOptionId",
                table: "ElectiveListElectionOptions",
                column: "ElectionOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectiveListElectionOptions_ElectiveListId",
                table: "ElectiveListElectionOptions",
                column: "ElectiveListId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectiveLists_ElectionRegionId",
                table: "ElectiveLists",
                column: "ElectionRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_PictureId",
                table: "Messages",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PoliticalOrganizations_CityId",
                table: "PoliticalOrganizations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_PoliticalOrganizations_FileId",
                table: "PoliticalOrganizations",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_PoliticalOrganizations_PictureId",
                table: "PoliticalOrganizations",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ElectionUnitId",
                table: "Users",
                column: "ElectionUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FileId",
                table: "Users",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Voters_NationalityId",
                table: "Voters",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Voters_UserId",
                table: "Voters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ElectionOptionId",
                table: "Votes",
                column: "ElectionOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ElectionUnitId",
                table: "Votes",
                column: "ElectionUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ElectiveListId",
                table: "Votes",
                column: "ElectiveListId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_NationalityId",
                table: "Votes",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_VoterCityId",
                table: "Votes",
                column: "VoterCityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectionCycleElectiveLists");

            migrationBuilder.DropTable(
                name: "ElectiveListElectionOptions");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Voters");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "ElectionCycles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ElectionOptions");

            migrationBuilder.DropTable(
                name: "ElectiveLists");

            migrationBuilder.DropTable(
                name: "ElectionUnits");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "ElectionRegions");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "PoliticalOrganizations");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
