using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Doctor :IEntity
	{
		[Key]
		public int UserId { get; set; }
		public int DepartmentId { get; set; }
		public Department Department { get; set; }
		public Appointment Appointment { get; set; }
	}
}
