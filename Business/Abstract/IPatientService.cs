using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IPatientService
	{
		IResult Add(Patient patient);
		IResult Update(Patient patient);
		IResult Delete(Patient patient);
		IDataResult<Patient> GetById(Patient patient);
		IDataResult<IList<Patient>> GetAll(Patient patient);

	}
}
