using ScheduleCurseWork.Forms;
using ScheduleCurseWork.Models;

namespace ScheduleCurseWork
{
	public partial class MainForm : Form
	{
		Font defaultFont = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);

		private static string cloumnIdName = "idDataGridViewTextBoxColumn";
		static string dateTimeFormat = "ddddMMMM d yyyy";
		ScheduleManager eventList = new ScheduleManager().loadData();
		DateTime dtfilter = DateTime.MinValue;

		public Font DefaultFont1 { get => defaultFont; set => defaultFont = value; }
		public static string CloumnIdName { get => cloumnIdName; set => cloumnIdName = value; }
		public static string DateTimeFormat { get => dateTimeFormat; set => dateTimeFormat = value; }
		public ScheduleManager EventList1 { get => eventList; set => eventList = value; }
		public DateTime Dtfilter { get => dtfilter; set => dtfilter = value; }

		public MainForm()
		{
			InitializeComponent();
			ChangeFont(Controls, DefaultFont1);

			dateTimePickerFilter.CustomFormat = DateTimeFormat;
			dateTimePickerFilter.MinDate = DateTime.Now.Date;

			refreshListOfEvents();


		}

		private void btnAdd_Click(object sender, EventArgs e) => openEditEvent();

		private void refreshListOfEvents()
		{
			if (checkBoxFilter.Checked)
			{
				Dtfilter = dateTimePickerFilter.Value;
			}
			else
			{
				Dtfilter = DateTime.MinValue;
			}
			List<Event> searchedbydate = EventList1.EventFilter(Dtfilter, checkboxShowAllEvents.Checked, checkBoxOverlappingEvents.Checked);
			eventBindingSource.DataSource = searchedbydate;
			
			timer1.Start();
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dataGridViewSchedule.SelectedRows.Count > 0)
				openEditEvent((int)dataGridViewSchedule.SelectedRows[0].Cells[CloumnIdName].Value);
		}
		private void dataGridViewSchedule_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridViewSchedule.SelectedRows.Count > 0)
				openEditEvent((int)dataGridViewSchedule.SelectedRows[0].Cells[CloumnIdName].Value);
		}
		private void openEditEvent(int e = int.MinValue)
		{
			if (e < 0)
			{
				EditEventForm dialog = new(EventList1);

				dialog.FormClosed += new(onEventEditForm_Closed);
				dialog.Show(this);
			}
			else
			{
				EditEventForm dialog = new(EventList1.AllEvents.FirstOrDefault(v => v.Id == e));

				dialog.FormClosed += new(onEventEditForm_Closed);
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
			if (dataGridViewSchedule.Columns[e.ColumnIndex].Name == "DateOfStarting")
			{
				if (e.Value is DateTime edt)
				{
					e.Value = edt.ToString(@"dddd MMMM dd yyyy HH:mm:ss");
				}

				e.FormattingApplied = true;
			}
			if (dataGridViewSchedule.Columns[e.ColumnIndex].Name == "isDoneDataGridViewCheckBoxColumn")
			{
				if (e.Value != null && (bool)e.Value)
				{
					dataGridViewSchedule.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(23, 100, 23);
				}
			}
			if (dataGridViewSchedule.Columns[e.ColumnIndex].Name == "isMissedDataGridViewCheckBoxColumn" &&
				dataGridViewSchedule.Rows[e.RowIndex].DefaultCellStyle.BackColor != Color.FromArgb(23, 100, 23))
			{
				if (e.Value != null && (bool)e.Value)
				{
					dataGridViewSchedule.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(100, 23, 23);
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
			{
				int curevid = (int)dataGridViewSchedule.SelectedRows[0].Cells[CloumnIdName].Value;
				EventList1.AllEvents.Remove(EventList1.AllEvents.FirstOrDefault(v => v.Id == curevid));
			}
			dataGridViewSchedule.ClearSelection();
			refreshListOfEvents();
		}

		private void btnDone_Click(object sender, EventArgs e)
		{
			if (dataGridViewSchedule.SelectedRows.Count > 0)
			{
				int curevid = (int)dataGridViewSchedule.SelectedRows[0].Cells[CloumnIdName].Value;

				Event curev = EventList1.AllEvents.FirstOrDefault(v => v.Id == curevid);
				EventList1.AllEvents.FirstOrDefault(v => v.Id == curevid).IsDone = !curev.IsDone;
			}
			dataGridViewSchedule.ClearSelection();
			refreshListOfEvents();
		}

		private void TotalUpdatingEventsHandler(object sender, EventArgs e) => refreshListOfEvents();

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (EventList1.AllEventsStatusIsMissedUpdate())
			{
				refreshListOfEvents();
			}
			scheduleManagerBindingSource.DataSource = new ScheduleManager();
			scheduleManagerBindingSource.DataSource = EventList1;
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e) => EventList1.SaveData();

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EventList1 = EventList1.loadData();
			if (EventList1.AllEvents.Count > 0)
				refreshListOfEvents();
		}

		private void dataGridViewSchedule_KeyDown(object sender, KeyEventArgs e)
		{
			int rowIndex;
			int columnIndex;

			if (dataGridViewSchedule.CurrentCell is null)
			{
				return;
			}
			rowIndex = dataGridViewSchedule.CurrentCell.RowIndex;
			columnIndex = dataGridViewSchedule.CurrentCell.ColumnIndex;



			switch (e.KeyCode)
			{
				case Keys.Up:
					if (rowIndex > 0)
					{
						dataGridViewSchedule.CurrentCell = dataGridViewSchedule.Rows[rowIndex - 1].Cells[columnIndex];
					}
					else
					{
						dataGridViewSchedule.CurrentCell = dataGridViewSchedule.Rows[^1].Cells[0];
					}
					e.Handled = true;
					break;

				case Keys.Down:
					if (rowIndex < dataGridViewSchedule.Rows.Count - 1)
					{
						dataGridViewSchedule.CurrentCell = dataGridViewSchedule.Rows[rowIndex + 1].Cells[columnIndex];
					}
					else
					{
						dataGridViewSchedule.CurrentCell = dataGridViewSchedule.Rows[0].Cells[0];
					}
					e.Handled = true;
					break;
				case Keys.Delete:
					btnDelete_Click(null, null);
					break;
				case Keys.Enter:
					btnDone_Click(null, null);
					break;
				case Keys.Escape:
					dataGridViewSchedule.ClearSelection();
					break;
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EventList1 = new ScheduleManager();
			refreshListOfEvents();
		}

		private void btnDone_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				dataGridViewSchedule.Focus();
			}
			else if (e.KeyCode == Keys.Enter && (sender is DateTimePicker s)) { s.Focus(); }

		}

		private void checkboxEscape_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				dataGridViewSchedule.Focus();
			}
			else if ((sender is CheckBox chb) && e.KeyCode == Keys.Enter)
			{
				chb.Checked = !chb.Checked;
			}

			e.Handled = true;
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("You can save and load from top menu and using shortcuts.\n\n\n" +
				"Owner and developer of this app is Rostyslav Tarasov KNURE student from PZPI-23-8 group");
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (EventList1.checkSave())
			{
				return;
			}
			DialogResult result = MessageBox.Show("Do you want to save?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

			switch (result)
			{
				case DialogResult.Yes:
					EventList1.SaveData();
					break;
				case DialogResult.No:
					break;
				case DialogResult.Cancel:
					e.Cancel = true;
					break;
			}
		}
		private void ChangeFont(Control.ControlCollection controls, Font newFont)
		{
			foreach (Control control in controls)
			{
				control.Font = newFont;

				if (control.HasChildren)
				{
					ChangeFont(control.Controls, newFont);
				}
			}
		}
	}
}
