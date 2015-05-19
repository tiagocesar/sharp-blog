using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Entities.Models;

namespace Entities
{
	public class BlogContext : DbContext
	{
		public DbSet<UserEntity> Users { get; set; }
		public DbSet<CategoryEntity> Categories { get; set; }
		public DbSet<PostEntity> Posts { get; set; }
		public DbSet<CommentEntity> Comments { get; set; }

		public BlogContext() : base("SharpBlog")
		{
			Database.SetInitializer<BlogContext>(new CreateDatabaseIfNotExists<BlogContext>());
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}