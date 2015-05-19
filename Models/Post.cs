using System;

namespace Models
{
	public class Post
	{
		public int ID { get; set; }
		public int UserID { get; set; }
		public int CategoryID { get; set; }

		public string Name { get; set; }

		public DateTime DatePublished { get; set; }

		public bool Visible { get; set; }

		public string Content { get; set; }
	}
}