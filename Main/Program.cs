using Autofac;
using Business.Abstract;
using Business.BusinessModule;
using Business.Concrete;
using DataAccess.Concrete.EfCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Main
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var builder = new ContainerBuilder();
			builder.RegisterModule(new AutofacModule());
			var r = builder.Build();

			AuthManager authManager = new AuthManager(new UserManager(new EfUserDal()),new PatientManager(new EfPatientDal(),new UserManager(new EfUserDal())));
			AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentDal());
			
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1(authManager, appointmentManager));
		
		}
	}
}