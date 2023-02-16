using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EfCore
{
	public class HospitalContext : DbContext 
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=hospital;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
		}

		public DbSet<Patient> Patients { get; set; }
		public DbSet<Appointment> Appointments { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Department> Departments { get; set; }
	}
}
