
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EfCore;
using Entity.Concrete;



PatientManager manager = new PatientManager(new EfPatientDal(),new EfUserDal());

manager.Add(new Patient()
{
	
}) ;


Console.WriteLine("eklendi.");