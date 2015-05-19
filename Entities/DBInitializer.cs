using System.Data.Entity;
using Entities.Models;

namespace Entities
{
	public class DBInitializer : CreateDatabaseIfNotExists<BlogContext>
	{
		protected override void Seed(BlogContext context)
		{
			context.Users.Add(new UsersEntity
			{
				Name = "Default user",
				Email = "me@someone.com",
				Password = "12345"
			});

			context.Categories.Add(new CategoriesEntity
			{
				Name = "General"
			});

			base.Seed(context);
		}
	}
}
