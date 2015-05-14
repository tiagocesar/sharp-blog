namespace sharp_blog.Migrations
{
	using System.Data.Entity.Migrations;
	using sharp_blog.Models;

	internal sealed class Configuration : DbMigrationsConfiguration<sharp_blog.Models.Context>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(sharp_blog.Models.Context context)
		{
			//  This method will be called after migrating to the latest version.

			context.Categories.AddOrUpdate(
				c => c.Name,
				new Category { Name = "Undefined" }
			);
			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//
		}
	}
}