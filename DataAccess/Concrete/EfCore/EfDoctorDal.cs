using Core.DataAccess.EntityFramework.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EfCore
{
	public class EfDoctorDal: EfEntityRepositoryBase<Doctor,HospitalContext>
	{
	}
}
