using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract
{
	public interface IAppointmentService
	{
		IDataResult<List<Appointment>> GetAllByPatientId(int patinetId);
		IDataResult<Appointment> GetById(int id);
		IResult Add(Appointment appointment);
		IResult Delete(Appointment appointment);
		IResult Update(Appointment appointment);
		IDataResult<List<Appointment>> GetAllByDoctorId(int doctorId);
	}


}
