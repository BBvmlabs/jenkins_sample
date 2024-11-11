using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models.Task_4
{
	public class DB_Model1
	{
		[Key]
        public int ID { get; set; }
		[Required]
		[StringLength(50)]
		[DisplayName("Name")]
		public string Name { get; set; }
		[Required]
		public int Age { get; set; }
		public string city { get; set; }
    }
}
