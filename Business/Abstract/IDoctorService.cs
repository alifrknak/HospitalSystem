using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IDoctorService
	{
		IResult Add(Doctor doctor);
		IResult Delete(Doctor doctor);
		IResult Update(Doctor doctor);
		IDataResult<Doctor> GetById(int doctorId);
	}
}
