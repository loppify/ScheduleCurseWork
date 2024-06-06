namespace ScheduleCurseWork.Models
{

	public class Event
	{
		public int Id { get; set; } // Унікальний ідентифікатор заходу
		public string Title { get; set; } // Назва заходу
		public string Description { get; set; } // Опис заходу
		public string Location { get; set; } // Місце проведення заходу
		public DateTime DateOfStarting { get; set; } // Дата і час початку заходу
		public int Duration { get; set; } // Тривалість заходу в секундах
		public bool IsDone { get; set; } = false; // Прапорець, що вказує, чи завершено захід.
		public bool IsMissed { get; set; } = false; // Прапорець, що вказує, чи пропущено захід.
	}
}

