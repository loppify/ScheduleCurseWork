using ScheduleCurseWork.Forms;
using ScheduleCurseWork.Models;

namespace ScheduleCurseWork
{
	public partial class MainForm : Form
	{
		static string dateTimeFormat = "ddddMMMM d yyyy";
		ScheduleManager EventList = new ScheduleManager();
		DateTime dtfilter = DateTime.MinValue;
		public MainForm()
		{
			InitializeComponent();


			dateTimePickerFilter.CustomFormat = dateTimeFormat;
			dateTimePickerFilter.MinDate = DateTime.Now.Date;
			refreshListOfEvents();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			openEditEvent();
		}

		private void refreshListOfEvents()
		{
			if (checkBoxFilter.Checked)
			{
				dtfilter = dateTimePickerFilter.Value;
			}
			else
			{
				dtfilter = DateTime.MinValue;
			}
			List<Event> searchedbydate = EventList.SearchByDate(dtfilter, checkboxShowAllEvents.Checked);
			eventBindingSource.DataSource = searchedbydate;
			dataGridViewSchedule.ClearSelection();
			timer1.Start();
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dataGridViewSchedule.SelectedRows.Count > 0)
				openEditEvent(dataGridViewSchedule.SelectedRows[0].Index);
		}
		private void dataGridViewSchedule_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridViewSchedule.SelectedRows.Count > 0)
				openEditEvent(e.RowIndex);
		}
		private void openEditEvent(int e = int.MinValue)
		{
			if (e < 0)
			{
				EditEventForm dialog = new EditEventForm(EventList);

				dialog.FormClosed += new FormClosedEventHandler(onEventEditForm_Closed);
				dialog.Show(this);
			}
			else
			{
				EditEventForm dialog = new EditEventForm(EventList.AllEvents[e]);

				dialog.FormClosed += new FormClosedEventHandler(onEventEditForm_Closed);
				dialog.Show();
			}
		}
		void onEventEditForm_Closed(object sender, FormClosedEventArgs e)
		{
			refreshListOfEvents();
		}
		private void dataGridViewSchedule_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dataGridViewSchedule.Columns[e.ColumnIndex].Name == "durationDataGridViewTextBoxColumn")
			{
				string timeValue = ParseDurationToString((int)e.Value);
				e.Value = timeValue;
				e.FormattingApplied = true;
			}
			if (dataGridViewSchedule.Columns[e.ColumnIndex].Name == "isDoneDataGridViewCheckBoxColumn")
			{
				if (e.Value != null && (bool)e.Value)
				{
					dataGridViewSchedule.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(23, 50, 23);
				}
				else
				{
					dataGridViewSchedule.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(23, 23, 23);
				}
			}
			if (dataGridViewSchedule.Columns[e.ColumnIndex].Name == "isMissedDataGridViewCheckBoxColumn")
			{
				if (e.Value != null && (bool)e.Value)
				{
					dataGridViewSchedule.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(50, 23, 23);
				}
				else
				{
					dataGridViewSchedule.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(23, 23, 23);
				}
			}
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

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dataGridViewSchedule.SelectedRows.Count > 0)
				EventList.AllEvents.RemoveAt(dataGridViewSchedule.SelectedRows[0].Index);
			refreshListOfEvents();
		}

		private void btnDone_Click(object sender, EventArgs e)
		{
			if (dataGridViewSchedule.SelectedRows.Count > 0)
			{

				Event curev = EventList.AllEvents[dataGridViewSchedule.SelectedRows[0].Index];
				EventList.AllEvents[dataGridViewSchedule.SelectedRows[0].Index].IsDone = !curev.IsDone;
			}

			refreshListOfEvents();
		}

		private void TotalUpdatingEventsHandler(object sender, EventArgs e)
		{
			refreshListOfEvents();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			EventList.AllEventsStatusIsMissedUpdate();
			scheduleManagerBindingSource.DataSource = new ScheduleManager();
			scheduleManagerBindingSource.DataSource = EventList;
		}
	}
}
