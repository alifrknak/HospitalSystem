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
	public partial class UserManager : IUserService
	{
		IUserDal _userDal;

		public UserManager(IUserDal userDal)
		{
			_userDal = userDal;
		}

		public IResult Add(User user)
		{
			_userDal.Add(user);
			return new SuccessResult();
		}

		public IResult Delete(User user)
		{
			_userDal.Delete(user);
			return new SuccessResult();
		}

		public IDataResult<User> GetById(int userId)
		{
			return new SuccessDataResult<User>(_userDal.Get(q => q.Id == userId));
		}

		public IDataResult<User> GetByUserName(string userName)
		{
			return new SuccessDataResult<User>(_userDal.Get(q => q.UserName == userName));
		}

		public IDataResult<int> GetLastUser()
		{
			return new SuccessDataResult<int>(_userDal.GetAll().Max(q=> q.Id));
		}

		public IResult Update(User user)
		{
			_userDal.Update(user);
			return new SuccessResult();
		}
	}
}
