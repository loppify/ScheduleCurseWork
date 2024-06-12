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
		private List<Event> allEvents;
		private Event _nearestEvent;

		/// <summary>
		/// Тестове заповнення заходами
		/// </summary>
		/// <param name="n">Кількість нових заходів</param>
		public void FillTessst(int n)
		{
			// Очищення колекції заходів класу
			AllEvents.Clear();
			// Цикл, який додає заходи передану кількість разів
			for (int i = 0; i < n; i++)
			{
				// Додавання заходу
				AllEvents.Add(new Event
				{
					Id = i, // Ідентифікатор заходу
					Title = $"Title {i}", // Назва заходу
					Description = $"Description {i}", // Опис заходу
					DateOfStarting = DateTime.Now.AddHours(i - 3).AddSeconds(10), // Дата і час початку заходу
					Duration = 1001, // Тривалість заходу
					Location = $"Location {i}", // Місце проведення заходу
				});
			}
		}
		/// <summary>
		/// Додавання заходів до колекції
		/// </summary>
		/// <param name="title">Назва заходу</param>
		/// <param name="description">Опис заходу</param>
		/// <param name="location">Місце проведення заходу</param>
		/// <param name="starts">Дата та час початку заходу</param>
		/// <param name="duration">Тривалість заходу</param>
		public void AddEvent(string title, string description, string location, DateTime starts, int duration)
		{
			// Наступний Id заходу встановлюється залежно від Id останнього заходу, або 0, якщо їх ще не додано
			int nextId = AllEvents.Count > 0 ? AllEvents[^1].Id + 1 : 0;
			// Створення нового заходу за переданими даними
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

		/*private ScheduleManager MergeEventLists(ScheduleManager SM)
		{
			ScheduleManager mergedSM = new();

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
		}*/

		/// <summary>
		/// Зміна стану "пропущено" для заходів
		/// </summary>
		/// <returns><see cref="bool"/>, що вказує чи відбулися зміни</returns>
		public bool AllEventsStatusIsMissedUpdate()
		{
			// Змінна для кінцевого результату обходу для повернення
			bool result = false;
			// Уникнення помилки видалення заходу, якщо його вже не існує
			try
			{
				// Цикл обходу по всім заходам колекції
				foreach (Event ev in AllEvents)
				{
					// Перевіркаактуальності заходу,
					// тобто, якщо захід ще без помітки "пропущено" і "виконано" та має дату початку меншу, за поточний час
					if (ev.DateOfStarting < DateTime.Now && !ev.IsMissed && !ev.IsDone)
					{
						// Встановлюється поміка, що захід пропущено і результат обходу true для оновлення таблиці заходів
						ev.IsMissed = true;
						result = true;

					}
					else if (ev.DateOfStarting > DateTime.Now && ev.IsMissed) // Захід було перенесено
					{
						// Поміка, що захід пропущено вимикається і результат обходу true для оновлення таблиці заходів
						ev.IsMissed = false;
						result = true;
					}
					// Умова видалення заходу, який було просрочено минулого дня і не помічено як "виконано"
					if (ev.DateOfStarting.AddDays(1).Date < DateTime.Now.Date && !ev.IsDone)
					{
						// Видалення заходу з колекції із результатом обходу для оновлення таблиці заходів
						AllEvents.Remove(ev);
						result = true;
					}
				}
			}
			catch (InvalidOperationException) { } // Ловимо виняток 
												  // Повертаємо результат обходу для оновлення таблиці заходів
			return result;

		}

		/// <summary>
		/// Фільтрація заходів
		/// </summary>
		/// <param name="dt">Дата для фільтрації; для вимкнення слід передати <see langword="DateTime.MinValue"/></param>
		/// <param name="includeAllEvents"><see langword="true"/>, щоб показати також зроблені та пропущені заходи </param>
		/// <param name="overlap"><see langword="true"/>, щоб показати тільки накладені 2 заходи (Режим "накладок")</param>
		/// <returns>Колекція <see cref="List{Event}"/> заходів починаючи із першого доданого заходу</returns>
		public List<Event> EventFilter(DateTime dt, bool includeAllEvents, bool overlap)
		{
			// Створюємо нову колекцію заходів, який наповняється сортованими заходами
			List<Event> sortedEvents = new();
			// Умова "сортування накладок не потрібне"
			if (!overlap)
			{
				// Цикл обходу заходів
				foreach (Event e in AllEvents)
				{
					// Умова виконується якщо:
					// треба повернути заходи, які включають зроблені та пропущені
					// треба повернути незроблені, не пропущені та без сортування по даті (детальніше, дивись у параметрах методу)
					if (includeAllEvents || (!e.IsDone && !e.IsMissed && dt.Date == DateTime.MinValue))
					{
						// Умови виконано - додаємо захід
						sortedEvents.Add(e);
					}
					// Наступна умова виконується якщо:
					// треба повернути заходи, які включають зроблені та пропущені
					// треба повернути незроблені, не пропущені та з сортування по даті
					else if (includeAllEvents || (!e.IsDone && !e.IsMissed) && dt.Date == e.DateOfStarting.Date)
					{
						// Умови виконано - додаємо захід
						sortedEvents.Add(e);
					}
				}
			}
			// Якщо треба повернути тільки накладки (додаткова умова для можливості розширення методу сортування)
			else if (overlap)
			{
				// Цикл проходу по повній колекції заходів
				for (int i = 0; i < AllEvents.Count; i++)
				{
					//Цикл проходу по заходам після заходу з індексом і
					for (int j = i + 1; j < AllEvents.Count; j++)
					{
						// Умова виконується якщо виконуються ВСІ умови:
						// початок заходу і раніше кінця (час початку + тривалість) заходу j
						// початок заходу j раніше кінця (час початку + тривалість) заходу i
						// захід i не пропущено
						// захід i не виконано
						// захід j не пропущено
						// захід j не виконано
						if (AllEvents[i].DateOfStarting < AllEvents[j].DateOfStarting.AddSeconds(AllEvents[j].Duration)
							&& AllEvents[j].DateOfStarting < AllEvents[i].DateOfStarting.AddSeconds(AllEvents[i].Duration)
							&& !AllEvents[j].IsDone && !AllEvents[j].IsMissed && !AllEvents[i].IsDone && !AllEvents[i].IsMissed)
						{
							// Додаємо оба заходи і повертаємо колекцію з ними
							sortedEvents.Add(AllEvents[i]);
							sortedEvents.Add(AllEvents[j]);
							return sortedEvents;
						}
					}
				}
			}
			// Повертаємо порожній колекцію, якщо умов для сортування немає
			return sortedEvents;
		}


		/// <summary>
		/// Пошук найближчого заходу
		/// </summary>
		/// <returns>Найближчий <see cref="Event"/></returns>
		/// <exception cref="NoNearestEventException"></exception>
		public Event SearchNearest(bool changed)
		{
			// Перевірка актуальності найближчого заходу, тобто якщо найближчий захід:
			// ще не визначений
			// пропущений
			// зроблений
			// не міститься у колекції всіх заходів
			if (NearestEvent == null || NearestEvent.IsMissed || NearestEvent.IsDone || !AllEvents.Contains(NearestEvent) || changed)
			{
				// Створюємо нову колекцію відфільтрованих від виконаних і пропущених заходів в порядку зростання по даті
				List<Event> sortedEvents = AllEvents.Where(v => !v.IsMissed && !v.IsDone).OrderBy(v => v.DateOfStarting).ToList();
				// Якщо є заходи, відповідаюсі умовам
				if (sortedEvents.Count > 0)
				{
					// Присвоюємо поточний найблмжчий захід
					NearestEvent = sortedEvents[0];
					// Повертаємо новий поточний захід
					return NearestEvent;
				}
				throw new NoNearestEventException(); // Викидаємо виняток про відсутність найближчого заходу
			}
			// Повертаємо поточний найближчий захід, якщо він не змінився
			return NearestEvent;
		}

		[JsonIgnore]
		public string SearchNearestString
		{
			get
			{
				try
				{
					NearestEvent = SearchNearest(false);
				}
				catch (NoNearestEventException ex) { return ex.Message; }
				return $"{NearestEvent.Title}\n" +
					$"{NearestEvent.Description}\n" +
					$"{NearestEvent.Location}\n" +
					$"{NearestEvent.DateOfStarting}\n" +
					$"{ParseDurationToString(NearestEvent.Duration)}\n" +
					$"Remaining time: {ParseDurationToString(NearestEvent.DateOfStarting - DateTime.Now)}" ?? "Didn't find nex event";
			}
		}

		/// <summary>
		/// <see cref="List{}"/> усіх заходів
		/// </summary>
		[JsonIgnore]
		public List<Event> AllEvents { get => allEvents; set => allEvents = value; }
		/// <summary>
		/// Найближчий захід
		/// </summary>
		[JsonIgnore]
		public Event NearestEvent { get => _nearestEvent; set => _nearestEvent = value; }
		/// <summary>
		/// Шлях і назва файлу збереження
		/// </summary>
		[JsonIgnore]
		public string SAVE_PATH { get => _save_path; set => _save_path = value; }

		/// <summary>
		/// Перетворення типу <see cref="TimeSpan"/> у <see cref="string"/>
		/// </summary>
		/// <param name="duration">Тривалість</param>
		/// <returns>Повертає <see cref="string"/> формату "HH:mm:ss"</returns>
		private string ParseDurationToString(TimeSpan duration)
		{
			int hours = Math.Min(duration.Hours, 99); // змінна годин
			int minutes = Math.Min(duration.Minutes, 59); // змінна хвилин
			int seconds = Math.Min(duration.Seconds, 59); // змінна секунд
														  // Повертає зформовану стрічку
			return $"{hours:00}:{minutes:00}:{seconds:00}";
		}
		/// <summary>
		/// Перетворення типу <see cref="int"/> у <see cref="string"/>
		/// </summary>
		/// <param name="duration"></param>
		/// <returns>Повертає <see cref="string"/> формату "00:00:00"</returns>
		private string ParseDurationToString(int duration)
		{
			int hours = Math.Min(duration / 3600, 99);
			duration -= hours * 3600;
			int minutes = Math.Min(duration / 60, 59);
			duration -= minutes * 60;
			int seconds = Math.Min(duration, 59);

			return $"{hours:00}:{minutes:00}:{seconds:00}";
		}
		private string _save_path = ".\\save.json";

		/// <summary>
		/// Збереження класу у файл зі шляхом і назвою у <see cref="SAVE_PATH"/>
		/// </summary>
		public void SaveData()
		{
			// Створюємо змінну із даними цього класу у .json форматі з форматуванням стрічки для зручного вигляду
			var jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
			// Записуємо у файл
			File.WriteAllText(SAVE_PATH, jsonString);
		}

		/// <summary>
		/// Завантаження класу з файлу зі шляхом і назвою у _save_path
		/// </summary>
		/// <returns><see cref="List"/> з файлу, якщо він існує, або новий якщо файл не було знайдено</returns>
		/// <exception cref="FileNotFoundException"></exception>
		/// <exception cref="JsonException"></exception>
		public ScheduleManager loadData()
		{
			// Ініціалізуємо змінну для збереження даних класу у .json форматі
			string jsonString = "";
			try
			{
				// Присвоюємо змінній дані з файлу збереження
				jsonString = File.ReadAllText(SAVE_PATH);
				// Повертаємо збережений менеджер заходівЮ або новий, якщо файл пустий
				return JsonSerializer.Deserialize<ScheduleManager>(jsonString) ?? new();
			}
			catch (FileNotFoundException) // При відсутності потрібного файлу
			{
				// Сповіщення про відсутність файлу
				MessageBox.Show("Save hasn't been found. Creating new...");
				SaveData();

			}
			catch (JsonException) // При пошкодженому файлі
			{
				// Сповіщення про пошкождення файлу
				MessageBox.Show("Save file was damaged.");
				// Якщо файл порожній
				if (jsonString.Trim().Replace(" ", "").Equals(""))
				{
					// Зберегаємо поточний клас
					SaveData();
					// Повідомляємо про зберігання у порожній файл поточного класу
					MessageBox.Show("Save file was empty. Saving current data...");
				}
			}
			// Повертаємо новий менеджер заходів, якщо не було виявлено збережених даних
			return new();
		}

		/// <summary>
		/// Порівняння поточного класу зі збереженим
		/// </summary>
		/// <returns><see cref="bool"/> значення стану сбереження менеджеру заходів</returns>
		public bool checkSave()
		{
			// Перевірка наявності класу
			if (this == null) return false; // Якщо клас путий - повертаємо false
			string jsonString = ""; // Створюємо змінну для збереження вигружених даних з файлу збереження

			// Присвоюємо змінній дані поточного класу у форматі .json
			jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
			try
			{
				// Порівнюємо дані збереженого і поточного класів
				if (jsonString.Equals(File.ReadAllText(SAVE_PATH)))
				{
					// Повертаємо true
					return true;
				}
			}
			catch (FileNotFoundException) { } // Файл не було знайдено
											  // повертаємо false
			return false;
		}
	}
}