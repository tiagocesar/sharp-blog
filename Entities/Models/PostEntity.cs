using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
	[Table("Posts")]
	public class PostEntity
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

		public virtual UserEntity User { get; set; }
		public virtual CategoryEntity Category { get; set; }
		public virtual ICollection<CommentEntity> Comments { get; set; }

		public PostEntity()
		{
			this.DatePublished = DateTime.Now;
			this.Visible = false;
		}
	}
}