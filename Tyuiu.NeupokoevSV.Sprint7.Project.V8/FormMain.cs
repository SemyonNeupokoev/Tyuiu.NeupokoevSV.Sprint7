using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tyuiu.NeupokoevSV.Sprint7.Project.V8.Lib;
using static Tyuiu.NeupokoevSV.Sprint7.Project.V8.Lib.DataService;

namespace Tyuiu.NeupokoevSV.Sprint7.Project.V8
{
    public partial class FormMain : Form
    {
        private List<Driver> drivers = new List<Driver>();

        public FormMain()
        {
            InitializeComponent();
            SetupTable();
        }

        private void SetupTable()
        {
            dataGridViewVivod_NSV.Columns.Add("TabNumber", "Табельный номер");
            dataGridViewVivod_NSV.Columns.Add("LastName", "Фамилия");
            dataGridViewVivod_NSV.Columns.Add("FirstName", "Имя");
            dataGridViewVivod_NSV.Columns.Add("MiddleName", "Отчество");
            dataGridViewVivod_NSV.Columns.Add("BirthDate", "Дата рождения");
            dataGridViewVivod_NSV.Columns.Add("Experience", "Стаж (лет)");
            dataGridViewVivod_NSV.Columns.Add("Salary", "Оклад (руб.)");
        }

        private void RefreshTable()
        {
            dataGridViewVivod_NSV.Rows.Clear();
            foreach (var d in drivers)
            {
                dataGridViewVivod_NSV.Rows.Add(d.TabNumber, d.LastName, d.FirstName,
                    d.MiddleName, d.BirthDate.ToShortDateString(), d.Experience, d.Salary);
            }
        }

        private void buttonDobavit_NSV_Click(object sender, EventArgs e)
        {
            var form = new FormInput();
            if (form.ShowDialog() == DialogResult.OK)
            {
                drivers.Add(form.Driver);
                RefreshTable();
            }
        }

        private void buttonIzmen_NSV_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewVivod_NSV.SelectedRows.Count > 0)
            {
                int idx = dataGridViewVivod_NSV.SelectedRows[0].Index;
                if (idx < drivers.Count)
                {
                    var form = new FormInput(drivers[idx]);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        drivers[idx] = form.Driver;
                        RefreshTable();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите строку!");
            }
        }

        private void buttonDelete_NSV_Click(object sender, EventArgs e)
        {
            if (dataGridViewVivod_NSV.SelectedRows.Count > 0)
            {
                int idx = dataGridViewVivod_NSV.SelectedRows[0].Index;
                drivers.RemoveAt(idx);
                RefreshTable();
            }
            else
            {
                MessageBox.Show("Выберите строку!");
            }
        }

        private void buttonSort_NSV_Click(object sender, EventArgs e)
        {
            drivers.Sort((a, b) => a.LastName.CompareTo(b.LastName));
            RefreshTable();
        }

        private void buttonOProg_NSV_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }
    }
}