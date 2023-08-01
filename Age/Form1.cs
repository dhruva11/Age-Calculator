using System;
using System.Windows.Forms;

namespace AgeCalculatorApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Set "Enter manually" option as the default selected option
            rdoManual.Checked = true;
            dtPickerBirthDate.Visible = false;
            txtManualBirthDate.Visible = true;
        }

        private void btnCalculateAge_Click(object sender, EventArgs e)
        {
            DateTime birthDate;

            if (rdoPicker.Checked)
            {
                birthDate = dtPickerBirthDate.Value;
            }
            else
            {
                if (DateTime.TryParse(txtManualBirthDate.Text, out birthDate) == false)
                {
                    MessageBox.Show("Invalid date format. Please enter a valid date (MM/DD/YYYY).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DateTime currentDate = DateTime.Today;
            int age = CalculateAge(birthDate, currentDate);

            lblAgeResult.Text = $"Your age is: {age} years";
        }

        private int CalculateAge(DateTime birthDate, DateTime currentDate)
        {
            int age = currentDate.Year - birthDate.Year;

            // Check if the birthday has occurred this year
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }

        private void rdoPicker_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPicker.Checked)
            {
                dtPickerBirthDate.Visible = true;
                txtManualBirthDate.Visible = false;
            }
        }

        private void rdoManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoManual.Checked)
            {
                dtPickerBirthDate.Visible = false;
                txtManualBirthDate.Visible = true;
            }
        }
    }
}
