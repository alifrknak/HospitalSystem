using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
	public static class Hash
	{
		public static void Hashing(string password, out byte[] passWord, out byte[] passWordKey)
		{
			using (var h = new	System.Security.Cryptography.HMACSHA512())
			{
				passWordKey = h.Key;

				passWord = h.ComputeHash(Encoding.UTF8.GetBytes(password));
			}
		}

		public static bool Valid(string password, byte[] passWord, byte[] passWordKey) 
		{
			using (var h = new System.Security.Cryptography.HMACSHA512(passWordKey))
			{
				var valid = h.ComputeHash(Encoding.UTF8.GetBytes(password));

				for (int i = 0; i < valid.Length; i++)
					if (valid[i] != passWord[i])
						return false;
				
				return true;
			}
		} 
	}
}
