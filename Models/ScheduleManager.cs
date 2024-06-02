namespace ScheduleCurseWork.Models
{

	public class ScheduleManager
	{
		public ScheduleManager()
		{
			AllEvents = new List<Event>();
			FillTessst(2);
		}
		public List<Event> AllEvents;

		public void FillTessst(int n)
		{
			AllEvents.Clear();
			for (int i = 0; i < n; i++)
			{
				AllEvents.Add(new Event
				{
					Id = i,
					Title = $"Title{i}",
					Description = $"Description{i}",
					DateOfStarting = DateTime.Now,
					Duration = 1000,
					Location = $"Location{i}",
				});
			}
		}
		// Додавання подій
		//
		public void AddEvent(string title, string description, string location, DateTime starts, int duration)
		{
			AllEvents.Add(new Event
			{
				Id = AllEvents[^1].Id + 1,
				Title = title,
				Description = description,
				Location = location,
				DateOfStarting = starts,
				Duration = duration,
			});
		}

		// Пошук подій
		//
		public List<Event> SearchByDate(DateTime dt)
		{
			List<Event> sortedEvents = new List<Event>();
			foreach (Event e in AllEvents)
			{
				if (!e.IsDone && !e.IsMissed && dt.Date==DateTime.MinValue)
				{
					sortedEvents.Add(e);
				}else if(!e.IsDone && !e.IsMissed && dt.Date == DateTime.Now.Date)
				{
					sortedEvents.Add(e);
				}
			}
			return sortedEvents;
		}


		// Пошук найближчої події
		//
		public Event SearchNearest()
		{
			List<Event> sortedEvents = AllEvents.OrderBy(ev => ev.DateOfStarting).ToList();

			foreach (var e in sortedEvents)
			{
				if (!e.IsMissed && e.IsDone)
				{
					return e;
				}
			}
			throw new Exception("Did not find any current events.");
		}
	}
}