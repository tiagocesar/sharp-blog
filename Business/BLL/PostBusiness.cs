using System.Collections.Generic;
using DAL.DAO;
using Entities;
using Models;

namespace Business.BLL
{
	public static class PostBusiness
	{
		public static List<Post> List()
		{
			
			var postDAO = new PostDAO(new BlogContext());

			var postsEntity = postDAO.List();

			// Manual automapping for now, should be replace by AutoMapper
			var posts = new List<Post>();

			foreach(var item in postsEntity)
			{
				var post = new Post();

				post.ID = item.ID;
				post.UserID = item.UserID;
				post.CategoryID = item.CategoryID;
				post.Name = item.Name;
				post.DatePublished = item.DatePublished;
				post.Visible = item.Visible;
				post.Content = item.Content;

				posts.Add(post);
			}

			return posts;			
		}
	}
}