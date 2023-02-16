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
	public class PatientManager : IPatientService
	{
		readonly IPatientDal _patientDal;
		readonly IUserService _userService;


		public PatientManager(IPatientDal patientDal, IUserService userService)
		{
			_patientDal = patientDal;
			_userService = userService;
		}

		public IResult Add(Patient patient)
		{
			patient.UserId = _userService.GetLastUser().Data;
			
			_patientDal.Add(patient);
			
			return new  SuccessResult();
		
		}

		public IResult Delete(Patient patient)
		{
			throw new NotImplementedException();
		}

		public IDataResult<IList<Patient>> GetAll(Patient patient)
		{
			throw new NotImplementedException();
		}

		public IDataResult<Patient> GetById(Patient patient)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Patient patient)
		{
			throw new NotImplementedException();
		}
	}
}
