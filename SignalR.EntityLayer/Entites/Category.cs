using System.ComponentModel.DataAnnotations;

namespace SignalR.EntityLayer.Entites
{
	public class Category
	{
		public int CategoryID { get; set; }
		[Required] // Boş olamaz
		public string Name { get; set; }

		public string CategoryName { get; set; }
		public bool Status { get; set; }
	}
}
