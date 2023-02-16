using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EfCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessModule
{
	public class AutofacModule :Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			/*
			var proxyOptions = new ProxyGenerationOptions
			{
				Selector = new AspectInterceptorSelector()
			};*/

			builder.RegisterType<EfAppointmentDal>().As<IAppointmentDal>().AsImplementedInterfaces().SingleInstance();
			builder.RegisterType<EfPatientDal>().As<IPatientDal>().AsImplementedInterfaces().SingleInstance();
			builder.RegisterType<EfUserDal>().As<IUserDal>().AsImplementedInterfaces().SingleInstance();
			builder.RegisterType<UserManager>().As<IUserService>().AsImplementedInterfaces().SingleInstance();
			builder.RegisterType<PatientManager>().As<IPatientService>().AsImplementedInterfaces().SingleInstance();
			builder.RegisterType<AppointmentManager>().As<IAppointmentService>().AsImplementedInterfaces().SingleInstance();


		}
	}
}
