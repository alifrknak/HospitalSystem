using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class DoctorManager : IDoctorService
	{
		readonly IDoctorDal _doctorDal;

		public DoctorManager(IDoctorDal doctorDal)
		{
			_doctorDal = doctorDal;
		}

		public IResult Add(Doctor doctor)
		{
			_doctorDal.Add(doctor);

			return new SuccessResult();
		}

		public IResult Delete(Doctor doctor)
		{
			_doctorDal.Delete(doctor);
			return new SuccessResult();
		}

		public IDataResult<Doctor> GetById(int doctorId)
		{
			return new SuccessDataResult<Doctor>(_doctorDal.Get(q => q.UserId == doctorId));
		}

		public IResult Update(Doctor doctor)
		{
			_doctorDal.Update(doctor);
			return new SuccessResult();
		}
	}
}
