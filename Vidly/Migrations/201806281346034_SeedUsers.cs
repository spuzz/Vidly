namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'597fab68-3f72-4fc8-8e7c-c55f758728d9', N'admin@vidly.com', 0, N'AKyIO8pVIa3XyqktdrJ9yvaoboHDNg/t/OuCQdaYmNRBdCP0mX5dUtI4Hlb3EjZONQ==', N'ca9f4c1f-aa73-460a-8cfe-6573440ccb42', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'aa7cb60a-2632-4070-b4d2-afd23ef75c22', N'test@vidl.com', 0, N'AASh5DKb9V/AMF6woKy9ZwArYJFbJCrb4XRqATuYnquWsq40/A2LTTt9ordjGxMdTA==', N'fd020c3f-911f-432e-8346-1720472276b2', NULL, 0, 0, NULL, 1, 0, N'test@vidl.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'aabc6d94-b700-4226-af51-815a48ef3c29', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'597fab68-3f72-4fc8-8e7c-c55f758728d9', N'aabc6d94-b700-4226-af51-815a48ef3c29')
");
        }
        
        public override void Down()
        {
        }
    }
}
