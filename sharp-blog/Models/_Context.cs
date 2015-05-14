using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace sharp_blog.Models
{
	public class Context : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Comment> Comments { get; set; }

		public Context() : base("SharpBlog")
		{
			Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}