using Core.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Appointment :IEntity
	{
		
		public int Id { get; set; }
		public string Description { get; set; }
		public DateTime Date { get; set; }
		public bool Status { get; set; }
		public int PatientId { get; set; }
		public int DoctorId { get; set; }
		public string? Time { get; set; }
		private Patient Patient  { get; set; }
		public Doctor Doctor { get; set; }
	}
}