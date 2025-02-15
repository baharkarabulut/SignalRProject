using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.CategoryDto
{
	public class CreateCategoryDto
	{
		[Required]
		public string Name { get; set; }  // EKLENDİ
		public string CategoryName { get; set; }
		public bool Status { get; set; }

	}
}
