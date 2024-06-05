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
