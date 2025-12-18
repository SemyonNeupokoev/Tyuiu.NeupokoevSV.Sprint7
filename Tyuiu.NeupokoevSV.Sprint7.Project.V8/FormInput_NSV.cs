using System;
using System.Windows.Forms;
using Tyuiu.NeupokoevSV.Sprint7.Project.V8.Lib;
using static Tyuiu.NeupokoevSV.Sprint7.Project.V8.Lib.DataService;

namespace Tyuiu.NeupokoevSV.Sprint7.Project.V8
{
    public partial class FormInput_NSV : Form
    {
        private Driver _driver = new Driver();

        public FormInput_NSV()
        {
            InitializeComponent();
        }
        public FormInput_NSV(Driver driverToEdit) : this()
        {
            if (driverToEdit != null)
            {
                _driver = driverToEdit;
                FillFormData();
            }
        }

        public Driver Driver => _driver;

        private void FillFormData()
        {
            textBoxTabNumber_NSV.Text = _driver.TabNumber;
            textBoxLastName_NSV.Text = _driver.LastName;
            textBoxFirstName_NSV.Text = _driver.FirstName;
            textBoxMiddleName_NSV.Text = _driver.MiddleName;
            textBoxExperience_NSV.Text = _driver.Experience.ToString();
            textBoxSalary_NSV.Text = _driver.Salary.ToString();

            if (_driver.BirthDate > DateTime.MinValue)
                dateTimePickerBirthDate_NSV.Value = _driver.BirthDate;
        }

        private void buttonCancel_NSV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_NSV_Click(object sender, EventArgs e)
        {
            _driver.TabNumber = textBoxTabNumber_NSV.Text;
            _driver.LastName = textBoxLastName_NSV.Text;
            _driver.FirstName = textBoxFirstName_NSV.Text;
            _driver.MiddleName = textBoxMiddleName_NSV.Text;
            _driver.BirthDate = dateTimePickerBirthDate_NSV.Value;
            _driver.Experience = int.Parse(textBoxExperience_NSV.Text);
            _driver.Salary = decimal.Parse(textBoxSalary_NSV.Text);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}