using System.Text.Json;
using System.Text.Json.Serialization;

namespace ScheduleCurseWork.Models
{

	public class ScheduleManager
	{
		public ScheduleManager()
		{
			AllEvents = new List<Event>();
		}
		[JsonInclude]
		public List<Event> AllEvents;
		private Event _nearestEvent;

		// тестове заповнення подіями
		public void FillTessst(int n)
		{
			AllEvents.Clear();
			for (int i = 0; i < n; i++)
			{
				AllEvents.Add(new Event
				{
					Id = i,
					Title = $"Title {i}",
					Description = $"Description {i}",
					DateOfStarting = DateTime.Now.AddHours(i - 3).AddSeconds(10),
					Duration = 1001,
					Location = $"Location {i}",
				});
			}
		}
		// Додавання подій
		//
		public void AddEvent(string title, string description, string location, DateTime starts, int duration)
		{
			int nextId = AllEvents.Count>0 ? AllEvents[^1].Id + 1 : 0;
			AllEvents.Add(new Event
			{
				Id = nextId,
				Title = title,
				Description = description,
				Location = location,
				DateOfStarting = starts,
				Duration = duration,
			});
		}
		private ScheduleManager MergeEventLists(ScheduleManager SM)
		{
			ScheduleManager mergedSM = new ScheduleManager();

			foreach (var e in SM.AllEvents)
			{
				int nextId = mergedSM.AllEvents.Count > 0 ? mergedSM.AllEvents[^1].Id + 1 : 0;
				e.Id = nextId;
				mergedSM.AllEvents.Add((Event)e);
			}
			foreach (var e in AllEvents)
			{
				int nextId = mergedSM.AllEvents.Count > 0 ? mergedSM.AllEvents[^1].Id + 1 : 0;
				e.Id = nextId;
				mergedSM.AllEvents.Add((Event)e);
			}
            return mergedSM;
		}
		// Оновлення актуальності події
		//
		public bool AllEventsStatusIsMissedUpdate()
		{
			try
			{
				foreach (Event ev in AllEvents)
				{

					if (ev.DateOfStarting < DateTime.Now && !ev.IsMissed)
					{
						ev.IsMissed = true;
						return true;

					}
					if (ev.DateOfStarting.AddDays(1).Date == DateTime.Now.Date && !ev.IsDone)
					{
						AllEvents.Remove(ev);
						return true;
					}
				}
			}
			catch (InvalidOperationException) { }
			return false;

		}

		// Пошук подій
		//
		public List<Event> SearchByDate(DateTime dt, bool includeAllEvents, bool overlap)
		{
			List<Event> sortedEvents = new List<Event>();
			if (!overlap)
			{
				foreach (Event e in AllEvents)
				{

					{
						if (includeAllEvents || (!e.IsDone && !e.IsMissed && dt.Date == DateTime.MinValue))
						{
							sortedEvents.Add(e);
						}
						else if (includeAllEvents || (!e.IsDone && !e.IsMissed) && dt.Date == e.DateOfStarting.Date)
						{
							sortedEvents.Add(e);
						}
					}
				}
			}
			else if (overlap)
			{
				for (int i = 0; i < AllEvents.Count; i++)
				{
					for (int j = i + 1; j < AllEvents.Count; j++)
					{
						if (AllEvents[i].DateOfStarting < AllEvents[j].DateOfStarting.AddSeconds(AllEvents[j].Duration)
							&& AllEvents[j].DateOfStarting < AllEvents[i].DateOfStarting.AddSeconds(AllEvents[i].Duration)
							&& !AllEvents[j].IsDone && !AllEvents[j].IsMissed && !AllEvents[i].IsDone && !AllEvents[i].IsMissed)
						{
							sortedEvents.Add(AllEvents[i]);
							sortedEvents.Add(AllEvents[j]);
							return sortedEvents;
						}
					}
				}
			}
			return sortedEvents;
		}


		// Найближча подія
		//
		public Event SearchNearest()
		{
			if (_nearestEvent == null || _nearestEvent.IsMissed || _nearestEvent.IsDone || !AllEvents.Contains(_nearestEvent))
			{
				List<Event> sortedEvents = SearchByDate(DateTime.MinValue, false, false);
				foreach (var e in sortedEvents)
				{
					if (!e.IsMissed && !e.IsDone)
					{
						_nearestEvent = e;
						return _nearestEvent;
					}
				}
				throw new NoNearestEventException();
			}
			return _nearestEvent;
		}
		// Найближча подія в форматі тексту
		//
		[JsonIgnore]
		public string SearchNearestString
		{
			get
			{
				try
				{
					_nearestEvent = SearchNearest();
				}
				catch (NoNearestEventException ex) { return ex.Message; }
				return $"{_nearestEvent.Title}\n" +
					$"{_nearestEvent.Description}\n" +
					$"{_nearestEvent.Location}\n" +
					$"{_nearestEvent.DateOfStarting}\n" +
					$"{ParseDurationToString(_nearestEvent.Duration)}\n" +
					$"Remaining time: {ParseDurationToString(_nearestEvent.DateOfStarting - DateTime.Now)}" ?? "Didn't find nex event";
			}
		}
		private string ParseDurationToString(TimeSpan duration)
		{
			int hours = Math.Min(duration.Hours, 99);
			int minutes = Math.Min(duration.Minutes, 59);
			int seconds = Math.Min(duration.Seconds, 59);

			return $"{hours:00}:{minutes:00}:{seconds:00}";
		}
		private string ParseDurationToString(int duration)
		{
			int hours = Math.Min(duration / 3600, 99);
			duration -= hours * 3600;
			int minutes = Math.Min(duration / 60, 59);
			duration -= minutes * 60;
			int seconds = Math.Min(duration, 59);

			return $"{hours:00}:{minutes:00}:{seconds:00}";
		}

		// вигрузка класу в файл
		public void saveData()
		{
			var jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
			File.WriteAllText(".\\save.json", jsonString);
		}

		// загрузка класу з файлу
		public ScheduleManager loadData()
		{
			string jsonString;
			try
			{
				jsonString = File.ReadAllText(".\\save.json");
			}catch (Exception ex) { 
				MessageBox.Show(ex.Message); 
				return new ScheduleManager(); 
			}
			
			return JsonSerializer.Deserialize<ScheduleManager>(jsonString);
		}

		// перевірка стану збереження класу
		public bool checkSave()
		{
			if (this == null) return false;
			var jsonString = JsonSerializer.Serialize(loadData(), new JsonSerializerOptions { WriteIndented = true });
			if (jsonString.Equals(File.ReadAllText(".\\save.json")))
			{
				return true;
			}
			return false;
		}
	}
}