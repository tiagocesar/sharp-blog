using System;

namespace Models
{
	public class Comment
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public string Content { get; set; }

		public DateTime DatePublished { get; set; }

		public bool Visible { get; set; }
	}
}