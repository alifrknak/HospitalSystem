using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Patient :IEntity
	{
		[Key]	
		public int UserId { get; set; }
		private ICollection<Appointment>  Appointments { get; set; }
		public User user { get; set; }
	}
}