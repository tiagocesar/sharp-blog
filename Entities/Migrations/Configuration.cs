using System.Data.Entity.Migrations;
using Entities.Models;

namespace Entities.Migrations
{
	internal sealed class Configuration : DbMigrationsConfiguration<BlogContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(BlogContext context)
		{
			//  This method will be called after migrating to the latest version.
		}
	}
}