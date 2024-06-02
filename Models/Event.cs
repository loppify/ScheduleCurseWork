namespace ScheduleCurseWork.Models
{

	public class Event
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Location { get; set; }
		public DateTime DateOfStarting { get; set; }
		public int Duration { get; set; }
		public bool IsDone { get; set; } = false;
		public bool IsMissed { get; set; } = false;
	}
}