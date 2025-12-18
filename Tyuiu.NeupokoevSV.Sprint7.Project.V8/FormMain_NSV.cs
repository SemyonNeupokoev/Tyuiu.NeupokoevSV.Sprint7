using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Tyuiu.NeupokoevSV.Sprint7.Project.V8.Lib;
using static Tyuiu.NeupokoevSV.Sprint7.Project.V8.Lib.DataService;

namespace Tyuiu.NeupokoevSV.Sprint7.Project.V8
{
    public partial class FormMain_NSV : Form
    {
        private List<Driver> drivers = new List<Driver>();
        DataService ds = new DataService();
        public FormMain_NSV()
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
            var form = new FormInput_NSV();
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
                    var form = new FormInput_NSV(drivers[idx]);
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
            FormAbout_NSV formabout = new FormAbout_NSV();
            formabout.ShowDialog();
        }

        private void buttonGrafik_NSV_Click(object sender, EventArgs e)
        {
            if (drivers.Count == 0)
            {
                MessageBox.Show("Нет данных для графика!");
                return;
            }

            chartGrafik_NSV.Series["Series1"].Points.Clear();

            foreach (Driver driver in drivers)
            {
                string initials = $"{driver.LastName[0]}{driver.FirstName[0]}{driver.MiddleName[0]}";

                chartGrafik_NSV.Series["Series1"].Points.AddXY(initials.ToUpper(), (double)driver.Salary);
            }
            chartGrafik_NSV.Series["Series1"]["PointWidth"] = "0.1";
            chartGrafik_NSV.Titles.Clear();
            chartGrafik_NSV.Titles.Add("Оклады водителей");
            chartGrafik_NSV.ChartAreas[0].AxisX.Title = "Водитель";
            chartGrafik_NSV.ChartAreas[0].AxisY.Title = "Оклад, руб.";

            MessageBox.Show("График построен!");
        }

        private void buttonVipoln_NSV_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxMin_NSV.Text, out int min))
            {
                MessageBox.Show("Введите число в 'Мин. стаж'!");
                return;
            }

            if (!int.TryParse(textBoxMaks.Text, out int max))
            {
                MessageBox.Show("Введите число в 'Макс. стаж'!");
                return;
            }

            dataGridViewVivod_NSV.Rows.Clear();

            int count = 0;
            foreach (Driver d in drivers)
            {
                if (d.Experience >= min && d.Experience <= max)
                {
                    dataGridViewVivod_NSV.Rows.Add(d.TabNumber, d.LastName, d.FirstName, d.MiddleName, d.BirthDate.ToShortDateString(), d.Experience, d.Salary);
                    count++;
                }
            }
            if (count == 0)
                MessageBox.Show("Нет таких водителей!");
            else
                MessageBox.Show($"Найдено: {count} водителей");
        }
        private void buttonSred_NSV_Click(object sender, EventArgs e)
        {
            if (drivers.Count == 0)
            {
                MessageBox.Show("Нет данных!");
                return;
            }
            textBoxStaj_NSV.Text = ds.SredStaj(drivers).ToString();
            textBoxOklad_NSV.Text = ds.SredOkl(drivers).ToString();
        }

        private void buttonSearch_NSV_Click(object sender, EventArgs e)
        {
            string search = textBoxPoiskName_NSV.Text.ToLower();

            dataGridViewVivod_NSV.Rows.Clear();

            foreach (var d in drivers)
            {
                if (d.LastName.ToLower().Contains(search) || d.FirstName.ToLower().Contains(search) || d.MiddleName.ToLower().Contains(search))
                {
                    dataGridViewVivod_NSV.Rows.Add(d.TabNumber, d.LastName, d.FirstName, d.MiddleName, d.BirthDate.ToShortDateString(), d.Experience, d.Salary);
                }
            }
        }

        private void buttonSohr_NSV_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_NSV.ShowDialog() == DialogResult.OK)
            {
                var lines = new List<string>();
                var headers = dataGridViewVivod_NSV.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText);
                lines.Add(string.Join("\t", headers));

                foreach (DataGridViewRow row in dataGridViewVivod_NSV.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString() ?? "");
                        lines.Add(string.Join("\t", cells));
                    }
                }

                File.WriteAllLines(saveFileDialog_NSV.FileName, lines, Encoding.UTF8);
            }
        }

        private void buttonOpenDrugoi_NSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openDialog.FileName;
                dataGridViewVivod_NSV.Rows.Clear();
                dataGridViewVivod_NSV.Columns.Clear();
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
                if (lines.Length == 0) return;

                char separator = lines[0].Contains('\t') ? '\t' : ' ';

                string[] headers = lines[0].Split(separator);
                foreach (string header in headers)
                {
                    dataGridViewVivod_NSV.Columns.Add(header.Trim(), header.Trim());
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(lines[i]))
                    {
                        string[] values = lines[i].Split(separator);
                        dataGridViewVivod_NSV.Rows.Add(values);
                    }
                }
            }
        }
    }
}