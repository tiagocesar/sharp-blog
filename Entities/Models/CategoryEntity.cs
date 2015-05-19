using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
	[Table("Categories")]
	public class CategoryEntity
	{
		public int ID { get; set; }

		[Required]
		[StringLength(200)]
		public string Name { get; set; }

		public virtual ICollection<PostEntity> Posts { get; set; }
	}
}