using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sharp_blog.Models
{
	public class Category
	{
		public int ID { get; set; }

		[Required]
		[StringLength(200)]
		public string Name { get; set; }

		public virtual ICollection<Post> Posts { get; set; }
	}
}