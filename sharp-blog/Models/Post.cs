using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sharp_blog.Models
{
	public class Post
	{
		public int ID { get; set; }
		public int UserID { get; set; }
		public int CategoryID { get; set; }

		[Required]
		[StringLength(200)]
		public string Name { get; set; }

		[Required]
		public DateTime DatePublished { get; set; }

		[Required]
		public bool Visible { get; set; }

		[Required]
		public string Content { get; set; }

		public virtual User User { get; set; }
		public virtual Category Category { get; set; }
		public virtual ICollection<Comment> Comments { get; set; }

		public Post()
		{
			this.DatePublished = DateTime.Now;
			this.Visible = false;
		}
	}
}