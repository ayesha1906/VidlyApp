namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8679df3c-c879-4faa-8c7d-03480e6e8c5a', N'guest@vidly.com', 0, N'AA45kvkY50T5Px6gsc/LJ4cR/Z1yDKyTpZO5Eb4vZKVn7vk9R/HheMqj2pnGHJfcOw==', N'5dd0703d-b438-4b61-b44c-9e24a27a5816', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c1dca610-8c34-4ef2-9dab-532791ac4267', N'admin@vidly.com', 0, N'AKwBDqjtvrlGYO0dXFBmpihO0U4ebX1xMji9dR88tlQUJZvTtgDyhYZV7hW1y+heWw==', N'e6635ddd-07a5-4c77-9931-f83423090b1a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'57a694bb-81d0-4827-9efb-2244f8ebb862', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c1dca610-8c34-4ef2-9dab-532791ac4267', N'57a694bb-81d0-4827-9efb-2244f8ebb862')

");
        }
        
        public override void Down()
        {
        }
    }
}
