namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedTableAspNetUsersAspNetRolesAspNetUserRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName]) VALUES (N'0248070e-6303-444e-b418-6b36e514156a', N'admin@boozewasher.com', 0, N'APGF+HbPGSlBN2ecjoMbFUsieDw5woLKeSteqSQTtDPRxrEzXVxCnhw8Pda3j29CUA==', N'0907d82d-05fb-4df7-b8d0-42af72545dbf', NULL, 0, 0, NULL, 1, 0, N'admin@boozewasher.com', N'Denise', N'Villacorta')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName]) VALUES (N'fc56eba0-100a-407d-8a7d-6d625103fa13', N'guest@boozewasher.com', 0, N'AAnKYgML9fW7sPr50NQsYv2TC9jrpbpGpWMg36R2C6X2nuLfTK1IX8ur8G61WiA8Tg==', N'b8c800f0-bc16-430c-a0f6-f4e7ad80a2e1', NULL, 0, 0, NULL, 1, 0, N'guest@boozewasher.com', NULL, NULL)

                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'03724dc1-e669-4965-b10b-62d202e1aee9', N'CanManageBranches')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8d8971c4-c076-4258-96de-408566bf7ac3', N'CanManageEmployees')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bcaec877-c09f-4f45-9d4e-8da5677c9551', N'CanManageItems')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'dbaac073-6ac0-489a-9c82-aac94e8f9d05', N'CanManageServices')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c7e1c116-0593-46e3-9999-21df656d6cb3', N'CanManageTransactions')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4f5afa75-1da3-4ce1-b3a9-05949cdb3822', N'CanManageVehicles')

                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0248070e-6303-444e-b418-6b36e514156a', N'03724dc1-e669-4965-b10b-62d202e1aee9')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0248070e-6303-444e-b418-6b36e514156a', N'4f5afa75-1da3-4ce1-b3a9-05949cdb3822')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0248070e-6303-444e-b418-6b36e514156a', N'8d8971c4-c076-4258-96de-408566bf7ac3')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0248070e-6303-444e-b418-6b36e514156a', N'bcaec877-c09f-4f45-9d4e-8da5677c9551')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0248070e-6303-444e-b418-6b36e514156a', N'c7e1c116-0593-46e3-9999-21df656d6cb3')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0248070e-6303-444e-b418-6b36e514156a', N'dbaac073-6ac0-489a-9c82-aac94e8f9d05')


            ");
        }
        
        public override void Down()
        {
        }
    }
}
