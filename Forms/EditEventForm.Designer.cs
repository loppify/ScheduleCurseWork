namespace ScheduleCurseWork.Forms
{
	partial class EditEventForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			dateTimePickerDuration = new MaskedTextBox();
			locationValid = new Label();
			descriptionValid = new Label();
			titleValid = new Label();
			label6 = new Label();
			dateTimePickerDateTime = new DateTimePicker();
			textBoxEventLocation = new TextBox();
			textBoxDescription = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			textBoxTitle = new TextBox();
			label2 = new Label();
			label1 = new Label();
			cancelBtn = new Button();
			okBtn = new Button();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(23, 23, 23);
			panel1.Controls.Add(dateTimePickerDuration);
			panel1.Controls.Add(locationValid);
			panel1.Controls.Add(descriptionValid);
			panel1.Controls.Add(titleValid);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(dateTimePickerDateTime);
			panel1.Controls.Add(textBoxEventLocation);
			panel1.Controls.Add(textBoxDescription);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(textBoxTitle);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(cancelBtn);
			panel1.Controls.Add(okBtn);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Margin = new Padding(0);
			panel1.Name = "panel1";
			panel1.Padding = new Padding(30);
			panel1.Size = new Size(950, 1192);
			panel1.TabIndex = 0;
			panel1.PreviewKeyDown += panel1_PreviewKeyDown;
			// 
			// dateTimePickerDuration
			// 
			dateTimePickerDuration.Anchor = AnchorStyles.Top;
			dateTimePickerDuration.Font = new Font("Segoe UI", 18F);
			dateTimePickerDuration.Location = new Point(153, 813);
			dateTimePickerDuration.Mask = "00:00:00";
			dateTimePickerDuration.Name = "dateTimePickerDuration";
			dateTimePickerDuration.PromptChar = '0';
			dateTimePickerDuration.Size = new Size(644, 55);
			dateTimePickerDuration.TabIndex = 4;
			dateTimePickerDuration.TextAlign = HorizontalAlignment.Center;
			dateTimePickerDuration.TextChanged += dateTimePickerDuration_TextChanged;
			dateTimePickerDuration.KeyDown += textBoxTitle_KeyDown;
			dateTimePickerDuration.Validating += dateTimePickerDuration_Validating;
			// 
			// locationValid
			// 
			locationValid.AutoSize = true;
			locationValid.BackColor = Color.Transparent;
			locationValid.Font = new Font("Segoe UI", 18F);
			locationValid.ForeColor = Color.Red;
			locationValid.Location = new Point(818, 498);
			locationValid.Name = "locationValid";
			locationValid.Size = new Size(32, 41);
			locationValid.TabIndex = 7;
			locationValid.Text = "*";
			locationValid.Visible = false;
			// 
			// descriptionValid
			// 
			descriptionValid.AutoSize = true;
			descriptionValid.BackColor = Color.Transparent;
			descriptionValid.Font = new Font("Segoe UI", 18F);
			descriptionValid.ForeColor = Color.Red;
			descriptionValid.Location = new Point(818, 342);
			descriptionValid.Name = "descriptionValid";
			descriptionValid.Size = new Size(32, 41);
			descriptionValid.TabIndex = 7;
			descriptionValid.Text = "*";
			descriptionValid.Visible = false;
			// 
			// titleValid
			// 
			titleValid.AutoSize = true;
			titleValid.BackColor = Color.Transparent;
			titleValid.Font = new Font("Segoe UI", 18F);
			titleValid.ForeColor = Color.Red;
			titleValid.Location = new Point(818, 186);
			titleValid.Name = "titleValid";
			titleValid.Size = new Size(32, 41);
			titleValid.TabIndex = 7;
			titleValid.Text = "*";
			titleValid.Visible = false;
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.Top;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Segoe UI", 18F);
			label6.ForeColor = Color.Lime;
			label6.Location = new Point(53, 739);
			label6.Margin = new Padding(0, 0, 0, 30);
			label6.Name = "label6";
			label6.Size = new Size(844, 41);
			label6.TabIndex = 5;
			label6.Text = "Event duration";
			label6.TextAlign = ContentAlignment.TopCenter;
			// 
			// dateTimePickerDateTime
			// 
			dateTimePickerDateTime.Anchor = AnchorStyles.Top;
			dateTimePickerDateTime.CalendarFont = new Font("Segoe UI", 18F);
			dateTimePickerDateTime.CalendarForeColor = Color.Lime;
			dateTimePickerDateTime.CalendarMonthBackground = Color.FromArgb(23, 23, 23);
			dateTimePickerDateTime.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
			dateTimePickerDateTime.CalendarTitleForeColor = Color.Green;
			dateTimePickerDateTime.DropDownAlign = LeftRightAlignment.Right;
			dateTimePickerDateTime.Font = new Font("Segoe UI", 18F);
			dateTimePickerDateTime.Format = DateTimePickerFormat.Custom;
			dateTimePickerDateTime.Location = new Point(153, 654);
			dateTimePickerDateTime.Margin = new Padding(0, 0, 0, 30);
			dateTimePickerDateTime.Name = "dateTimePickerDateTime";
			dateTimePickerDateTime.Size = new Size(644, 55);
			dateTimePickerDateTime.TabIndex = 3;
			dateTimePickerDateTime.KeyDown += textBoxTitle_KeyDown;
			dateTimePickerDateTime.Validating += dateTimePickerDateTime_Validating;
			// 
			// textBoxEventLocation
			// 
			textBoxEventLocation.Anchor = AnchorStyles.Top;
			textBoxEventLocation.BackColor = Color.FromArgb(23, 23, 23);
			textBoxEventLocation.Font = new Font("Segoe UI", 18F);
			textBoxEventLocation.ForeColor = Color.Lime;
			textBoxEventLocation.Location = new Point(153, 498);
			textBoxEventLocation.Margin = new Padding(100, 0, 100, 30);
			textBoxEventLocation.MaxLength = 50;
			textBoxEventLocation.Name = "textBoxEventLocation";
			textBoxEventLocation.Size = new Size(644, 55);
			textBoxEventLocation.TabIndex = 2;
			textBoxEventLocation.KeyDown += textBoxTitle_KeyDown;
			textBoxEventLocation.Validating += textBoxEventLocation_Validating;
			// 
			// textBoxDescription
			// 
			textBoxDescription.Anchor = AnchorStyles.Top;
			textBoxDescription.BackColor = Color.FromArgb(23, 23, 23);
			textBoxDescription.Font = new Font("Segoe UI", 18F);
			textBoxDescription.ForeColor = Color.Lime;
			textBoxDescription.Location = new Point(153, 342);
			textBoxDescription.Margin = new Padding(100, 0, 100, 30);
			textBoxDescription.MaxLength = 270;
			textBoxDescription.Name = "textBoxDescription";
			textBoxDescription.Size = new Size(644, 55);
			textBoxDescription.TabIndex = 1;
			textBoxDescription.KeyDown += textBoxTitle_KeyDown;
			textBoxDescription.Validating += textBoxDescription_Validating;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Top;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Segoe UI", 18F);
			label5.ForeColor = Color.Lime;
			label5.Location = new Point(53, 583);
			label5.Margin = new Padding(0, 0, 0, 30);
			label5.Name = "label5";
			label5.Size = new Size(844, 41);
			label5.TabIndex = 2;
			label5.Text = "Event date and time";
			label5.TextAlign = ContentAlignment.TopCenter;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Top;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 18F);
			label4.ForeColor = Color.Lime;
			label4.Location = new Point(53, 427);
			label4.Margin = new Padding(0, 0, 0, 30);
			label4.Name = "label4";
			label4.Size = new Size(844, 41);
			label4.TabIndex = 2;
			label4.Text = "Event location";
			label4.TextAlign = ContentAlignment.TopCenter;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI", 18F);
			label3.ForeColor = Color.Lime;
			label3.Location = new Point(53, 271);
			label3.Margin = new Padding(0, 0, 0, 30);
			label3.Name = "label3";
			label3.Size = new Size(844, 41);
			label3.TabIndex = 2;
			label3.Text = "Event description";
			label3.TextAlign = ContentAlignment.TopCenter;
			// 
			// textBoxTitle
			// 
			textBoxTitle.Anchor = AnchorStyles.Top;
			textBoxTitle.BackColor = Color.FromArgb(23, 23, 23);
			textBoxTitle.Font = new Font("Segoe UI", 18F);
			textBoxTitle.ForeColor = Color.Lime;
			textBoxTitle.Location = new Point(153, 186);
			textBoxTitle.Margin = new Padding(100, 0, 100, 30);
			textBoxTitle.MaxLength = 50;
			textBoxTitle.Name = "textBoxTitle";
			textBoxTitle.Size = new Size(644, 55);
			textBoxTitle.TabIndex = 0;
			textBoxTitle.KeyDown += textBoxTitle_KeyDown;
			textBoxTitle.Validating += textBoxTitle_Validating;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 18F);
			label2.ForeColor = Color.Lime;
			label2.Location = new Point(53, 115);
			label2.Margin = new Padding(0, 0, 0, 30);
			label2.Name = "label2";
			label2.Size = new Size(844, 41);
			label2.TabIndex = 2;
			label2.Text = "Event title";
			label2.TextAlign = ContentAlignment.TopCenter;
			// 
			// label1
			// 
			label1.BackColor = Color.Transparent;
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.ForeColor = Color.Lime;
			label1.Location = new Point(30, 30);
			label1.Margin = new Padding(0);
			label1.Name = "label1";
			label1.Size = new Size(890, 41);
			label1.TabIndex = 1;
			label1.Text = "Your event";
			label1.TextAlign = ContentAlignment.TopCenter;
			// 
			// cancelBtn
			// 
			cancelBtn.Anchor = AnchorStyles.Top;
			cancelBtn.AutoSize = true;
			cancelBtn.Font = new Font("Segoe UI", 18F);
			cancelBtn.Location = new Point(598, 1111);
			cancelBtn.Margin = new Padding(0, 0, 30, 0);
			cancelBtn.Name = "cancelBtn";
			cancelBtn.Size = new Size(146, 51);
			cancelBtn.TabIndex = 5;
			cancelBtn.Text = "Cancel";
			cancelBtn.UseVisualStyleBackColor = true;
			cancelBtn.Click += button2_Click;
			// 
			// okBtn
			// 
			okBtn.Anchor = AnchorStyles.Top;
			okBtn.AutoSize = true;
			okBtn.Font = new Font("Segoe UI", 18F);
			okBtn.Location = new Point(774, 1111);
			okBtn.Margin = new Padding(0);
			okBtn.Name = "okBtn";
			okBtn.Size = new Size(146, 51);
			okBtn.TabIndex = 6;
			okBtn.Text = "OK";
			okBtn.UseVisualStyleBackColor = true;
			okBtn.Click += button1_Click;
			// 
			// EditEventForm
			// 
			AutoScaleDimensions = new SizeF(10F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			CausesValidation = false;
			ClientSize = new Size(950, 1192);
			Controls.Add(panel1);
			MinimumSize = new Size(972, 1248);
			Name = "EditEventForm";
			Text = "EventForm";
			FormClosing += EditEventForm_FormClosing;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label2;
		private Label label1;
		private Button cancelBtn;
		private Button okBtn;
		private TextBox textBoxEventLocation;
		private TextBox textBoxDescription;
		private Label label4;
		private Label label3;
		private TextBox textBoxTitle;
		private DateTimePicker dateTimePickerDateTime;
		private Label label5;
		private Label label6;
		private Label locationValid;
		private Label descriptionValid;
		private Label titleValid;
		private MaskedTextBox dateTimePickerDuration;
	}
}