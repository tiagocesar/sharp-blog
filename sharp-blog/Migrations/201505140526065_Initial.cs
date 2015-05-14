namespace sharp_blog.Migrations
{
	using System;
	using System.Data.Entity.Migrations;
	
	public partial class Initial : DbMigration
	{
		public override void Up()
		{
			CreateTable(
				"dbo.Category",
				c => new
					{
						ID = c.Int(nullable: false, identity: true),
						Name = c.String(nullable: false, maxLength: 200),
					})
				.PrimaryKey(t => t.ID);
			
			CreateTable(
				"dbo.Post",
				c => new
					{
						ID = c.Int(nullable: false, identity: true),
						UserID = c.Int(nullable: false),
						CategoryID = c.Int(nullable: false),
						Name = c.String(nullable: false, maxLength: 200),
						DatePublished = c.DateTime(nullable: false),
						Visible = c.Boolean(nullable: false),
						Content = c.String(nullable: false),
					})
				.PrimaryKey(t => t.ID)
				.ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: false)
				.ForeignKey("dbo.User", t => t.UserID, cascadeDelete: false)
				.Index(t => t.UserID)
				.Index(t => t.CategoryID);
			
			CreateTable(
				"dbo.Comment",
				c => new
					{
						ID = c.Int(nullable: false, identity: true),
						Name = c.String(nullable: false),
						Email = c.String(nullable: false),
						Content = c.String(nullable: false),
						DatePublished = c.DateTime(nullable: false),
						Visible = c.Boolean(nullable: false),
						Post_ID = c.Int(),
						User_ID = c.Int(),
					})
				.PrimaryKey(t => t.ID)
				.ForeignKey("dbo.Post", t => t.Post_ID)
				.ForeignKey("dbo.User", t => t.User_ID)
				.Index(t => t.Post_ID)
				.Index(t => t.User_ID);
			
			CreateTable(
				"dbo.User",
				c => new
					{
						ID = c.Int(nullable: false, identity: true),
						Name = c.String(nullable: false, maxLength: 200),
						Email = c.String(nullable: false, maxLength: 200),
						Password = c.String(nullable: false),
						Avatar = c.String(nullable: false),
					})
				.PrimaryKey(t => t.ID);
			
		}
		
		public override void Down()
		{
			DropForeignKey("dbo.Post", "UserID", "dbo.User");
			DropForeignKey("dbo.Comment", "User_ID", "dbo.User");
			DropForeignKey("dbo.Comment", "Post_ID", "dbo.Post");
			DropForeignKey("dbo.Post", "CategoryID", "dbo.Category");
			DropIndex("dbo.Comment", new[] { "User_ID" });
			DropIndex("dbo.Comment", new[] { "Post_ID" });
			DropIndex("dbo.Post", new[] { "CategoryID" });
			DropIndex("dbo.Post", new[] { "UserID" });
			DropTable("dbo.User");
			DropTable("dbo.Comment");
			DropTable("dbo.Post");
			DropTable("dbo.Category");
		}
	}
}