using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sharp_blog.Models
{
	public class User
	{
		public int ID { get; set; }
		
		[Required]
		[StringLength(200)]
		public string Name { get; set; }

		[Required]
		[StringLength(200)]
		public string Email { get; set; }
		
		[Required]
		public string Password { get; set; }
		
		[Required]
		public string Avatar { get; set; }

		public virtual ICollection<Post> Posts { get; set; }
		public virtual ICollection<Comment> Comments { get; set; }
	}
}