namespace ScheduleCurseWork
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			BackgroundPanel = new Panel();
			dataGridViewSchedule = new DataGridView();
			idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			locationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			durationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			DateOfStarting = new DataGridViewTextBoxColumn();
			descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			isMissedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			isDoneDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			eventBindingSource = new BindingSource(components);
			ControlPanel = new Panel();
			btnAdd = new Button();
			dateTimePickerFilter = new DateTimePicker();
			btnDone = new Button();
			btnDelete = new Button();
			btnEdit = new Button();
			label3 = new Label();
			label1 = new Label();
			checkboxShowAllEvents = new CheckBox();
			checkBoxFilter = new CheckBox();
			InfoPanel = new Panel();
			labelInfoNearestImage = new Label();
			scheduleManagerBindingSource = new BindingSource(components);
			label2 = new Label();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			newToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator = new ToolStripSeparator();
			saveToolStripMenuItem = new ToolStripMenuItem();
			saveAsToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripSeparator2 = new ToolStripSeparator();
			exitToolStripMenuItem = new ToolStripMenuItem();
			toolsToolStripMenuItem = new ToolStripMenuItem();
			optionsToolStripMenuItem = new ToolStripMenuItem();
			helpToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator5 = new ToolStripSeparator();
			aboutToolStripMenuItem = new ToolStripMenuItem();
			timer1 = new System.Windows.Forms.Timer(components);
			BackgroundPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).BeginInit();
			((System.ComponentModel.ISupportInitialize)eventBindingSource).BeginInit();
			ControlPanel.SuspendLayout();
			InfoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)scheduleManagerBindingSource).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// BackgroundPanel
			// 
			BackgroundPanel.BackColor = Color.FromArgb(23, 23, 23);
			BackgroundPanel.Controls.Add(dataGridViewSchedule);
			BackgroundPanel.Controls.Add(ControlPanel);
			BackgroundPanel.Controls.Add(InfoPanel);
			BackgroundPanel.Dock = DockStyle.Fill;
			BackgroundPanel.Location = new Point(0, 0);
			BackgroundPanel.Name = "BackgroundPanel";
			BackgroundPanel.Padding = new Padding(30, 60, 30, 30);
			BackgroundPanel.Size = new Size(1892, 1209);
			BackgroundPanel.TabIndex = 0;
			// 
			// dataGridViewSchedule
			// 
			dataGridViewSchedule.AllowUserToAddRows = false;
			dataGridViewSchedule.AllowUserToDeleteRows = false;
			dataGridViewSchedule.AllowUserToOrderColumns = true;
			dataGridViewSchedule.AllowUserToResizeColumns = false;
			dataGridViewSchedule.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(23, 23, 23);
			dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle1.ForeColor = Color.Lime;
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(40, 40, 40);
			dataGridViewCellStyle1.SelectionForeColor = Color.Lime;
			dataGridViewSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewSchedule.AutoGenerateColumns = false;
			dataGridViewSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewSchedule.BackgroundColor = SystemColors.Desktop;
			dataGridViewSchedule.BorderStyle = BorderStyle.None;
			dataGridViewSchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
			dataGridViewSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewSchedule.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, locationDataGridViewTextBoxColumn, durationDataGridViewTextBoxColumn, DateOfStarting, descriptionDataGridViewTextBoxColumn, isMissedDataGridViewCheckBoxColumn, isDoneDataGridViewCheckBoxColumn });
			dataGridViewSchedule.DataSource = eventBindingSource;
			dataGridViewSchedule.Dock = DockStyle.Top;
			dataGridViewSchedule.GridColor = SystemColors.Desktop;
			dataGridViewSchedule.Location = new Point(30, 60);
			dataGridViewSchedule.Margin = new Padding(0, 0, 0, 30);
			dataGridViewSchedule.MinimumSize = new Size(0, 48);
			dataGridViewSchedule.MultiSelect = false;
			dataGridViewSchedule.Name = "dataGridViewSchedule";
			dataGridViewSchedule.ReadOnly = true;
			dataGridViewSchedule.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewSchedule.RowHeadersVisible = false;
			dataGridViewSchedule.RowHeadersWidth = 62;
			dataGridViewSchedule.RowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewSchedule.RowTemplate.Height = 48;
			dataGridViewSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewSchedule.Size = new Size(1832, 551);
			dataGridViewSchedule.TabIndex = 0;
			dataGridViewSchedule.CellContentDoubleClick += dataGridViewSchedule_CellContentDoubleClick;
			dataGridViewSchedule.CellFormatting += dataGridViewSchedule_CellFormatting;
			// 
			// idDataGridViewTextBoxColumn
			// 
			idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			idDataGridViewTextBoxColumn.HeaderText = "Id";
			idDataGridViewTextBoxColumn.MinimumWidth = 8;
			idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			idDataGridViewTextBoxColumn.ReadOnly = true;
			idDataGridViewTextBoxColumn.Width = 60;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewTextBoxColumn1.DataPropertyName = "Title";
			dataGridViewTextBoxColumn1.HeaderText = "Title";
			dataGridViewTextBoxColumn1.MinimumWidth = 8;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.Width = 80;
			// 
			// locationDataGridViewTextBoxColumn
			// 
			locationDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
			locationDataGridViewTextBoxColumn.HeaderText = "Location";
			locationDataGridViewTextBoxColumn.MinimumWidth = 8;
			locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
			locationDataGridViewTextBoxColumn.ReadOnly = true;
			locationDataGridViewTextBoxColumn.Width = 114;
			// 
			// durationDataGridViewTextBoxColumn
			// 
			durationDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
			durationDataGridViewTextBoxColumn.HeaderText = "Duration";
			durationDataGridViewTextBoxColumn.MinimumWidth = 8;
			durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
			durationDataGridViewTextBoxColumn.ReadOnly = true;
			durationDataGridViewTextBoxColumn.Width = 114;
			// 
			// DateOfStarting
			// 
			DateOfStarting.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			DateOfStarting.DataPropertyName = "DateOfStarting";
			DateOfStarting.HeaderText = "DateOfStarting";
			DateOfStarting.MinimumWidth = 8;
			DateOfStarting.Name = "DateOfStarting";
			DateOfStarting.ReadOnly = true;
			DateOfStarting.Width = 165;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
			descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// isMissedDataGridViewCheckBoxColumn
			// 
			isMissedDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			isMissedDataGridViewCheckBoxColumn.DataPropertyName = "IsMissed";
			isMissedDataGridViewCheckBoxColumn.HeaderText = "IsMissed";
			isMissedDataGridViewCheckBoxColumn.MinimumWidth = 8;
			isMissedDataGridViewCheckBoxColumn.Name = "isMissedDataGridViewCheckBoxColumn";
			isMissedDataGridViewCheckBoxColumn.ReadOnly = true;
			isMissedDataGridViewCheckBoxColumn.Width = 86;
			// 
			// isDoneDataGridViewCheckBoxColumn
			// 
			isDoneDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			isDoneDataGridViewCheckBoxColumn.DataPropertyName = "IsDone";
			isDoneDataGridViewCheckBoxColumn.HeaderText = "IsDone";
			isDoneDataGridViewCheckBoxColumn.MinimumWidth = 8;
			isDoneDataGridViewCheckBoxColumn.Name = "isDoneDataGridViewCheckBoxColumn";
			isDoneDataGridViewCheckBoxColumn.ReadOnly = true;
			isDoneDataGridViewCheckBoxColumn.Width = 72;
			// 
			// eventBindingSource
			// 
			eventBindingSource.DataSource = typeof(Models.Event);
			// 
			// ControlPanel
			// 
			ControlPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			ControlPanel.Controls.Add(btnAdd);
			ControlPanel.Controls.Add(dateTimePickerFilter);
			ControlPanel.Controls.Add(btnDone);
			ControlPanel.Controls.Add(btnDelete);
			ControlPanel.Controls.Add(btnEdit);
			ControlPanel.Controls.Add(label3);
			ControlPanel.Controls.Add(label1);
			ControlPanel.Controls.Add(checkboxShowAllEvents);
			ControlPanel.Controls.Add(checkBoxFilter);
			ControlPanel.Location = new Point(927, 641);
			ControlPanel.Margin = new Padding(30, 30, 0, 0);
			ControlPanel.Name = "ControlPanel";
			ControlPanel.Size = new Size(935, 538);
			ControlPanel.TabIndex = 4;
			// 
			// btnAdd
			// 
			btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnAdd.Cursor = Cursors.Hand;
			btnAdd.Font = new Font("Segoe UI Semilight", 18F);
			btnAdd.Location = new Point(785, 388);
			btnAdd.Margin = new Padding(0);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(150, 150);
			btnAdd.TabIndex = 1;
			btnAdd.Text = "+";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// dateTimePickerFilter
			// 
			dateTimePickerFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			dateTimePickerFilter.CalendarForeColor = Color.Lime;
			dateTimePickerFilter.CalendarMonthBackground = Color.FromArgb(20, 20, 20);
			dateTimePickerFilter.CalendarTitleBackColor = Color.FromArgb(23, 23, 23);
			dateTimePickerFilter.CalendarTitleForeColor = Color.Lime;
			dateTimePickerFilter.CalendarTrailingForeColor = Color.Green;
			dateTimePickerFilter.Cursor = Cursors.Hand;
			dateTimePickerFilter.CustomFormat = "ddddMMMM d yyyy";
			dateTimePickerFilter.Font = new Font("Segoe UI Semilight", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
			dateTimePickerFilter.Format = DateTimePickerFormat.Custom;
			dateTimePickerFilter.Location = new Point(377, 104);
			dateTimePickerFilter.Margin = new Padding(30, 0, 0, 30);
			dateTimePickerFilter.MinimumSize = new Size(0, 75);
			dateTimePickerFilter.Name = "dateTimePickerFilter";
			dateTimePickerFilter.RightToLeft = RightToLeft.No;
			dateTimePickerFilter.Size = new Size(558, 75);
			dateTimePickerFilter.TabIndex = 5;
			dateTimePickerFilter.ValueChanged += TotalUpdatingEventsHandler;
			dateTimePickerFilter.Enter += TotalUpdatingEventsHandler;
			// 
			// btnDone
			// 
			btnDone.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnDone.Cursor = Cursors.Hand;
			btnDone.Font = new Font("Segoe UI Semilight", 18F);
			btnDone.Location = new Point(83, -1);
			btnDone.Margin = new Padding(30, 0, 0, 30);
			btnDone.Name = "btnDone";
			btnDone.Size = new Size(264, 75);
			btnDone.TabIndex = 3;
			btnDone.Text = "Done";
			btnDone.UseVisualStyleBackColor = true;
			btnDone.Click += btnDone_Click;
			// 
			// btnDelete
			// 
			btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnDelete.Cursor = Cursors.Hand;
			btnDelete.Font = new Font("Segoe UI Semilight", 18F);
			btnDelete.Location = new Point(377, -1);
			btnDelete.Margin = new Padding(30, 0, 0, 30);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(264, 75);
			btnDelete.TabIndex = 3;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnEdit
			// 
			btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnEdit.Cursor = Cursors.Hand;
			btnEdit.Font = new Font("Segoe UI Semilight", 18F);
			btnEdit.Location = new Point(671, 0);
			btnEdit.Margin = new Padding(30, 0, 0, 30);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(264, 75);
			btnEdit.TabIndex = 2;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI", 18F);
			label3.ForeColor = Color.Lime;
			label3.Location = new Point(83, 210);
			label3.Name = "label3";
			label3.Size = new Size(186, 75);
			label3.TabIndex = 7;
			label3.Text = "Show all";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 18F);
			label1.ForeColor = Color.Lime;
			label1.Location = new Point(83, 105);
			label1.Margin = new Padding(0, 0, 0, 30);
			label1.Name = "label1";
			label1.Size = new Size(186, 75);
			label1.TabIndex = 7;
			label1.Text = "Filter";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// checkboxShowAllEvents
			// 
			checkboxShowAllEvents.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			checkboxShowAllEvents.BackColor = Color.Transparent;
			checkboxShowAllEvents.Cursor = Cursors.Hand;
			checkboxShowAllEvents.Font = new Font("Segoe UI Semilight", 18F);
			checkboxShowAllEvents.ForeColor = Color.Lime;
			checkboxShowAllEvents.Location = new Point(272, 210);
			checkboxShowAllEvents.Margin = new Padding(0);
			checkboxShowAllEvents.Name = "checkboxShowAllEvents";
			checkboxShowAllEvents.RightToLeft = RightToLeft.No;
			checkboxShowAllEvents.Size = new Size(75, 75);
			checkboxShowAllEvents.TabIndex = 6;
			checkboxShowAllEvents.TextAlign = ContentAlignment.MiddleCenter;
			checkboxShowAllEvents.UseVisualStyleBackColor = false;
			checkboxShowAllEvents.CheckedChanged += TotalUpdatingEventsHandler;
			checkboxShowAllEvents.CheckStateChanged += TotalUpdatingEventsHandler;
			// 
			// checkBoxFilter
			// 
			checkBoxFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			checkBoxFilter.BackColor = Color.Transparent;
			checkBoxFilter.Cursor = Cursors.Hand;
			checkBoxFilter.Font = new Font("Segoe UI Semilight", 18F);
			checkBoxFilter.ForeColor = Color.Lime;
			checkBoxFilter.Location = new Point(272, 105);
			checkBoxFilter.Margin = new Padding(0, 0, 0, 30);
			checkBoxFilter.Name = "checkBoxFilter";
			checkBoxFilter.RightToLeft = RightToLeft.No;
			checkBoxFilter.Size = new Size(75, 75);
			checkBoxFilter.TabIndex = 6;
			checkBoxFilter.TextAlign = ContentAlignment.MiddleCenter;
			checkBoxFilter.UseVisualStyleBackColor = false;
			checkBoxFilter.CheckedChanged += TotalUpdatingEventsHandler;
			checkBoxFilter.CheckStateChanged += TotalUpdatingEventsHandler;
			// 
			// InfoPanel
			// 
			InfoPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			InfoPanel.Controls.Add(labelInfoNearestImage);
			InfoPanel.Controls.Add(label2);
			InfoPanel.Location = new Point(30, 641);
			InfoPanel.Margin = new Padding(0);
			InfoPanel.Name = "InfoPanel";
			InfoPanel.Size = new Size(801, 538);
			InfoPanel.TabIndex = 4;
			// 
			// labelInfoNearestImage
			// 
			labelInfoNearestImage.BackColor = Color.Transparent;
			labelInfoNearestImage.DataBindings.Add(new Binding("Text", scheduleManagerBindingSource, "SearchNearestString", true));
			labelInfoNearestImage.Font = new Font("Segoe UI", 18F);
			labelInfoNearestImage.ForeColor = Color.Lime;
			labelInfoNearestImage.Location = new Point(-3, 75);
			labelInfoNearestImage.Name = "labelInfoNearestImage";
			labelInfoNearestImage.Size = new Size(801, 463);
			labelInfoNearestImage.TabIndex = 8;
			labelInfoNearestImage.Text = "Event title";
			// 
			// scheduleManagerBindingSource
			// 
			scheduleManagerBindingSource.DataSource = typeof(Models.ScheduleManager);
			// 
			// label2
			// 
			label2.BackColor = Color.Transparent;
			label2.Dock = DockStyle.Top;
			label2.Font = new Font("Segoe UI", 18F);
			label2.ForeColor = Color.Lime;
			label2.Location = new Point(0, 0);
			label2.Name = "label2";
			label2.Size = new Size(801, 75);
			label2.TabIndex = 7;
			label2.Text = "Nearest event";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(24, 24);
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1892, 29);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, toolStripSeparator2, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(55, 25);
			fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
			newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			newToolStripMenuItem.Name = "newToolStripMenuItem";
			newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
			newToolStripMenuItem.Size = new Size(217, 34);
			newToolStripMenuItem.Text = "&New";
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
			openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
			openToolStripMenuItem.Size = new Size(217, 34);
			openToolStripMenuItem.Text = "&Open";
			// 
			// toolStripSeparator
			// 
			toolStripSeparator.Name = "toolStripSeparator";
			toolStripSeparator.Size = new Size(214, 6);
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
			saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
			saveToolStripMenuItem.Size = new Size(217, 34);
			saveToolStripMenuItem.Text = "&Save";
			// 
			// saveAsToolStripMenuItem
			// 
			saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			saveAsToolStripMenuItem.Size = new Size(217, 34);
			saveAsToolStripMenuItem.Text = "Save &As";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(214, 6);
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(214, 6);
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(217, 34);
			exitToolStripMenuItem.Text = "E&xit";
			// 
			// toolsToolStripMenuItem
			// 
			toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
			toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			toolsToolStripMenuItem.Size = new Size(69, 25);
			toolsToolStripMenuItem.Text = "&Tools";
			// 
			// optionsToolStripMenuItem
			// 
			optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			optionsToolStripMenuItem.Size = new Size(172, 34);
			optionsToolStripMenuItem.Text = "&Options";
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator5, aboutToolStripMenuItem });
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(63, 25);
			helpToolStripMenuItem.Text = "&Help";
			// 
			// toolStripSeparator5
			// 
			toolStripSeparator5.Name = "toolStripSeparator5";
			toolStripSeparator5.Size = new Size(168, 6);
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			aboutToolStripMenuItem.Size = new Size(171, 34);
			aboutToolStripMenuItem.Text = "&About...";
			// 
			// timer1
			// 
			timer1.Interval = 200;
			timer1.Tick += timer1_Tick;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(10F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1892, 1209);
			Controls.Add(menuStrip1);
			Controls.Add(BackgroundPanel);
			MainMenuStrip = menuStrip1;
			MinimumSize = new Size(1914, 1265);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Schedule";
			BackgroundPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).EndInit();
			((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
			ControlPanel.ResumeLayout(false);
			InfoPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)scheduleManagerBindingSource).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel BackgroundPanel;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem newToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem saveAsToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem toolsToolStripMenuItem;
		private ToolStripMenuItem optionsToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator5;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridViewSchedule;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private Panel InfoPanel;
		private Button btnDone;
		private DateTimePicker dateTimePickerFilter;
		private CheckBox checkBoxFilter;
		private Panel ControlPanel;
		private Label label1;
		private BindingSource eventBindingSource;
		private Label label2;
		private Label labelInfoNearestImage;
		private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.Timer timer1;
		private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn DateOfStarting;
		private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private DataGridViewCheckBoxColumn isMissedDataGridViewCheckBoxColumn;
		private DataGridViewCheckBoxColumn isDoneDataGridViewCheckBoxColumn;
		private Label label3;
		private CheckBox checkboxShowAllEvents;
		private BindingSource scheduleManagerBindingSource;
	}
}
