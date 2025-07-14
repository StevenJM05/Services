using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Exceptions
{
	public class UserException : DomainException<UserExceptionType>
	{
		protected UserException(UserExceptionType type, string field, Type obj, string message)
			: base(type, field, obj, message)
		{
		}

		public static UserException Create(UserExceptionType type, string field, Type obj, string? message = null)
		{
			return new UserException(type, field, obj, message ?? GetMessage(type, field, obj));
		}
	}
	public enum UserExceptionType
	{
		RequiredField = 1,
		InvalidEmail = 2,
		EmailAlreadyExists = 3,
		PasswordTooWeak = 4,
		RoleInvalid = 5
	}
}
