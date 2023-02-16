using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Department :IEntity
	{
		public int Id { get; set; }
		public int Name { get; set; }
		public ICollection<Doctor> Doctors { get; set; }
	}
}
