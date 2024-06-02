using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleCurseWork.Models
{
	internal class NoNearestEventException : Exception
	{
		public NoNearestEventException() : base("Did not find nearest event.")  
		{
		}
		public NoNearestEventException(string message) : base(message)
		{
		}
		public NoNearestEventException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
