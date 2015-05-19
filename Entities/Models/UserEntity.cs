using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
	[Table("Users")]
	public class UserEntity
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

		public virtual ICollection<PostEntity> Posts { get; set; }
		public virtual ICollection<CommentEntity> Comments { get; set; }
	}
}