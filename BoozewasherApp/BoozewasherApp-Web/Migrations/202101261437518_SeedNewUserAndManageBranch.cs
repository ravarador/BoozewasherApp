namespace BoozewasherApp_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedNewUserAndManageBranch : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName]) VALUES (N'90d3901e-8cde-4e55-9829-7621b882b05b', N'admin@boozewasher.com', 0, N'ADGmwEjSwulrWnVxmUm/cUcfdUJ/JkLeO88+3jXxDLKOjcEFSezNFdtTOHNBzGfSMg==', N'898c96b1-5a31-4c3f-8b2b-a4f238194761', NULL, 0, 0, NULL, 1, 0, N'admin@boozewasher.com', N'Denise', N'Villacorta')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName]) VALUES (N'fc56eba0-100a-407d-8a7d-6d625103fa13', N'guest@boozewasher.com', 0, N'AAnKYgML9fW7sPr50NQsYv2TC9jrpbpGpWMg36R2C6X2nuLfTK1IX8ur8G61WiA8Tg==', N'b8c800f0-bc16-430c-a0f6-f4e7ad80a2e1', NULL, 0, 0, NULL, 1, 0, N'guest@boozewasher.com', NULL, NULL)

                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'03724dc1-e669-4965-b10b-62d202e1aee9', N'CanManageBranches')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bcaec877-c09f-4f45-9d4e-8da5677c9551', N'CanManageItems')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'dbaac073-6ac0-489a-9c82-aac94e8f9d05', N'CanManageServices')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c7e1c116-0593-46e3-9999-21df656d6cb3', N'CanManageTransactions')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4f5afa75-1da3-4ce1-b3a9-05949cdb3822', N'CanManageVehicles')
                  
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'90d3901e-8cde-4e55-9829-7621b882b05b', N'03724dc1-e669-4965-b10b-62d202e1aee9')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'90d3901e-8cde-4e55-9829-7621b882b05b', N'4f5afa75-1da3-4ce1-b3a9-05949cdb3822')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'90d3901e-8cde-4e55-9829-7621b882b05b', N'bcaec877-c09f-4f45-9d4e-8da5677c9551')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'90d3901e-8cde-4e55-9829-7621b882b05b', N'c7e1c116-0593-46e3-9999-21df656d6cb3')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'90d3901e-8cde-4e55-9829-7621b882b05b', N'dbaac073-6ac0-489a-9c82-aac94e8f9d05')


           ");
        }
        
        public override void Down()
        {
        }
    }
}
