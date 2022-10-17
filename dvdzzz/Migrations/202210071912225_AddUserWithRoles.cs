namespace dvdzzz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserWithRoles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'017cbd51-6088-4214-bbca-ce6c51a2ccc2', N'admin@dvdzzz.com', 0, N'ACsSM08h1t+/8bq0+e2Iq9GeVe9O06M108B6pmhaYfAoH9Ac2OiLjSgBDm+FS3TH+g==', N'8e5007e0-bc3f-4545-95a4-b0753035ac77', NULL, 0, 0, NULL, 1, 0, N'admin@dvdzzz.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'54ec534f-0984-442b-9cd9-68c0b91dcea7', N'movieman@gmail.com', 0, N'AJ0pRkNyhVcR+c7af5gw13dPKHq2XOYPx1PPpexea1hauohs0euInSemX/cjHqpRQw==', N'daf13f63-e226-4cf3-97b4-35691872b818', NULL, 0, 0, NULL, 1, 0, N'movieman@gmail.com')");
            Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f0a00fb5-3ca3-441b-acfa-ba3c9af4b419', N'CanManageMovies')");
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'017cbd51-6088-4214-bbca-ce6c51a2ccc2', N'f0a00fb5-3ca3-441b-acfa-ba3c9af4b419')");

        }
        
        public override void Down()
        {
        }
    }
}
