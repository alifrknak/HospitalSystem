using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IUserService
	{
		IResult Add(User user);
		IResult Update(User user);
		IResult Delete(User user);
		IDataResult<User> GetById(int userId);
		IDataResult<int> GetLastUser();
		IDataResult<User> GetByUserName(string userName);
		
	}
}
