using System;
using System.ComponentModel.DataAnnotations;

namespace sharp_blog.Models
{
	public class Comment
	{
		public int ID { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Email { get; set; }
		
		[Required]
		public string Content { get; set; }

		[Required]
		public DateTime DatePublished { get; set; }

		[Required]
		public bool Visible { get; set; }

		public virtual Post Post { get; set; }

		public Comment()
		{
			this.DatePublished = DateTime.Now;
			this.Visible = false;
		}
	}
}