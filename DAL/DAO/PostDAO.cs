using System.Collections.Generic;
using System.Linq;
using Entities;
using Entities.Models;

namespace DAL.DAO
{
	public class PostDAO
	{
		private BlogContext context;

		public PostDAO(BlogContext context)
		{
			this.context = context;
		}

		public List<PostEntity> List()
		{
			return context.Posts.ToList<PostEntity>();
		}
	}
}