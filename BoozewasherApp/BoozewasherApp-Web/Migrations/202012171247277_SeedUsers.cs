namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'355db182-1d09-4695-ac27-3a04096b0325', N'admin@boozewasher.com', 0, N'AOy3icouE5xClTU8nvSN9VdSFTubMHdTb0IjMmsMJmUwPBv1NQBlmXaMpGZz/xxfIA==', N'd5dab1f4-6ca7-462c-b1c0-10e9960e0ba0', NULL, 0, 0, NULL, 1, 0, N'admin@boozewasher.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fc56eba0-100a-407d-8a7d-6d625103fa13', N'guest@boozewasher.com', 0, N'AAnKYgML9fW7sPr50NQsYv2TC9jrpbpGpWMg36R2C6X2nuLfTK1IX8ur8G61WiA8Tg==', N'b8c800f0-bc16-430c-a0f6-f4e7ad80a2e1', NULL, 0, 0, NULL, 1, 0, N'guest@boozewasher.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4f5afa75-1da3-4ce1-b3a9-05949cdb3822', N'CanManageVehicles')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'355db182-1d09-4695-ac27-3a04096b0325', N'4f5afa75-1da3-4ce1-b3a9-05949cdb3822')

");
        }
        
        public override void Down()
        {
        }
    }
}
