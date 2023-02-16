using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
	public class AppointmentManager : IAppointmentService
	{
		readonly IAppointmentDal _appointmentDal;

		public AppointmentManager(IAppointmentDal appointmentDal)
		{
			_appointmentDal = appointmentDal;
		}

		public IResult Add(Appointment appointment)
		{
			_appointmentDal.Add(appointment);
			return new SuccessResult();
		}

		public IResult Delete(Appointment appointment)
		{
			_appointmentDal.Delete(appointment);
			return new SuccessResult();

		}

		public IDataResult<Appointment> GetById(int id)
		{
			return new  SuccessDataResult<Appointment>(_appointmentDal.Get(q => q.Id == id));
		}

		public IDataResult<List<Appointment>> GetAllByPatientId(int patinetId)
		{
			return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll(q=> q.PatientId == patinetId));
		}

		public IResult Update(Appointment appointment)
		{
			_appointmentDal.Update(appointment);
			
			return new SuccessResult();
		}

		public IDataResult<List<Appointment>> GetByDay(int day)
		{
			return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll(q => q.Date.Day == day));
		}

		public IDataResult<List<Appointment>> GetAllByDoctorId(int doctorId)
		{
			return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll(q => q.DoctorId == doctorId));
		}
	}
}
