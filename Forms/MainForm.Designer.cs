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
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			BackgroundPanel = new Panel();
			dataGridViewSchedule = new DataGridView();
			idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			locationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			durationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			DateOfStarting = new DataGridViewTextBoxColumn();
			descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			isDoneDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			isMissedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			eventBindingSource = new BindingSource(components);
			ControlPanel = new Panel();
			btnAdd = new Button();
			dateTimePickerFilter = new DateTimePicker();
			btnDone = new Button();
			btnDelete = new Button();
			btnEdit = new Button();
			label4 = new Label();
			label3 = new Label();
			checkBoxOverlappingEvents = new CheckBox();
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
			toolStripSeparator2 = new ToolStripSeparator();
			exitToolStripMenuItem = new ToolStripMenuItem();
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
			dataGridViewSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridViewSchedule.AutoGenerateColumns = false;
			dataGridViewSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewSchedule.BackgroundColor = SystemColors.Desktop;
			dataGridViewSchedule.BorderStyle = BorderStyle.None;
			dataGridViewSchedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
			dataGridViewSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridViewSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewSchedule.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, locationDataGridViewTextBoxColumn, durationDataGridViewTextBoxColumn, DateOfStarting, descriptionDataGridViewTextBoxColumn, isDoneDataGridViewCheckBoxColumn, isMissedDataGridViewCheckBoxColumn });
			dataGridViewSchedule.DataSource = eventBindingSource;
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
			dataGridViewSchedule.RowTemplate.DividerHeight = 1;
			dataGridViewSchedule.RowTemplate.Height = 60;
			dataGridViewSchedule.RowTemplate.ReadOnly = true;
			dataGridViewSchedule.RowTemplate.Resizable = DataGridViewTriState.True;
			dataGridViewSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewSchedule.Size = new Size(1832, 551);
			dataGridViewSchedule.StandardTab = true;
			dataGridViewSchedule.TabIndex = 0;
			dataGridViewSchedule.VirtualMode = true;
			dataGridViewSchedule.CellContentDoubleClick += dataGridViewSchedule_CellContentDoubleClick;
			dataGridViewSchedule.CellFormatting += dataGridViewSchedule_CellFormatting;
			dataGridViewSchedule.KeyDown += dataGridViewSchedule_KeyDown;
			// 
			// idDataGridViewTextBoxColumn
			// 
			idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			idDataGridViewTextBoxColumn.HeaderText = "Id";
			idDataGridViewTextBoxColumn.MinimumWidth = 2;
			idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			idDataGridViewTextBoxColumn.ReadOnly = true;
			idDataGridViewTextBoxColumn.Width = 82;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewTextBoxColumn1.DataPropertyName = "Title";
			dataGridViewTextBoxColumn1.HeaderText = "Title";
			dataGridViewTextBoxColumn1.MinimumWidth = 8;
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.ReadOnly = true;
			dataGridViewTextBoxColumn1.Width = 121;
			// 
			// locationDataGridViewTextBoxColumn
			// 
			locationDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			locationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			locationDataGridViewTextBoxColumn.HeaderText = "Location";
			locationDataGridViewTextBoxColumn.MinimumWidth = 8;
			locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
			locationDataGridViewTextBoxColumn.ReadOnly = true;
			locationDataGridViewTextBoxColumn.Width = 189;
			// 
			// durationDataGridViewTextBoxColumn
			// 
			durationDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
			durationDataGridViewTextBoxColumn.HeaderText = "Duration";
			durationDataGridViewTextBoxColumn.MinimumWidth = 8;
			durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
			durationDataGridViewTextBoxColumn.ReadOnly = true;
			durationDataGridViewTextBoxColumn.Width = 189;
			// 
			// DateOfStarting
			// 
			DateOfStarting.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			DateOfStarting.DataPropertyName = "DateOfStarting";
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			DateOfStarting.DefaultCellStyle = dataGridViewCellStyle3;
			DateOfStarting.HeaderText = "Date of starting";
			DateOfStarting.MinimumWidth = 8;
			DateOfStarting.Name = "DateOfStarting";
			DateOfStarting.ReadOnly = true;
			DateOfStarting.Width = 297;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			descriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
			descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
			descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// isDoneDataGridViewCheckBoxColumn
			// 
			isDoneDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			isDoneDataGridViewCheckBoxColumn.DataPropertyName = "IsDone";
			isDoneDataGridViewCheckBoxColumn.HeaderText = "Done";
			isDoneDataGridViewCheckBoxColumn.MinimumWidth = 8;
			isDoneDataGridViewCheckBoxColumn.Name = "isDoneDataGridViewCheckBoxColumn";
			isDoneDataGridViewCheckBoxColumn.ReadOnly = true;
			isDoneDataGridViewCheckBoxColumn.Width = 150;
			// 
			// isMissedDataGridViewCheckBoxColumn
			// 
			isMissedDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			isMissedDataGridViewCheckBoxColumn.DataPropertyName = "IsMissed";
			isMissedDataGridViewCheckBoxColumn.HeaderText = "Missed";
			isMissedDataGridViewCheckBoxColumn.MinimumWidth = 8;
			isMissedDataGridViewCheckBoxColumn.Name = "isMissedDataGridViewCheckBoxColumn";
			isMissedDataGridViewCheckBoxColumn.ReadOnly = true;
			isMissedDataGridViewCheckBoxColumn.Width = 150;
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
			ControlPanel.Controls.Add(label4);
			ControlPanel.Controls.Add(label3);
			ControlPanel.Controls.Add(checkBoxOverlappingEvents);
			ControlPanel.Controls.Add(label1);
			ControlPanel.Controls.Add(checkboxShowAllEvents);
			ControlPanel.Controls.Add(checkBoxFilter);
			ControlPanel.Font = new Font("Ink Free", 17.9999981F);
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
			btnAdd.TabIndex = 8;
			btnAdd.Text = "+";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			btnAdd.KeyDown += btnDone_KeyDown;
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
			dateTimePickerFilter.KeyDown += btnDone_KeyDown;
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
			btnDone.TabIndex = 1;
			btnDone.Text = "Done";
			btnDone.UseVisualStyleBackColor = true;
			btnDone.Click += btnDone_Click;
			btnDone.KeyDown += btnDone_KeyDown;
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
			btnDelete.TabIndex = 2;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			btnDelete.KeyDown += btnDone_KeyDown;
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
			btnEdit.TabIndex = 3;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			btnEdit.KeyDown += btnDone_KeyDown;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 18F);
			label4.ForeColor = Color.Lime;
			label4.Location = new Point(377, 211);
			label4.Name = "label4";
			label4.Size = new Size(339, 75);
			label4.TabIndex = 7;
			label4.Text = "Show overlappings";
			label4.TextAlign = ContentAlignment.MiddleCenter;
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
			// checkBoxOverlappingEvents
			// 
			checkBoxOverlappingEvents.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			checkBoxOverlappingEvents.AutoSize = true;
			checkBoxOverlappingEvents.BackColor = Color.Transparent;
			checkBoxOverlappingEvents.Cursor = Cursors.Hand;
			checkBoxOverlappingEvents.Font = new Font("Segoe UI Semilight", 18F);
			checkBoxOverlappingEvents.ForeColor = Color.Lime;
			checkBoxOverlappingEvents.Location = new Point(719, 237);
			checkBoxOverlappingEvents.Margin = new Padding(0);
			checkBoxOverlappingEvents.Name = "checkBoxOverlappingEvents";
			checkBoxOverlappingEvents.RightToLeft = RightToLeft.No;
			checkBoxOverlappingEvents.Size = new Size(22, 21);
			checkBoxOverlappingEvents.TabIndex = 7;
			checkBoxOverlappingEvents.TextAlign = ContentAlignment.MiddleCenter;
			checkBoxOverlappingEvents.UseVisualStyleBackColor = false;
			checkBoxOverlappingEvents.CheckedChanged += TotalUpdatingEventsHandler;
			checkBoxOverlappingEvents.CheckStateChanged += TotalUpdatingEventsHandler;
			checkBoxOverlappingEvents.KeyDown += checkboxEscape_KeyDown;
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
			checkboxShowAllEvents.AutoSize = true;
			checkboxShowAllEvents.BackColor = Color.Transparent;
			checkboxShowAllEvents.Cursor = Cursors.Hand;
			checkboxShowAllEvents.Font = new Font("Segoe UI Semilight", 18F);
			checkboxShowAllEvents.ForeColor = Color.Lime;
			checkboxShowAllEvents.Location = new Point(272, 237);
			checkboxShowAllEvents.Margin = new Padding(0);
			checkboxShowAllEvents.Name = "checkboxShowAllEvents";
			checkboxShowAllEvents.RightToLeft = RightToLeft.No;
			checkboxShowAllEvents.Size = new Size(22, 21);
			checkboxShowAllEvents.TabIndex = 6;
			checkboxShowAllEvents.TextAlign = ContentAlignment.MiddleCenter;
			checkboxShowAllEvents.UseVisualStyleBackColor = false;
			checkboxShowAllEvents.CheckedChanged += TotalUpdatingEventsHandler;
			checkboxShowAllEvents.CheckStateChanged += TotalUpdatingEventsHandler;
			checkboxShowAllEvents.KeyDown += checkboxEscape_KeyDown;
			// 
			// checkBoxFilter
			// 
			checkBoxFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			checkBoxFilter.AutoSize = true;
			checkBoxFilter.BackColor = Color.Transparent;
			checkBoxFilter.Cursor = Cursors.Hand;
			checkBoxFilter.Font = new Font("Segoe UI Semilight", 18F);
			checkBoxFilter.ForeColor = Color.Lime;
			checkBoxFilter.Location = new Point(272, 131);
			checkBoxFilter.Margin = new Padding(0, 0, 0, 30);
			checkBoxFilter.Name = "checkBoxFilter";
			checkBoxFilter.RightToLeft = RightToLeft.No;
			checkBoxFilter.Size = new Size(22, 21);
			checkBoxFilter.TabIndex = 4;
			checkBoxFilter.TextAlign = ContentAlignment.MiddleCenter;
			checkBoxFilter.UseVisualStyleBackColor = false;
			checkBoxFilter.CheckedChanged += TotalUpdatingEventsHandler;
			checkBoxFilter.CheckStateChanged += TotalUpdatingEventsHandler;
			checkBoxFilter.KeyDown += checkboxEscape_KeyDown;
			// 
			// InfoPanel
			// 
			InfoPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			InfoPanel.Controls.Add(labelInfoNearestImage);
			InfoPanel.Controls.Add(label2);
			InfoPanel.Font = new Font("Ink Free", 17.9999981F);
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
			menuStrip1.Font = new Font("Segoe UI", 14F);
			menuStrip1.ImageScalingSize = new Size(24, 24);
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1892, 40);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(74, 36);
			fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
			newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			newToolStripMenuItem.Name = "newToolStripMenuItem";
			newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
			newToolStripMenuItem.Size = new Size(282, 40);
			newToolStripMenuItem.Text = "&New";
			newToolStripMenuItem.Click += newToolStripMenuItem_Click;
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
			openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
			openToolStripMenuItem.Size = new Size(282, 40);
			openToolStripMenuItem.Text = "&Open";
			openToolStripMenuItem.Click += openToolStripMenuItem_Click;
			// 
			// toolStripSeparator
			// 
			toolStripSeparator.Name = "toolStripSeparator";
			toolStripSeparator.Size = new Size(279, 6);
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
			saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
			saveToolStripMenuItem.Size = new Size(282, 40);
			saveToolStripMenuItem.Text = "&Save";
			saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(279, 6);
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(282, 40);
			exitToolStripMenuItem.Text = "E&xit";
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator5, aboutToolStripMenuItem });
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(87, 36);
			helpToolStripMenuItem.Text = "&Help";
			// 
			// toolStripSeparator5
			// 
			toolStripSeparator5.Name = "toolStripSeparator5";
			toolStripSeparator5.Size = new Size(213, 6);
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			aboutToolStripMenuItem.Size = new Size(216, 40);
			aboutToolStripMenuItem.Text = "&About...";
			aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
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
			FormClosing += MainForm_FormClosing;
			KeyDown += MainForm_KeyDown;
			BackgroundPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).EndInit();
			((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
			ControlPanel.ResumeLayout(false);
			ControlPanel.PerformLayout();
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
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem exitToolStripMenuItem;
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
		private Label label3;
		private CheckBox checkboxShowAllEvents;
		private BindingSource scheduleManagerBindingSource;
		private Label label4;
		private CheckBox checkBoxOverlappingEvents;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn DateOfStarting;
		private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private DataGridViewCheckBoxColumn isDoneDataGridViewCheckBoxColumn;
		private DataGridViewCheckBoxColumn isMissedDataGridViewCheckBoxColumn;
	}
}
