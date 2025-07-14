namespace Services.Domain.Exceptions
{
	public class DomainException<TEnum> : Exception where TEnum : Enum
	{
		public TEnum  ExceptionType { get; set; }
		public string RelatedField { get; set; }
		public Type RelatedObject { get; set; }

		protected DomainException(TEnum exceptionType, string relatedField, Type relatedObject, string message)
			: base(message)
		{
			ExceptionType = exceptionType;
			RelatedField = relatedField;
			RelatedObject = relatedObject;
		}

		protected static string GetMessage(TEnum type, string field, Type obj)
		{
			return $"Error '{type}' in field '{field}' on '{obj.Name}'";
		}
	}
}
