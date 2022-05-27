namespace SchedulerV2.Windows
{
    partial class GUIScheduler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.currentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.calculateButton = new System.Windows.Forms.Button();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.onceTimeAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.occursComboBox = new System.Windows.Forms.ComboBox();
            this.enabledCheckBox = new System.Windows.Forms.CheckBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.occursLabel = new System.Windows.Forms.Label();
            this.oceTimeAtLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.weeklyConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.sundayCheckBox = new System.Windows.Forms.CheckBox();
            this.saturdayCheckBox = new System.Windows.Forms.CheckBox();
            this.fridayCheckBox = new System.Windows.Forms.CheckBox();
            this.thurdayCheckBox = new System.Windows.Forms.CheckBox();
            this.wednesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.tuesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.mondayCheckBox = new System.Windows.Forms.CheckBox();
            this.weekLabel = new System.Windows.Forms.Label();
            this.everyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.everyLabel = new System.Windows.Forms.Label();
            this.dailyFrequencyGroupBox = new System.Windows.Forms.GroupBox();
            this.occursEveryRadioButton = new System.Windows.Forms.RadioButton();
            this.occursOnceAtRadioButton = new System.Windows.Forms.RadioButton();
            this.endingAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endAtLabel = new System.Windows.Forms.Label();
            this.startingAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.occursEveryComboBox = new System.Windows.Forms.ComboBox();
            this.occursEveryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.occursOnceAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startingAtLabel = new System.Windows.Forms.Label();
            this.limitsGroupBox = new System.Windows.Forms.GroupBox();
            this.endLimitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startLimitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nextExecutionTimeTextBox = new System.Windows.Forms.TextBox();
            this.nextExecutionTimeLabel = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            this.configurationGroupBox.SuspendLayout();
            this.weeklyConfigurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.everyNumericUpDown)).BeginInit();
            this.dailyFrequencyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.occursEveryNumericUpDown)).BeginInit();
            this.limitsGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.currentDateDateTimePicker);
            this.inputGroupBox.Controls.Add(this.calculateButton);
            this.inputGroupBox.Controls.Add(this.currentDateLabel);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(662, 66);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // currentDateDateTimePicker
            // 
            this.currentDateDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.currentDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.currentDateDateTimePicker.Location = new System.Drawing.Point(85, 24);
            this.currentDateDateTimePicker.Name = "currentDateDateTimePicker";
            this.currentDateDateTimePicker.Size = new System.Drawing.Size(207, 23);
            this.currentDateDateTimePicker.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(298, 26);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(358, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate next date";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.FillSettings);
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Location = new System.Drawing.Point(6, 29);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(73, 15);
            this.currentDateLabel.TabIndex = 0;
            this.currentDateLabel.Text = "Current date";
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.Controls.Add(this.onceTimeAtDateTimePicker);
            this.configurationGroupBox.Controls.Add(this.occursComboBox);
            this.configurationGroupBox.Controls.Add(this.enabledCheckBox);
            this.configurationGroupBox.Controls.Add(this.typeComboBox);
            this.configurationGroupBox.Controls.Add(this.occursLabel);
            this.configurationGroupBox.Controls.Add(this.oceTimeAtLabel);
            this.configurationGroupBox.Controls.Add(this.typeLabel);
            this.configurationGroupBox.Location = new System.Drawing.Point(12, 84);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(662, 112);
            this.configurationGroupBox.TabIndex = 1;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Configuration";
            // 
            // onceTimeAtDateTimePicker
            // 
            this.onceTimeAtDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.onceTimeAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.onceTimeAtDateTimePicker.Location = new System.Drawing.Point(85, 53);
            this.onceTimeAtDateTimePicker.Name = "onceTimeAtDateTimePicker";
            this.onceTimeAtDateTimePicker.Size = new System.Drawing.Size(571, 23);
            this.onceTimeAtDateTimePicker.TabIndex = 7;
            // 
            // occursComboBox
            // 
            this.occursComboBox.FormattingEnabled = true;
            this.occursComboBox.Items.AddRange(new object[] {
            "Daily",
            "Weekly"});
            this.occursComboBox.Location = new System.Drawing.Point(85, 78);
            this.occursComboBox.Name = "occursComboBox";
            this.occursComboBox.Size = new System.Drawing.Size(571, 23);
            this.occursComboBox.TabIndex = 6;
            this.occursComboBox.SelectedIndexChanged += new System.EventHandler(this.occursComboBox_SelectedIndexChanged);
            // 
            // enabledCheckBox
            // 
            this.enabledCheckBox.AutoSize = true;
            this.enabledCheckBox.Checked = true;
            this.enabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enabledCheckBox.Location = new System.Drawing.Point(298, 30);
            this.enabledCheckBox.Name = "enabledCheckBox";
            this.enabledCheckBox.Size = new System.Drawing.Size(68, 19);
            this.enabledCheckBox.TabIndex = 4;
            this.enabledCheckBox.Text = "Enabled";
            this.enabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Once",
            "Recurring"});
            this.typeComboBox.Location = new System.Drawing.Point(85, 26);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(207, 23);
            this.typeComboBox.TabIndex = 3;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // occursLabel
            // 
            this.occursLabel.AutoSize = true;
            this.occursLabel.Location = new System.Drawing.Point(6, 78);
            this.occursLabel.Name = "occursLabel";
            this.occursLabel.Size = new System.Drawing.Size(44, 15);
            this.occursLabel.TabIndex = 2;
            this.occursLabel.Text = "Occurs";
            // 
            // oceTimeAtLabel
            // 
            this.oceTimeAtLabel.AutoSize = true;
            this.oceTimeAtLabel.Location = new System.Drawing.Point(6, 53);
            this.oceTimeAtLabel.Name = "oceTimeAtLabel";
            this.oceTimeAtLabel.Size = new System.Drawing.Size(75, 15);
            this.oceTimeAtLabel.TabIndex = 1;
            this.oceTimeAtLabel.Text = "Once time at";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(6, 29);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 15);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Type";
            // 
            // weeklyConfigurationGroupBox
            // 
            this.weeklyConfigurationGroupBox.Controls.Add(this.sundayCheckBox);
            this.weeklyConfigurationGroupBox.Controls.Add(this.saturdayCheckBox);
            this.weeklyConfigurationGroupBox.Controls.Add(this.fridayCheckBox);
            this.weeklyConfigurationGroupBox.Controls.Add(this.thurdayCheckBox);
            this.weeklyConfigurationGroupBox.Controls.Add(this.wednesdayCheckBox);
            this.weeklyConfigurationGroupBox.Controls.Add(this.tuesdayCheckBox);
            this.weeklyConfigurationGroupBox.Controls.Add(this.mondayCheckBox);
            this.weeklyConfigurationGroupBox.Controls.Add(this.weekLabel);
            this.weeklyConfigurationGroupBox.Controls.Add(this.everyNumericUpDown);
            this.weeklyConfigurationGroupBox.Controls.Add(this.everyLabel);
            this.weeklyConfigurationGroupBox.Location = new System.Drawing.Point(12, 202);
            this.weeklyConfigurationGroupBox.Name = "weeklyConfigurationGroupBox";
            this.weeklyConfigurationGroupBox.Size = new System.Drawing.Size(662, 100);
            this.weeklyConfigurationGroupBox.TabIndex = 2;
            this.weeklyConfigurationGroupBox.TabStop = false;
            this.weeklyConfigurationGroupBox.Text = "Weekly Configuration";
            // 
            // sundayCheckBox
            // 
            this.sundayCheckBox.AutoSize = true;
            this.sundayCheckBox.Location = new System.Drawing.Point(540, 55);
            this.sundayCheckBox.Name = "sundayCheckBox";
            this.sundayCheckBox.Size = new System.Drawing.Size(65, 19);
            this.sundayCheckBox.TabIndex = 9;
            this.sundayCheckBox.Text = "Sunday";
            this.sundayCheckBox.UseVisualStyleBackColor = true;
            // 
            // saturdayCheckBox
            // 
            this.saturdayCheckBox.AutoSize = true;
            this.saturdayCheckBox.Location = new System.Drawing.Point(451, 55);
            this.saturdayCheckBox.Name = "saturdayCheckBox";
            this.saturdayCheckBox.Size = new System.Drawing.Size(72, 19);
            this.saturdayCheckBox.TabIndex = 8;
            this.saturdayCheckBox.Text = "Saturday";
            this.saturdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // fridayCheckBox
            // 
            this.fridayCheckBox.AutoSize = true;
            this.fridayCheckBox.Location = new System.Drawing.Point(362, 55);
            this.fridayCheckBox.Name = "fridayCheckBox";
            this.fridayCheckBox.Size = new System.Drawing.Size(58, 19);
            this.fridayCheckBox.TabIndex = 7;
            this.fridayCheckBox.Text = "Friday";
            this.fridayCheckBox.UseVisualStyleBackColor = true;
            // 
            // thurdayCheckBox
            // 
            this.thurdayCheckBox.AutoSize = true;
            this.thurdayCheckBox.Location = new System.Drawing.Point(273, 55);
            this.thurdayCheckBox.Name = "thurdayCheckBox";
            this.thurdayCheckBox.Size = new System.Drawing.Size(74, 19);
            this.thurdayCheckBox.TabIndex = 6;
            this.thurdayCheckBox.Text = "Thursday";
            this.thurdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // wednesdayCheckBox
            // 
            this.wednesdayCheckBox.AutoSize = true;
            this.wednesdayCheckBox.Location = new System.Drawing.Point(184, 55);
            this.wednesdayCheckBox.Name = "wednesdayCheckBox";
            this.wednesdayCheckBox.Size = new System.Drawing.Size(87, 19);
            this.wednesdayCheckBox.TabIndex = 5;
            this.wednesdayCheckBox.Text = "Wednesday";
            this.wednesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // tuesdayCheckBox
            // 
            this.tuesdayCheckBox.AutoSize = true;
            this.tuesdayCheckBox.Location = new System.Drawing.Point(95, 55);
            this.tuesdayCheckBox.Name = "tuesdayCheckBox";
            this.tuesdayCheckBox.Size = new System.Drawing.Size(69, 19);
            this.tuesdayCheckBox.TabIndex = 4;
            this.tuesdayCheckBox.Text = "Tuesday";
            this.tuesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // mondayCheckBox
            // 
            this.mondayCheckBox.AutoSize = true;
            this.mondayCheckBox.Location = new System.Drawing.Point(6, 55);
            this.mondayCheckBox.Name = "mondayCheckBox";
            this.mondayCheckBox.Size = new System.Drawing.Size(70, 19);
            this.mondayCheckBox.TabIndex = 3;
            this.mondayCheckBox.Text = "Monday";
            this.mondayCheckBox.UseVisualStyleBackColor = true;
            // 
            // weekLabel
            // 
            this.weekLabel.AutoSize = true;
            this.weekLabel.Location = new System.Drawing.Point(298, 28);
            this.weekLabel.Name = "weekLabel";
            this.weekLabel.Size = new System.Drawing.Size(47, 15);
            this.weekLabel.TabIndex = 2;
            this.weekLabel.Text = "week(s)";
            // 
            // everyNumericUpDown
            // 
            this.everyNumericUpDown.Location = new System.Drawing.Point(85, 26);
            this.everyNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.everyNumericUpDown.Name = "everyNumericUpDown";
            this.everyNumericUpDown.Size = new System.Drawing.Size(207, 23);
            this.everyNumericUpDown.TabIndex = 1;
            this.everyNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // everyLabel
            // 
            this.everyLabel.AutoSize = true;
            this.everyLabel.Location = new System.Drawing.Point(6, 28);
            this.everyLabel.Name = "everyLabel";
            this.everyLabel.Size = new System.Drawing.Size(35, 15);
            this.everyLabel.TabIndex = 0;
            this.everyLabel.Text = "Every";
            // 
            // dailyFrequencyGroupBox
            // 
            this.dailyFrequencyGroupBox.Controls.Add(this.occursEveryRadioButton);
            this.dailyFrequencyGroupBox.Controls.Add(this.occursOnceAtRadioButton);
            this.dailyFrequencyGroupBox.Controls.Add(this.endingAtDateTimePicker);
            this.dailyFrequencyGroupBox.Controls.Add(this.endAtLabel);
            this.dailyFrequencyGroupBox.Controls.Add(this.startingAtDateTimePicker);
            this.dailyFrequencyGroupBox.Controls.Add(this.occursEveryComboBox);
            this.dailyFrequencyGroupBox.Controls.Add(this.occursEveryNumericUpDown);
            this.dailyFrequencyGroupBox.Controls.Add(this.occursOnceAtDateTimePicker);
            this.dailyFrequencyGroupBox.Controls.Add(this.startingAtLabel);
            this.dailyFrequencyGroupBox.Location = new System.Drawing.Point(12, 308);
            this.dailyFrequencyGroupBox.Name = "dailyFrequencyGroupBox";
            this.dailyFrequencyGroupBox.Size = new System.Drawing.Size(662, 126);
            this.dailyFrequencyGroupBox.TabIndex = 3;
            this.dailyFrequencyGroupBox.TabStop = false;
            this.dailyFrequencyGroupBox.Text = "Daily Frequency";
            // 
            // occursEveryRadioButton
            // 
            this.occursEveryRadioButton.AutoSize = true;
            this.occursEveryRadioButton.Location = new System.Drawing.Point(6, 56);
            this.occursEveryRadioButton.Name = "occursEveryRadioButton";
            this.occursEveryRadioButton.Size = new System.Drawing.Size(93, 19);
            this.occursEveryRadioButton.TabIndex = 10;
            this.occursEveryRadioButton.TabStop = true;
            this.occursEveryRadioButton.Text = "Occurs every";
            this.occursEveryRadioButton.UseVisualStyleBackColor = true;
            // 
            // occursOnceAtRadioButton
            // 
            this.occursOnceAtRadioButton.AutoSize = true;
            this.occursOnceAtRadioButton.Location = new System.Drawing.Point(6, 31);
            this.occursOnceAtRadioButton.Name = "occursOnceAtRadioButton";
            this.occursOnceAtRadioButton.Size = new System.Drawing.Size(98, 19);
            this.occursOnceAtRadioButton.TabIndex = 9;
            this.occursOnceAtRadioButton.TabStop = true;
            this.occursOnceAtRadioButton.Text = "Occurs one at";
            this.occursOnceAtRadioButton.UseVisualStyleBackColor = true;
            // 
            // endingAtDateTimePicker
            // 
            this.endingAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endingAtDateTimePicker.Location = new System.Drawing.Point(228, 84);
            this.endingAtDateTimePicker.Name = "endingAtDateTimePicker";
            this.endingAtDateTimePicker.ShowUpDown = true;
            this.endingAtDateTimePicker.Size = new System.Drawing.Size(156, 23);
            this.endingAtDateTimePicker.TabIndex = 8;
            this.endingAtDateTimePicker.Value = new System.DateTime(2022, 5, 25, 0, 0, 0, 0);
            // 
            // endAtLabel
            // 
            this.endAtLabel.AutoSize = true;
            this.endAtLabel.Location = new System.Drawing.Point(184, 87);
            this.endAtLabel.Name = "endAtLabel";
            this.endAtLabel.Size = new System.Drawing.Size(40, 15);
            this.endAtLabel.TabIndex = 7;
            this.endAtLabel.Text = "End at";
            // 
            // startingAtDateTimePicker
            // 
            this.startingAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startingAtDateTimePicker.Location = new System.Drawing.Point(64, 84);
            this.startingAtDateTimePicker.Name = "startingAtDateTimePicker";
            this.startingAtDateTimePicker.ShowUpDown = true;
            this.startingAtDateTimePicker.Size = new System.Drawing.Size(114, 23);
            this.startingAtDateTimePicker.TabIndex = 6;
            this.startingAtDateTimePicker.Value = new System.DateTime(2022, 5, 25, 0, 0, 0, 0);
            // 
            // occursEveryComboBox
            // 
            this.occursEveryComboBox.FormattingEnabled = true;
            this.occursEveryComboBox.Items.AddRange(new object[] {
            "Hours",
            "Minutes",
            "Seconds"});
            this.occursEveryComboBox.Location = new System.Drawing.Point(310, 55);
            this.occursEveryComboBox.Name = "occursEveryComboBox";
            this.occursEveryComboBox.Size = new System.Drawing.Size(74, 23);
            this.occursEveryComboBox.TabIndex = 5;
            // 
            // occursEveryNumericUpDown
            // 
            this.occursEveryNumericUpDown.Location = new System.Drawing.Point(184, 55);
            this.occursEveryNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.occursEveryNumericUpDown.Name = "occursEveryNumericUpDown";
            this.occursEveryNumericUpDown.Size = new System.Drawing.Size(126, 23);
            this.occursEveryNumericUpDown.TabIndex = 4;
            this.occursEveryNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // occursOnceAtDateTimePicker
            // 
            this.occursOnceAtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.occursOnceAtDateTimePicker.Location = new System.Drawing.Point(184, 27);
            this.occursOnceAtDateTimePicker.Name = "occursOnceAtDateTimePicker";
            this.occursOnceAtDateTimePicker.ShowUpDown = true;
            this.occursOnceAtDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.occursOnceAtDateTimePicker.TabIndex = 3;
            this.occursOnceAtDateTimePicker.Value = new System.DateTime(2022, 5, 25, 0, 0, 0, 0);
            // 
            // startingAtLabel
            // 
            this.startingAtLabel.AutoSize = true;
            this.startingAtLabel.Location = new System.Drawing.Point(6, 87);
            this.startingAtLabel.Name = "startingAtLabel";
            this.startingAtLabel.Size = new System.Drawing.Size(61, 15);
            this.startingAtLabel.TabIndex = 2;
            this.startingAtLabel.Text = "Starting at";
            // 
            // limitsGroupBox
            // 
            this.limitsGroupBox.Controls.Add(this.endLimitDateTimePicker);
            this.limitsGroupBox.Controls.Add(this.startLimitDateTimePicker);
            this.limitsGroupBox.Controls.Add(this.endDateLabel);
            this.limitsGroupBox.Controls.Add(this.startDateLabel);
            this.limitsGroupBox.Location = new System.Drawing.Point(12, 440);
            this.limitsGroupBox.Name = "limitsGroupBox";
            this.limitsGroupBox.Size = new System.Drawing.Size(662, 60);
            this.limitsGroupBox.TabIndex = 4;
            this.limitsGroupBox.TabStop = false;
            this.limitsGroupBox.Text = "Limits";
            // 
            // endLimitDateTimePicker
            // 
            this.endLimitDateTimePicker.CustomFormat = "dd/MM/yyyy ";
            this.endLimitDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endLimitDateTimePicker.Location = new System.Drawing.Point(383, 20);
            this.endLimitDateTimePicker.Name = "endLimitDateTimePicker";
            this.endLimitDateTimePicker.Size = new System.Drawing.Size(273, 23);
            this.endLimitDateTimePicker.TabIndex = 5;
            // 
            // startLimitDateTimePicker
            // 
            this.startLimitDateTimePicker.CustomFormat = "dd/MM/yyyy ";
            this.startLimitDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startLimitDateTimePicker.Location = new System.Drawing.Point(95, 22);
            this.startLimitDateTimePicker.Name = "startLimitDateTimePicker";
            this.startLimitDateTimePicker.Size = new System.Drawing.Size(138, 23);
            this.startLimitDateTimePicker.TabIndex = 4;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(230, 28);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(53, 15);
            this.endDateLabel.TabIndex = 2;
            this.endDateLabel.Text = "End date";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(6, 28);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(57, 15);
            this.startDateLabel.TabIndex = 0;
            this.startDateLabel.Text = "Start date";
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.descriptionTextBox);
            this.outputGroupBox.Controls.Add(this.descriptionLabel);
            this.outputGroupBox.Controls.Add(this.nextExecutionTimeTextBox);
            this.outputGroupBox.Controls.Add(this.nextExecutionTimeLabel);
            this.outputGroupBox.Location = new System.Drawing.Point(12, 506);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(662, 124);
            this.outputGroupBox.TabIndex = 5;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 73);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(650, 45);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 55);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // nextExecutionTimeTextBox
            // 
            this.nextExecutionTimeTextBox.Location = new System.Drawing.Point(124, 25);
            this.nextExecutionTimeTextBox.Name = "nextExecutionTimeTextBox";
            this.nextExecutionTimeTextBox.ReadOnly = true;
            this.nextExecutionTimeTextBox.Size = new System.Drawing.Size(532, 23);
            this.nextExecutionTimeTextBox.TabIndex = 1;
            // 
            // nextExecutionTimeLabel
            // 
            this.nextExecutionTimeLabel.AutoSize = true;
            this.nextExecutionTimeLabel.Location = new System.Drawing.Point(6, 28);
            this.nextExecutionTimeLabel.Name = "nextExecutionTimeLabel";
            this.nextExecutionTimeLabel.Size = new System.Drawing.Size(114, 15);
            this.nextExecutionTimeLabel.TabIndex = 0;
            this.nextExecutionTimeLabel.Text = "Next execution time";
            // 
            // GUIScheduker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 639);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.limitsGroupBox);
            this.Controls.Add(this.dailyFrequencyGroupBox);
            this.Controls.Add(this.weeklyConfigurationGroupBox);
            this.Controls.Add(this.configurationGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Name = "GUIScheduker";
            this.Text = "Scheduler";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.configurationGroupBox.ResumeLayout(false);
            this.configurationGroupBox.PerformLayout();
            this.weeklyConfigurationGroupBox.ResumeLayout(false);
            this.weeklyConfigurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.everyNumericUpDown)).EndInit();
            this.dailyFrequencyGroupBox.ResumeLayout(false);
            this.dailyFrequencyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.occursEveryNumericUpDown)).EndInit();
            this.limitsGroupBox.ResumeLayout(false);
            this.limitsGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox inputGroupBox;
        private Button calculateButton;
        private Label currentDateLabel;
        private GroupBox configurationGroupBox;
        private ComboBox occursComboBox;
        private CheckBox enabledCheckBox;
        private ComboBox typeComboBox;
        private Label occursLabel;
        private Label oceTimeAtLabel;
        private Label typeLabel;
        private GroupBox weeklyConfigurationGroupBox;
        private CheckBox sundayCheckBox;
        private CheckBox saturdayCheckBox;
        private CheckBox fridayCheckBox;
        private CheckBox thurdayCheckBox;
        private CheckBox wednesdayCheckBox;
        private CheckBox tuesdayCheckBox;
        private CheckBox mondayCheckBox;
        private Label weekLabel;
        private NumericUpDown everyNumericUpDown;
        private Label everyLabel;
        private GroupBox dailyFrequencyGroupBox;
        private DateTimePicker endingAtDateTimePicker;
        private Label endAtLabel;
        private DateTimePicker startingAtDateTimePicker;
        private ComboBox occursEveryComboBox;
        private NumericUpDown occursEveryNumericUpDown;
        private DateTimePicker occursOnceAtDateTimePicker;
        private Label startingAtLabel;
        private GroupBox limitsGroupBox;
        private Label endDateLabel;
        private Label startDateLabel;
        private GroupBox outputGroupBox;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private TextBox nextExecutionTimeTextBox;
        private Label nextExecutionTimeLabel;
        private RadioButton occursEveryRadioButton;
        private RadioButton occursOnceAtRadioButton;
        private DateTimePicker currentDateDateTimePicker;
        private DateTimePicker onceTimeAtDateTimePicker;
        private DateTimePicker endLimitDateTimePicker;
        private DateTimePicker startLimitDateTimePicker;
    }
}