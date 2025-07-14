using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Exceptions
{
	public class NotFoundException : Exception
	{
		public string EntityName { get; }
		public object Key { get; }

		public NotFoundException(string entityName, object key)
			: base($"Entity '{entityName}' with key '{key}' was not found.")
		{
			EntityName = entityName;
			Key = key;
		}
	}
}
