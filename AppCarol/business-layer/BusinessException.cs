using System;
namespace AppCarol
{
	public class BusinessException : Exception
	{
		//
		// Constructors
		//
		public BusinessException()
		{
		}

		public BusinessException(string message)
		{
			Message = message;
		}

		public BusinessException(string message, Exception innerException)
		{
		}

		public String Message { get; set; }
	}
}
