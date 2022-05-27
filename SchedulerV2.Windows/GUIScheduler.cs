using SchedulerV2;

namespace SchedulerV2.Windows
{
    public partial class GUIScheduler : Form
    {
        public GUIScheduler()
        {
            InitializeComponent();
        }

        private void FillSettings(object sender, EventArgs e)
        {
            nextExecutionTimeTextBox.Text = "";
            descriptionTextBox.Text = "";
            Settings settings = new Settings
            {
                currentDate = currentDateDateTimePicker.Value,
                type = typeComboBox.SelectedIndex,
                onceTimeAt = onceTimeAtDateTimePicker.Value,
                occurs = occursComboBox.SelectedIndex,
                weeks = (int)everyNumericUpDown.Value,
                monday = mondayCheckBox.Checked,
                tuesday = tuesdayCheckBox.Checked,
                wednesday = wednesdayCheckBox.Checked,
                thursday = thurdayCheckBox.Checked,
                friday = fridayCheckBox.Checked,
                saturday = saturdayCheckBox.Checked,
                sunday = sundayCheckBox.Checked,
                occursOnceAt = occursOnceAtRadioButton.Checked,
                occursOnceAtHour = occursOnceAtDateTimePicker.Value,
                occursEvery = occursEveryRadioButton.Checked,
                occursEveryFreq = (int)occursEveryNumericUpDown.Value,
                freq = occursEveryComboBox.SelectedIndex,
                startingHour = startingAtDateTimePicker.Value,
                endingHour = endingAtDateTimePicker.Value,
                startingLimit = startLimitDateTimePicker.Value,
                endingLimit = endLimitDateTimePicker.Value,
                freqTime = occursEveryComboBox.Text
            };
            CheckSettings(settings);
        }
        public void CheckSettings(Settings settings)
        {
            if (!enabledCheckBox.Checked)
            {
                nextExecutionTimeTextBox.Text = "Scheduler not enabled";
                return;
            }
            switch (settings.type)
            {
                case (int)TypeEnum.Types.Once:
                    CheckOnceSettings.CheckSettings(settings);
                    break;
                case (int)TypeEnum.Types.Recurring:
                    CheckRecurringSettings.CheckSettings(settings);
                    break;
                default:
                    settings.nextExecutionTime = "Please select a type";
                    break;
            }
            nextExecutionTimeTextBox.Text = settings.nextExecutionTime;
            if (settings.nextExecutionTime.Length == 0)
            {
                CalculateNextDate(settings);
            }
        }

        public void CalculateNextDate(Settings settings)
        {
            switch (settings.type)
            {
                case (int)TypeEnum.Types.Once:
                    CalculateOnce.CalculateNextExecutionTime(settings);
                    OnceDescription.SetDescription(settings);
                    break;
                case (int)TypeEnum.Types.Recurring:
                    CalculateRecurring.calculate(settings);
                    break;
                default:
                    break;
            }
            nextExecutionTimeTextBox.Text = settings.nextExecutionTime;
            descriptionTextBox.Text = settings.description;
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex == 0)
            {
                onceTimeAtDateTimePicker.Enabled = true;
                everyNumericUpDown.ReadOnly = true;
                occursEveryNumericUpDown.ReadOnly = true;
                occursOnceAtDateTimePicker.Enabled = false;
                startingAtDateTimePicker.Enabled = false;
                endingAtDateTimePicker.Enabled = false;
                startLimitDateTimePicker.Enabled = false;
                endLimitDateTimePicker.Enabled = false;
            }
            if (typeComboBox.SelectedIndex == 1)
            {
                onceTimeAtDateTimePicker.Enabled = false;
                everyNumericUpDown.ReadOnly = false;
                occursEveryNumericUpDown.ReadOnly = false;
                occursOnceAtDateTimePicker.Enabled = true;
                startingAtDateTimePicker.Enabled = true;
                endingAtDateTimePicker.Enabled = true;
                startLimitDateTimePicker.Enabled = true;
                endLimitDateTimePicker.Enabled = true;
            }
        }

        private void occursComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (occursComboBox.SelectedIndex == 0)
            {
                everyNumericUpDown.ReadOnly = true;
                occursOnceAtRadioButton.Enabled = true;
            }
            if (occursComboBox.SelectedIndex == 1)
            {
                occursOnceAtRadioButton.Enabled = true;
                everyNumericUpDown.ReadOnly = false;
            }
        }
    }
}