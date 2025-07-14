using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Exceptions
{
	public class ForbiddenException : Exception
	{
		public ForbiddenException(string message = "You do not have permission to access this resource.")
			: base(message)
		{
		}
	}
}
