using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IQTest.Repository.Migrations
{
    public partial class minitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Questions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRefreshTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRefreshTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CorrectAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorrectAns = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrectAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorrectAnswers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WrongAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WrongAns = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WrongAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WrongAnswers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedDate", "Questions", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3483), "Which number logically follows this series? 4,6,9,6,14,6,...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3497), "Choose a number, double it, add 10, halve it, and subtract your original number. The result is:", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3499), "In a race, you pass the person in the 2nd place. What position are you in now?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3501), "Which word does not belong? Apple, Muffin, Orange, Cherry", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3502), "If you had only one match and entered a dark room containing an oil lamp, some kindling wood, and a newspaper, which would you light first?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3503), "Which word does not belong? Typhoon, Hurricane, Tornado, Light", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3504), "What is the next number in the series: 10, 12, 14, 16,...?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is the number that is one more than one-tenth of one-fifth of one-half of 4,000?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3506), "If all Zips are Zoodles, and the Zoodle Zane is a Zip, then Zane is definitely a Zoodle. True or False?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3507), "Which number should come next in this series? 25, 24, 22, 19, 15,...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3509), "Which shape does not belong? Circle, Square, Triangle, Cylinder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3510), "What is half of two-thirds of three-quarters of four-fifths of 500?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3512), "If you rearrange the letters \"BARBIT\", you would have the name of a:", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3513), "Which one of the five is least like the other four?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3515), "Which number should come next in this series? 37, 34, 31, 28", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3516), "If you remove one side from two identical squares and join them at the exposed points, what shape would you get?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3517), "If you rearrange the letters \"OTOYTA\", you get the name of a:", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3519), "Choose the word most opposite to Cautious:", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3520), "If all Bloops are Razzies and all Razzies are Lazzies, then all Bloops are definitely Lazzies?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3522), "Which one of the five makes the best comparison? Brother is to sister as niece is to:", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3523), "If the day after tomorrow is a Sunday, then what day is it today?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3524), "Which of the following is least like the others?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3526), "How many two-cent stamps are there in a dozen?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3527), "Which of these is not a type of triangle based on its angles?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3528), "If some Smaugs are Thors and some Thors are Thrains, then some Smaugs are definitely Thrains. This statement is:", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3529), "Ralph likes 25 but not 24; he likes 400 but not 300; he likes 144 but not 145. Which does he like?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3530), "A plane crashes on the border of the U.S. and Canada. Where do they bury the survivors?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3532), "The more you take from it, the larger it grows. What is it?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3534), "What is the missing number in the sequence: 4, 9, 16, 25, ?, 49", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3535), "A train leaves from New York City heading towards Los Angeles at 100 mph. Three hours later, a train leaves LA heading towards NYC at 200 mph. Which train will be closer to NYC when they meet?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3536), "Which word is the odd one out: First, Second, Third, Forth, Fifth, Sixth, Seventh, Eighth?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3538), "If a red house is made of red bricks and a blue house is made of blue bricks, what is a green house made of?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3539), "What is half of a quarter of 400?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3540), "If you reverse the word \"STOP\", what do you get?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3542), "Which number is the odd one out: 3, 5, 11, 14, 17, 21?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3543), "The maker doesn't want it; the buyer doesn't use it; and the user doesn't see it. What is it?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3545), "If a doctor gives you 3 pills and tells you to take one every half hour starting immediately, how long would it be before all the pills had been taken?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3546), "How many 9s are there between 1 and 100?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3549), "If it takes 8 men 10 hours to build a wall, how long would it take 4 men?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3550), "How many of each species did Moses take on the ark?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3551), "Select a number that is one-third of one-half of one-fifth of 210", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3553), "Which word spelled backwards will be the same as the original word?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedDate", "Questions", "UpdateDate" },
                values: new object[,]
                {
                    { 43, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3554), "Which of the following can you find in the middle of Tokyo?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3556), "Which number is one half of one quarter of one tenth of 400?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3559), "If a circle is one, how many is an octagon?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3560), "Mike is taller than Peter, and Ray is shorter than Mike. Which of the following statements would be more accurate?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3562), "If more Winks are Pinkos and all Drabs are Durs, and some Pinkos are Drabs, then some Winks are definitely Durs. True or False?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3564), "John needs 13 bottles of water from the store. John can only carry 3 at a time. What is the minimum number of trips John needs to make to the store?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3565), "Choose the word most similar to Reckless:", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3566), "If you turn your left glove inside out, it will fit your right hand. True or False?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3568), "What comes next in the series: O, T, T, F, F,...?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3570), "If you rearrange the letters \"CIFAIPC\" you would have the name of a(n):", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3571), "What is the missing number in the sequence shown below? 1, 8, 27, ?, 125", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3572), "If you rearrange the letters \"SCTOLDNA\", you would have the name of a:", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3574), "Mary, who is sixteen years old, is four times older than her brother. How old will Mary be when she is twice as old as her brother?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3575), "Choose the word most similar to Trustworthy:", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3576), "Which number represents the letter T in the series made of numbers 1-26?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3578), "Which word does not belong with the others?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is the next letter in the sequence: O, T, T, F, F, S, S, ?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3644), "Fred will be twice as old as John in 5 years. If John is 10 years old, how old is Fred now?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3646), "If Richard looks into a mirror and touches his left ear with his right hand, Richard's image seems to touch its right ear with its left hand. If Richard moves his left foot forward, the foot of Richard's image seems to move:", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3647), "If some Bats are Birds, all Birds are Beasts, and some Beasts are Blooms, then it's necessarily the case that:", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3649), "In a year, some months have 30 days, while others have 31. How many months have 28 days?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3650), "If two pencils cost six cents, how much do eight pencils cost?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3652), "If ROSE is coded as 6821, CHAIR is coded as 73456, then ARC is:", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3653), "Tom's mother has three children. The first was named April, the second was named May. What was the third child's name?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3655), "If the day before yesterday was Saturday, what day is it today?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3658), "What is the next number in the sequence? 9,8,6,3?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3659), "If a circular pizza is divided into eighths, how many pieces make a quarter of the pizza?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3661), "In a leap year, how many days does February have?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3662), "What is the next number in the sequence: 2, 4, 8, 16, 32, ... ?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3663), "If there is a bowl with six apples and you take away four, how many do you have?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3665), "Which shape has more sides: a hexagon or an octagon?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3666), "Which is heavier: a pound of feathers or a pound of stones?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3668), "Which word, when written in capital letters, is the same forwards, backwards and upside down?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3670), "If you drop a yellow hat in the Red Sea, what does it become?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3671), "Divide 30 by half and add 10. What do you get?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3672), "Which of the following words is the odd one out? Cheese, Meat, Eggs, Lettuce", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, new DateTime(2023, 12, 9, 18, 8, 51, 872, DateTimeKind.Local).AddTicks(3674), "What can be cracked, made, told, and played?", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CorrectAnswers",
                columns: new[] { "Id", "CorrectAns", "QuestionId" },
                values: new object[,]
                {
                    { 1, "19", 1 },
                    { 2, "5", 2 },
                    { 3, "2nd", 3 },
                    { 4, "Muffin", 4 },
                    { 5, "The match", 5 },
                    { 6, "Light", 6 },
                    { 7, "18", 7 },
                    { 8, "41", 8 },
                    { 9, "True", 9 },
                    { 10, "10", 10 },
                    { 11, "Cylinder", 11 },
                    { 12, "100", 12 },
                    { 13, "Animal", 13 },
                    { 14, "Think", 14 },
                    { 15, "25", 15 },
                    { 16, "Rectangle", 16 },
                    { 17, "Company", 17 },
                    { 18, "Careless", 18 },
                    { 19, "True", 19 },
                    { 20, "Nephew", 20 },
                    { 21, "Friday", 21 },
                    { 22, "Statue", 22 },
                    { 23, "12", 23 },
                    { 24, "Equilateral", 24 },
                    { 25, "False", 25 },
                    { 26, "100", 26 },
                    { 27, "Nowhere", 27 },
                    { 28, "A hole", 28 },
                    { 29, "36", 29 },
                    { 30, "The LA train", 30 },
                    { 31, "Forth", 31 },
                    { 32, "Glass", 32 },
                    { 33, "50", 33 },
                    { 34, "POTS", 34 },
                    { 35, "21", 35 },
                    { 36, "A coffin", 36 },
                    { 37, "1 hour", 37 },
                    { 38, "20", 38 },
                    { 39, "20 hours", 39 },
                    { 40, "None, it was Noah", 40 },
                    { 41, "7", 41 },
                    { 42, "Racecar", 42 }
                });

            migrationBuilder.InsertData(
                table: "CorrectAnswers",
                columns: new[] { "Id", "CorrectAns", "QuestionId" },
                values: new object[,]
                {
                    { 43, "The letter K", 43 },
                    { 44, "5", 44 },
                    { 45, "8", 45 },
                    { 46, "Cannot determine", 46 },
                    { 47, "False", 47 },
                    { 48, "5", 48 },
                    { 49, "Audacious", 49 },
                    { 50, "True", 50 },
                    { 51, "S", 51 },
                    { 52, "Ocean", 52 },
                    { 53, "64", 53 },
                    { 54, "Country", 54 },
                    { 55, "24", 55 },
                    { 56, "Reliable", 56 },
                    { 57, "20", 57 },
                    { 58, "Elephant", 58 },
                    { 59, "E", 59 },
                    { 60, "25", 60 },
                    { 61, "Forward", 61 },
                    { 62, "Some Bats are Beasts", 62 },
                    { 63, "All of them", 63 },
                    { 64, "24 cents", 64 },
                    { 65, "467", 65 },
                    { 66, "Tom", 66 },
                    { 67, "Monday", 67 },
                    { 68, "-1", 68 },
                    { 69, "2", 69 },
                    { 70, "29", 70 },
                    { 71, "64", 71 },
                    { 72, "4", 72 },
                    { 73, "Octagon", 73 },
                    { 74, "Both are the same", 74 },
                    { 75, "NOON", 75 },
                    { 76, "Wet", 76 },
                    { 77, "25", 77 },
                    { 78, "Lettuce", 78 },
                    { 79, "A joke", 79 }
                });

            migrationBuilder.InsertData(
                table: "WrongAnswers",
                columns: new[] { "Id", "QuestionId", "WrongAns" },
                values: new object[,]
                {
                    { 1, 1, "15" },
                    { 2, 1, "21" },
                    { 3, 1, "17" },
                    { 4, 1, "Correct Answer Not Present" },
                    { 5, 2, "7" }
                });

            migrationBuilder.InsertData(
                table: "WrongAnswers",
                columns: new[] { "Id", "QuestionId", "WrongAns" },
                values: new object[,]
                {
                    { 6, 2, "10" },
                    { 7, 2, "Correct Answer Not Present" },
                    { 8, 3, "1st" },
                    { 9, 3, "3rd" },
                    { 10, 3, "4th" },
                    { 11, 3, "Correct Answer Not Present" },
                    { 12, 4, "Apple" },
                    { 13, 4, "Orange" },
                    { 14, 4, "Cherry" },
                    { 15, 4, "Correct Answer Not Present" },
                    { 16, 5, "The newspaper" },
                    { 17, 5, "The oil lamp" },
                    { 18, 5, "The kindling" },
                    { 19, 5, "Correct Answer Not Present" },
                    { 20, 6, "Typhoon" },
                    { 21, 6, "Hurricane" },
                    { 22, 6, "Tornado" },
                    { 23, 6, "Correct Answer Not Present" },
                    { 24, 7, "17" },
                    { 25, 7, "19" },
                    { 26, 7, "20" },
                    { 27, 7, "Correct Answer Not Present" },
                    { 28, 8, "42" },
                    { 29, 8, "43" },
                    { 30, 8, "44" },
                    { 31, 8, "Correct Answer Not Present" },
                    { 32, 9, "False" },
                    { 33, 9, "Cannot be determined" },
                    { 34, 9, "None of the above" },
                    { 35, 9, "Correct Answer Not Present" },
                    { 36, 10, "11" },
                    { 37, 10, "12" },
                    { 38, 10, "13" },
                    { 39, 10, "Correct Answer Not Present" },
                    { 40, 11, "Circle" },
                    { 41, 11, "Square" },
                    { 42, 11, "Triangle" },
                    { 43, 11, "Correct Answer Not Present" },
                    { 44, 12, "225" },
                    { 45, 12, "250" },
                    { 46, 12, "300" },
                    { 47, 12, "Correct Answer Not Present" }
                });

            migrationBuilder.InsertData(
                table: "WrongAnswers",
                columns: new[] { "Id", "QuestionId", "WrongAns" },
                values: new object[,]
                {
                    { 48, 13, "River" },
                    { 49, 13, "Country" },
                    { 50, 13, "State" },
                    { 51, 13, "Correct Answer Not Present" },
                    { 52, 14, "Touch" },
                    { 53, 14, "Taste" },
                    { 54, 14, "Hear" },
                    { 55, 14, "Correct Answer Not Present" },
                    { 56, 15, "26" },
                    { 57, 15, "24" },
                    { 58, 15, "23" },
                    { 59, 15, "Correct Answer Not Present" },
                    { 60, 16, "Hexagon" },
                    { 61, 16, "Triangle" },
                    { 62, 16, "Correct Answer Not Present" },
                    { 63, 17, "Country" },
                    { 64, 17, "State" },
                    { 65, 17, "City" },
                    { 66, 17, "Correct Answer Not Present" },
                    { 67, 18, "Prudent" },
                    { 68, 18, "Measured" },
                    { 69, 18, "Careful" },
                    { 70, 18, "Correct Answer Not Present" },
                    { 71, 19, "False" },
                    { 72, 19, "Correct Answer Not Present" },
                    { 73, 20, "Mother" },
                    { 74, 20, "Daughter" },
                    { 75, 20, "Aunt" },
                    { 76, 20, "Correct Answer Not Present" },
                    { 77, 21, "Wednesday" },
                    { 78, 21, "Thursday" },
                    { 79, 21, "Saturday" },
                    { 80, 21, "Correct Answer Not Present" },
                    { 81, 22, "Note" },
                    { 82, 22, "Novel" },
                    { 83, 22, "Business Card" },
                    { 84, 22, "Correct Answer Not Present" },
                    { 85, 23, "2" },
                    { 86, 23, "24" },
                    { 87, 23, "6 Card" },
                    { 88, 23, "Correct Answer Not Present" },
                    { 89, 24, "Acute" }
                });

            migrationBuilder.InsertData(
                table: "WrongAnswers",
                columns: new[] { "Id", "QuestionId", "WrongAns" },
                values: new object[,]
                {
                    { 90, 24, "Obtuse" },
                    { 91, 24, "Correct Answer Not Present" },
                    { 92, 25, "True" },
                    { 93, 25, "Correct Answer Not Present" },
                    { 94, 26, "12351235" },
                    { 95, 26, "1700" },
                    { 96, 26, "83" },
                    { 97, 26, "Correct Answer Not Present" },
                    { 98, 27, "U.S." },
                    { 99, 27, "Canada" },
                    { 100, 27, "Both" },
                    { 101, 27, "Correct Answer Not Present" },
                    { 102, 28, "A mountain" },
                    { 103, 28, "A tree" },
                    { 104, 28, "A river" },
                    { 105, 28, "Correct Answer Not Present" },
                    { 106, 29, "30" },
                    { 107, 29, "40" },
                    { 108, 29, "45" },
                    { 109, 29, "Correct Answer Not Present" },
                    { 110, 30, "The NYC train" },
                    { 111, 30, "Neither" },
                    { 112, 30, "Both" },
                    { 113, 30, "Correct Answer Not Present" },
                    { 114, 31, "First" },
                    { 115, 31, "Third" },
                    { 116, 31, "Eighth" },
                    { 117, 31, "Correct Answer Not Present" },
                    { 118, 32, "Green Straw" },
                    { 119, 32, "Green wood" },
                    { 120, 32, "Green stone" },
                    { 121, 32, "Correct Answer Not Present" },
                    { 122, 33, "100" },
                    { 123, 33, "200" },
                    { 124, 33, "25" },
                    { 125, 33, "Correct Answer Not Present" },
                    { 126, 34, "SPOT" },
                    { 127, 34, "TOPS" },
                    { 128, 34, "POST" },
                    { 129, 34, "Correct Answer Not Present" },
                    { 130, 35, "3" },
                    { 131, 35, "14" }
                });

            migrationBuilder.InsertData(
                table: "WrongAnswers",
                columns: new[] { "Id", "QuestionId", "WrongAns" },
                values: new object[,]
                {
                    { 132, 35, "17" },
                    { 133, 35, "Correct Answer Not Present" },
                    { 134, 36, "A toy" },
                    { 135, 36, "A car" },
                    { 136, 36, "A book" },
                    { 137, 36, "Correct Answer Not Present" },
                    { 138, 37, "3 hours" },
                    { 139, 37, "1,5 hours " },
                    { 140, 37, "2 hours" },
                    { 141, 37, "Correct Answer Not Present" },
                    { 142, 38, "10" },
                    { 143, 38, "11" },
                    { 144, 38, "21" },
                    { 145, 38, "Correct Answer Not Present" },
                    { 146, 39, "5 hours" },
                    { 147, 39, "15 hours" },
                    { 148, 39, "25 hours" },
                    { 149, 39, "Correct Answer Not Present" },
                    { 150, 40, "1" },
                    { 151, 40, "2" },
                    { 152, 40, "7" },
                    { 153, 40, "Correct Answer Not Present" },
                    { 154, 41, "10" },
                    { 155, 41, "14" },
                    { 156, 41, "21" },
                    { 157, 41, "Correct Answer Not Present" },
                    { 158, 42, "Automobile" },
                    { 159, 42, "Java" },
                    { 160, 42, "Python" },
                    { 161, 42, "Correct Answer Not Present" },
                    { 162, 43, "Sushi" },
                    { 163, 43, "Skyscraper" },
                    { 164, 43, "The letter O" },
                    { 165, 43, "Correct Answer Not Present" },
                    { 166, 44, "10" },
                    { 167, 44, "20" },
                    { 168, 44, "2" },
                    { 169, 44, "Correct Answer Not Present" },
                    { 170, 45, "2" },
                    { 171, 45, "4" },
                    { 172, 45, "6" },
                    { 173, 45, "Correct Answer Not Present" }
                });

            migrationBuilder.InsertData(
                table: "WrongAnswers",
                columns: new[] { "Id", "QuestionId", "WrongAns" },
                values: new object[,]
                {
                    { 174, 46, "Ray is taller than Peter." },
                    { 175, 46, "Ray is shorter than Peter." },
                    { 176, 46, "Peter is the same height as Ray." },
                    { 177, 47, "True" },
                    { 178, 47, "Cannot be determined" },
                    { 179, 47, "None of the above" },
                    { 180, 47, "Correct Answer Not Present" },
                    { 181, 48, "4" },
                    { 182, 48, "6" },
                    { 183, 48, "7" },
                    { 184, 48, "Correct Answer Not Present" },
                    { 185, 49, "Responsible" },
                    { 186, 49, "Careful" },
                    { 187, 49, "Wary" },
                    { 188, 49, "Correct Answer Not Present" },
                    { 189, 50, "False" },
                    { 190, 57, "Cannot be determined" },
                    { 191, 50, "None of the above" },
                    { 192, 50, "Correct Answer Not Present" },
                    { 193, 51, "E" },
                    { 194, 51, "T" },
                    { 195, 51, "N" },
                    { 196, 51, "Correct Answer Not Present" },
                    { 197, 52, "City" },
                    { 198, 52, "Animal" },
                    { 199, 52, "Country" },
                    { 200, 52, "Correct Answer Not Present" },
                    { 201, 53, "36" },
                    { 202, 53, "49" },
                    { 203, 53, "100" },
                    { 204, 53, "Correct Answer Not Present" },
                    { 205, 54, "Animal" },
                    { 206, 54, "City" },
                    { 207, 54, "River" },
                    { 208, 54, "Correct Answer Not Present" },
                    { 209, 55, "20" },
                    { 210, 55, "28" },
                    { 211, 55, "32" },
                    { 212, 55, "Correct Answer Not Present" },
                    { 213, 56, "Resolute" },
                    { 214, 56, "Tenacity" },
                    { 215, 56, "Insolent" }
                });

            migrationBuilder.InsertData(
                table: "WrongAnswers",
                columns: new[] { "Id", "QuestionId", "WrongAns" },
                values: new object[,]
                {
                    { 216, 56, "Correct Answer Not Present" },
                    { 217, 57, "19" },
                    { 218, 57, "21" },
                    { 219, 57, "22" },
                    { 220, 57, "Correct Answer Not Present" },
                    { 221, 58, "Leopard" },
                    { 222, 58, "Cougar" },
                    { 223, 58, "Lion" },
                    { 224, 58, "Correct Answer Not Present" },
                    { 225, 59, "N" },
                    { 226, 59, "T" },
                    { 227, 59, "H" },
                    { 228, 59, "Correct Answer Not Present" },
                    { 229, 60, "15" },
                    { 230, 60, "20" },
                    { 231, 60, "30" },
                    { 232, 60, "Correct Answer Not Present" },
                    { 233, 61, "Left" },
                    { 234, 61, "Right" },
                    { 235, 61, "Backward" },
                    { 236, 61, "Correct Answer Not Present" },
                    { 237, 62, "Some Birds are Bats" },
                    { 238, 62, "Some Beasts are Bats" },
                    { 239, 62, "Some Blooms are Bats" },
                    { 240, 62, "Correct Answer Not Present" },
                    { 241, 63, "1" },
                    { 242, 63, "2" },
                    { 243, 63, "3" },
                    { 244, 63, "Correct Answer Not Present" },
                    { 245, 64, "48 cents" },
                    { 246, 64, "32 cents" },
                    { 247, 64, "16 cents" },
                    { 248, 64, "Correct Answer Not Present" },
                    { 249, 65, "271" },
                    { 250, 65, "471" },
                    { 251, 65, "742" },
                    { 252, 65, "Correct Answer Not Present" },
                    { 253, 66, "June" },
                    { 254, 66, "July" },
                    { 255, 66, "August" },
                    { 256, 66, "Correct Answer Not Present" },
                    { 257, 67, "Sunday" }
                });

            migrationBuilder.InsertData(
                table: "WrongAnswers",
                columns: new[] { "Id", "QuestionId", "WrongAns" },
                values: new object[,]
                {
                    { 258, 67, "Tuesday" },
                    { 259, 67, "Wednesday" },
                    { 260, 67, "Correct Answer Not Present" },
                    { 261, 68, "5" },
                    { 262, 68, "2" },
                    { 263, 68, "Correct Answer Not Present" },
                    { 264, 69, "3" },
                    { 265, 69, "4" },
                    { 266, 69, "Correct Answer Not Present" },
                    { 267, 70, "28" },
                    { 268, 70, "30" },
                    { 269, 70, "31" },
                    { 270, 70, "Correct Answer Not Present" },
                    { 271, 71, "40" },
                    { 272, 71, "48" },
                    { 273, 71, "56" },
                    { 274, 71, "Correct Answer Not Present" },
                    { 275, 72, "2" },
                    { 276, 72, "6" },
                    { 277, 72, "Correct Answer Not Present" },
                    { 278, 73, "Hexagon" },
                    { 279, 73, "Both have the same" },
                    { 280, 73, "Neither" },
                    { 281, 73, "Correct Answer Not Present" },
                    { 282, 74, "Feathers" },
                    { 283, 74, "Stones" },
                    { 284, 74, "Neither" },
                    { 285, 74, "Correct Answer Not Present" },
                    { 286, 75, "WOOW" },
                    { 287, 75, "MOOM" },
                    { 288, 75, "POOL" },
                    { 289, 75, "Correct Answer Not Present" },
                    { 290, 76, "Red" },
                    { 291, 76, "Yellow" },
                    { 292, 76, "Lost" },
                    { 293, 76, "Correct Answer Not Present" },
                    { 294, 77, "55" },
                    { 295, 77, "70" },
                    { 296, 77, "50" },
                    { 297, 77, "Correct Answer Not Present" },
                    { 298, 78, "Cheese" },
                    { 299, 78, "Meat" }
                });

            migrationBuilder.InsertData(
                table: "WrongAnswers",
                columns: new[] { "Id", "QuestionId", "WrongAns" },
                values: new object[,]
                {
                    { 300, 78, "Eggs" },
                    { 301, 78, "Correct Answer Not Present" },
                    { 302, 79, "A toy" },
                    { 303, 79, "A book" },
                    { 304, 79, "A song" },
                    { 305, 79, "Correct Answer Not Present" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CorrectAnswers_QuestionId",
                table: "CorrectAnswers",
                column: "QuestionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WrongAnswers_QuestionId",
                table: "WrongAnswers",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CorrectAnswers");

            migrationBuilder.DropTable(
                name: "UserRefreshTokens");

            migrationBuilder.DropTable(
                name: "WrongAnswers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
