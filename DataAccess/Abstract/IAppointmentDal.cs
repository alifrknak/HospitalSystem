using Core.DataAccess.EntityFramework;
using Entity.Concrete;

namespace DataAccess.Abstract
{
	public interface IAppointmentDal : IEntityRepository<Appointment>
	{

	}

}
