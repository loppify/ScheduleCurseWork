using ScheduleCurseWork.Models;
using System.ComponentModel;
using System.Data;

namespace ScheduleCurseWork.Forms
{
	public partial class EditEventForm : Form
	{
		Event curevent;
		bool adding { get; set; } = false;
		ScheduleManager eventList;

		// Для зміни події
		//
		public EditEventForm(Event curevent)
		{
			InitializeComponent();
			dateTimePickerDateTime.CustomFormat = @"dddd MMMM dd yyyy    hh:mm";


			this.curevent = curevent;
			textBoxTitle.Text = curevent.Title;
			textBoxDescription.Text = curevent.Description;
			textBoxEventLocation.Text = curevent.Location;
			dateTimePickerDateTime.Value = curevent.DateOfStarting;
			dateTimePickerDuration.Text = ParseDurationToString(curevent.Duration);
		}
		// Для додавання події
		//
		public EditEventForm(ScheduleManager eventList)
		{
			this.eventList = eventList;
			InitializeComponent();
			adding = true;
			dateTimePickerDateTime.CustomFormat = @"dddd MMMM dd yyyy    hh:mm";


			curevent = new Event();
			textBoxTitle.Text = $"Title {eventList.AllEvents[^1].Id + 1}";
			textBoxDescription.Text = $"Description {eventList.AllEvents[^1].Id + 1}";
			textBoxEventLocation.Text = $"Location {eventList.AllEvents[^1].Id + 1}";
			dateTimePickerDateTime.Value = DateTime.Now.AddMinutes(10);
			dateTimePickerDuration.Text = ParseDurationToString(600);
		}
		private void button1_Click(object sender, EventArgs e)
		{
			string title = textBoxTitle.Text;
			string location = textBoxEventLocation.Text;
			string description = textBoxDescription.Text;
			DateTime dateOfStarting = dateTimePickerDateTime.Value;
			int duration = ParseStringToDuration(dateTimePickerDuration.Text);
			if (adding)
			{
				eventList.AddEvent(title, description, location, dateOfStarting, duration);
			}
			else
			{
				curevent.Title = title;
				curevent.Description = description;
				curevent.Location = location;
				curevent.Duration = duration;
				curevent.DateOfStarting = dateOfStarting;
			}
			Close();
		}
		private int ParseStringToDuration(string duration)
		{
			int[] values = duration.Replace(" ", "0").Split(":").Select(v => string.IsNullOrEmpty(v) ? 0 : int.Parse(v)).ToArray();
			return values[0] * 3600 + values[1] * 60 + values[2];

		}
		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void textBoxTitle_Validating(object sender, CancelEventArgs e)
		{
			if (textBoxTitle.Text.Trim().Length == 0)
			{
				titleValid.Visible = true;
				e.Cancel = true;
			}
			else { titleValid.Visible = false; }
		}

		private void textBoxDescription_Validating(object sender, CancelEventArgs e)
		{
			if (textBoxDescription.Text.Trim().Length == 0)
			{
				descriptionValid.Visible = true;
				e.Cancel = true;
			}
			else { descriptionValid.Visible = false; }
		}

		private void textBoxEventLocation_Validating(object sender, CancelEventArgs e)
		{
			if (textBoxDescription.Text.Trim().Length == 0)
			{
				locationValid.Visible = true;
				e.Cancel = true;
			}
			else { locationValid.Visible = false; }
		}

		private void dateTimePickerDateTime_Validating(object sender, CancelEventArgs e)
		{
			if (dateTimePickerDateTime.Value <= DateTime.Now.AddMinutes(5))
			{
				MessageBox.Show("Starting event must be in more than 5 minutes.");
				e.Cancel = true;
			}
		}

		private void dateTimePickerDuration_Validating(object sender, CancelEventArgs e)
		{
			if (ParseStringToDuration(dateTimePickerDuration.Text) < 300)
			{
				MessageBox.Show("Duration musn't be less than 5 minutes.");
				e.Cancel = true;
			}
		}

		private void dateTimePickerDuration_TextChanged(object sender, EventArgs e)
		{

			var text = dateTimePickerDuration.Text.Replace(":", "").PadRight(6, '0');

			if (!int.TryParse(text, out int timeInput))
			{
				return;
			}

			int hours = Math.Min(timeInput / 10000, 23);
			int minutes = Math.Min((timeInput / 100) % 100, 59);
			int seconds = Math.Min(timeInput % 100, 59);

			dateTimePickerDuration.TextChanged -= dateTimePickerDuration_TextChanged;
			dateTimePickerDuration.Text = $"{hours:00}:{minutes:00}:{seconds:00}"; ;
			dateTimePickerDuration.SelectionStart = dateTimePickerDuration.Text.Length;
			dateTimePickerDuration.TextChanged += dateTimePickerDuration_TextChanged;
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

	}
}
