namespace VioPliroforikh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'50c405cc-457d-4b79-95b2-2ca95a0756d7', N'd_pap@gmail.com', 0, N'ADmnoz/2mTTlLNuaN/7A1XmmZw5zzXc3wuPwu/Mzy3t6iOrpqzWcoKfccLhNtaMscg==', N'0a7bb2d6-4738-4d44-bcea-a02052890c41', NULL, 0, 0, NULL, 1, 0, N'd_pap@gmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bead2f13-2598-4576-9255-a17d12555823', N'admin@gmail.com', 0, N'AMkXnUO28OHnGA1BTi5lCU0KxU2agKPSDOEJAEQ9i6MukY8UViumvTVyh/wBT+pHUw==', N'824482dc-d72b-410f-8dcc-e435273f43d1', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'239b20eb-b51c-45a7-bd3e-d0858fdd8640', N'ApplicationAdmin')
                
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bead2f13-2598-4576-9255-a17d12555823', N'239b20eb-b51c-45a7-bd3e-d0858fdd8640')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
