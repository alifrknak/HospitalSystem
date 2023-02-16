using Business.Abstract;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EfCore;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
		public class AuthManager : IAuthService
		{

		IUserService _userService;
		IPatientService _patientService;
		

		public AuthManager(IUserService userService, IPatientService patientService)
		{
			_userService = userService;
			_patientService = patientService;
		}

			public IDataResult<User> CreateUser(UserRecord userRecord)
			{
				byte[] pasword, passwordkey;

				User user = new User
				{
					FirstName = userRecord.FirstName,
					LastName = userRecord.LastName,
					UserName = userRecord.UserName,
					BirthDate = userRecord.BirthDate,
				};

				Hash.Hashing(userRecord.Password, out pasword, out passwordkey);
			
				user.Password = pasword;
				user.PasswordKey = passwordkey;

			_userService.Add(user);

			_patientService.Add(new Patient());

			return new SuccessDataResult<User>(user);
			}
		
			public IDataResult<User> CheckUser(LoginUser loginUser)
		{
			var rst = _userService.GetByUserName(loginUser.UserName);

			if (rst.Data is null)
			{
				return new ErrorDataResult<User>(null);
			}

			var Isvalid = Hash.Valid(loginUser.Password, rst.Data.Password, rst.Data.PasswordKey);

			if (!Isvalid)
			{
				return new ErrorDataResult<User>(null);
			}

			return new SuccessDataResult<User>(rst.Data);
		}

		
	}
}