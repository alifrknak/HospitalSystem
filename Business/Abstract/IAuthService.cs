using Core.Utilities;
using Core.Utilities.Results;
using Entity.Concrete;
using Entity.Dto;

namespace Business.Abstract
{
	public interface IAuthService
	{
		IDataResult<User> CheckUser(LoginUser loginUser);
		public IDataResult<User> CreateUser(UserRecord userRecord);

		
	}
}