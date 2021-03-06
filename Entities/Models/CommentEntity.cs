﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
	[Table("Comments")]
	public class CommentEntity
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

		public virtual PostEntity Post { get; set; }

		public CommentEntity()
		{
			this.DatePublished = DateTime.Now;
			this.Visible = false;
		}
	}
}