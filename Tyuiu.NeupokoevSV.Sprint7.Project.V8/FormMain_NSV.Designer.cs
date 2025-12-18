namespace Tyuiu.NeupokoevSV.Sprint7.Project.V8
{
    partial class FormMain_NSV
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxSearch_NSV = new GroupBox();
            textBoxPoiskName_NSV = new TextBox();
            buttonSearch_NSV = new Button();
            panelKnopki_NSV = new Panel();
            groupBoxKnopki_NSV = new GroupBox();
            buttonOpenDrugoi_NSV = new Button();
            buttonSohr_NSV = new Button();
            buttonOProg_NSV = new Button();
            buttonDelete_NSV = new Button();
            buttonSort_NSV = new Button();
            buttonIzmen_NSV = new Button();
            buttonDobavit_NSV = new Button();
            groupBoxFilter_NSV = new GroupBox();
            buttonSred_NSV = new Button();
            textBoxOklad_NSV = new TextBox();
            textBoxStaj_NSV = new TextBox();
            textBoxSred_NSV = new TextBox();
            buttonVipoln_NSV = new Button();
            textBoxMaks = new TextBox();
            textBoxMin_NSV = new TextBox();
            textBoxStag_NSV = new TextBox();
            panelTop_NSV = new Panel();
            panelGrafik_NSV = new Panel();
            groupBoxGrafik_NSV = new GroupBox();
            buttonGrafik_NSV = new Button();
            chartGrafik_NSV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelFiltr_NSV = new Panel();
            panelSearch_NSV = new Panel();
            panelFall_NSV = new Panel();
            dataGridViewVivod_NSV = new DataGridView();
            toolTip_NSV = new ToolTip(components);
            saveFileDialog_NSV = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            groupBoxSearch_NSV.SuspendLayout();
            panelKnopki_NSV.SuspendLayout();
            groupBoxKnopki_NSV.SuspendLayout();
            groupBoxFilter_NSV.SuspendLayout();
            panelTop_NSV.SuspendLayout();
            panelGrafik_NSV.SuspendLayout();
            groupBoxGrafik_NSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGrafik_NSV).BeginInit();
            panelFiltr_NSV.SuspendLayout();
            panelSearch_NSV.SuspendLayout();
            panelFall_NSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVivod_NSV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxSearch_NSV
            // 
            groupBoxSearch_NSV.Controls.Add(textBoxPoiskName_NSV);
            groupBoxSearch_NSV.Controls.Add(buttonSearch_NSV);
            groupBoxSearch_NSV.Dock = DockStyle.Fill;
            groupBoxSearch_NSV.Font = new Font("Segoe UI", 11F);
            groupBoxSearch_NSV.Location = new Point(0, 0);
            groupBoxSearch_NSV.Name = "groupBoxSearch_NSV";
            groupBoxSearch_NSV.Size = new Size(111, 245);
            groupBoxSearch_NSV.TabIndex = 0;
            groupBoxSearch_NSV.TabStop = false;
            groupBoxSearch_NSV.Text = "Поиск";
            // 
            // textBoxPoiskName_NSV
            // 
            textBoxPoiskName_NSV.BackColor = SystemColors.Window;
            textBoxPoiskName_NSV.Location = new Point(4, 47);
            textBoxPoiskName_NSV.Multiline = true;
            textBoxPoiskName_NSV.Name = "textBoxPoiskName_NSV";
            textBoxPoiskName_NSV.Size = new Size(102, 23);
            textBoxPoiskName_NSV.TabIndex = 2;
            // 
            // buttonSearch_NSV
            // 
            buttonSearch_NSV.Location = new Point(20, 100);
            buttonSearch_NSV.Name = "buttonSearch_NSV";
            buttonSearch_NSV.Size = new Size(75, 34);
            buttonSearch_NSV.TabIndex = 1;
            buttonSearch_NSV.Text = "Искать";
            toolTip_NSV.SetToolTip(buttonSearch_NSV, "Происходит поиск по имени, фамилии или отчеству");
            buttonSearch_NSV.UseVisualStyleBackColor = true;
            buttonSearch_NSV.Click += buttonSearch_NSV_Click;
            // 
            // panelKnopki_NSV
            // 
            panelKnopki_NSV.Controls.Add(groupBoxKnopki_NSV);
            panelKnopki_NSV.Dock = DockStyle.Left;
            panelKnopki_NSV.Location = new Point(0, 0);
            panelKnopki_NSV.Name = "panelKnopki_NSV";
            panelKnopki_NSV.Size = new Size(450, 245);
            panelKnopki_NSV.TabIndex = 1;
            // 
            // groupBoxKnopki_NSV
            // 
            groupBoxKnopki_NSV.Controls.Add(buttonOpenDrugoi_NSV);
            groupBoxKnopki_NSV.Controls.Add(buttonSohr_NSV);
            groupBoxKnopki_NSV.Controls.Add(buttonOProg_NSV);
            groupBoxKnopki_NSV.Controls.Add(buttonDelete_NSV);
            groupBoxKnopki_NSV.Controls.Add(buttonSort_NSV);
            groupBoxKnopki_NSV.Controls.Add(buttonIzmen_NSV);
            groupBoxKnopki_NSV.Controls.Add(buttonDobavit_NSV);
            groupBoxKnopki_NSV.Dock = DockStyle.Fill;
            groupBoxKnopki_NSV.Font = new Font("Segoe UI", 11F);
            groupBoxKnopki_NSV.Location = new Point(0, 0);
            groupBoxKnopki_NSV.Name = "groupBoxKnopki_NSV";
            groupBoxKnopki_NSV.Size = new Size(450, 245);
            groupBoxKnopki_NSV.TabIndex = 0;
            groupBoxKnopki_NSV.TabStop = false;
            groupBoxKnopki_NSV.Text = "Работа с данными и файлом";
            // 
            // buttonOpenDrugoi_NSV
            // 
            buttonOpenDrugoi_NSV.Image = Properties.Resources.folder_go;
            buttonOpenDrugoi_NSV.Location = new Point(109, 118);
            buttonOpenDrugoi_NSV.Name = "buttonOpenDrugoi_NSV";
            buttonOpenDrugoi_NSV.Size = new Size(98, 52);
            buttonOpenDrugoi_NSV.TabIndex = 1;
            toolTip_NSV.SetToolTip(buttonOpenDrugoi_NSV, "Открыть в другом файле");
            buttonOpenDrugoi_NSV.UseVisualStyleBackColor = true;
            buttonOpenDrugoi_NSV.Click += buttonOpenDrugoi_NSV_Click;
            // 
            // buttonSohr_NSV
            // 
            buttonSohr_NSV.Image = Properties.Resources.folder_page_white;
            buttonSohr_NSV.Location = new Point(3, 118);
            buttonSohr_NSV.Name = "buttonSohr_NSV";
            buttonSohr_NSV.Size = new Size(100, 52);
            buttonSohr_NSV.TabIndex = 1;
            toolTip_NSV.SetToolTip(buttonSohr_NSV, "Сохранить данные");
            buttonSohr_NSV.UseVisualStyleBackColor = true;
            buttonSohr_NSV.Click += buttonSohr_NSV_Click;
            // 
            // buttonOProg_NSV
            // 
            buttonOProg_NSV.Image = Properties.Resources.help;
            buttonOProg_NSV.Location = new Point(213, 118);
            buttonOProg_NSV.Name = "buttonOProg_NSV";
            buttonOProg_NSV.Size = new Size(108, 52);
            buttonOProg_NSV.TabIndex = 1;
            toolTip_NSV.SetToolTip(buttonOProg_NSV, "О программе");
            buttonOProg_NSV.UseVisualStyleBackColor = true;
            buttonOProg_NSV.Click += buttonOProg_NSV_Click;
            // 
            // buttonDelete_NSV
            // 
            buttonDelete_NSV.Font = new Font("Segoe UI", 12F);
            buttonDelete_NSV.Location = new Point(213, 22);
            buttonDelete_NSV.Name = "buttonDelete_NSV";
            buttonDelete_NSV.Size = new Size(108, 48);
            buttonDelete_NSV.TabIndex = 0;
            buttonDelete_NSV.Text = "Удалить";
            toolTip_NSV.SetToolTip(buttonDelete_NSV, "Удалить информацию о водителе");
            buttonDelete_NSV.UseVisualStyleBackColor = true;
            buttonDelete_NSV.Click += buttonDelete_NSV_Click;
            // 
            // buttonSort_NSV
            // 
            buttonSort_NSV.Font = new Font("Segoe UI", 12F);
            buttonSort_NSV.Location = new Point(327, 22);
            buttonSort_NSV.Name = "buttonSort_NSV";
            buttonSort_NSV.Size = new Size(118, 48);
            buttonSort_NSV.TabIndex = 0;
            buttonSort_NSV.Text = "Сортировать";
            toolTip_NSV.SetToolTip(buttonSort_NSV, "Сортировка по фамилии");
            buttonSort_NSV.UseVisualStyleBackColor = true;
            buttonSort_NSV.Click += buttonSort_NSV_Click;
            // 
            // buttonIzmen_NSV
            // 
            buttonIzmen_NSV.Font = new Font("Segoe UI", 12F);
            buttonIzmen_NSV.Location = new Point(109, 22);
            buttonIzmen_NSV.Name = "buttonIzmen_NSV";
            buttonIzmen_NSV.Size = new Size(98, 48);
            buttonIzmen_NSV.TabIndex = 0;
            buttonIzmen_NSV.Text = "Изменить";
            toolTip_NSV.SetToolTip(buttonIzmen_NSV, "Изменить информацию о водителе");
            buttonIzmen_NSV.UseVisualStyleBackColor = true;
            buttonIzmen_NSV.Click += buttonIzmen_NSV_Click_1;
            // 
            // buttonDobavit_NSV
            // 
            buttonDobavit_NSV.Font = new Font("Segoe UI", 12F);
            buttonDobavit_NSV.Location = new Point(3, 22);
            buttonDobavit_NSV.Name = "buttonDobavit_NSV";
            buttonDobavit_NSV.Size = new Size(100, 48);
            buttonDobavit_NSV.TabIndex = 0;
            buttonDobavit_NSV.Text = "Добавить";
            toolTip_NSV.SetToolTip(buttonDobavit_NSV, "Добавить информацию о водителе");
            buttonDobavit_NSV.UseVisualStyleBackColor = true;
            buttonDobavit_NSV.Click += buttonDobavit_NSV_Click;
            // 
            // groupBoxFilter_NSV
            // 
            groupBoxFilter_NSV.Controls.Add(buttonSred_NSV);
            groupBoxFilter_NSV.Controls.Add(textBoxOklad_NSV);
            groupBoxFilter_NSV.Controls.Add(textBoxStaj_NSV);
            groupBoxFilter_NSV.Controls.Add(textBoxSred_NSV);
            groupBoxFilter_NSV.Controls.Add(buttonVipoln_NSV);
            groupBoxFilter_NSV.Controls.Add(textBoxMaks);
            groupBoxFilter_NSV.Controls.Add(textBoxMin_NSV);
            groupBoxFilter_NSV.Controls.Add(textBoxStag_NSV);
            groupBoxFilter_NSV.Dock = DockStyle.Fill;
            groupBoxFilter_NSV.Font = new Font("Segoe UI", 11F);
            groupBoxFilter_NSV.Location = new Point(0, 0);
            groupBoxFilter_NSV.Name = "groupBoxFilter_NSV";
            groupBoxFilter_NSV.Size = new Size(192, 245);
            groupBoxFilter_NSV.TabIndex = 0;
            groupBoxFilter_NSV.TabStop = false;
            groupBoxFilter_NSV.Text = "Фильтрация и среднее";
            // 
            // buttonSred_NSV
            // 
            buttonSred_NSV.Location = new Point(47, 209);
            buttonSred_NSV.Name = "buttonSred_NSV";
            buttonSred_NSV.Size = new Size(95, 28);
            buttonSred_NSV.TabIndex = 4;
            buttonSred_NSV.Text = "Выполнить";
            toolTip_NSV.SetToolTip(buttonSred_NSV, "Посчитать средний стаж и оклад");
            buttonSred_NSV.UseVisualStyleBackColor = true;
            buttonSred_NSV.Click += buttonSred_NSV_Click;
            // 
            // textBoxOklad_NSV
            // 
            textBoxOklad_NSV.Location = new Point(118, 171);
            textBoxOklad_NSV.Multiline = true;
            textBoxOklad_NSV.Name = "textBoxOklad_NSV";
            textBoxOklad_NSV.Size = new Size(68, 27);
            textBoxOklad_NSV.TabIndex = 3;
            // 
            // textBoxStaj_NSV
            // 
            textBoxStaj_NSV.Location = new Point(118, 137);
            textBoxStaj_NSV.Name = "textBoxStaj_NSV";
            textBoxStaj_NSV.Size = new Size(68, 27);
            textBoxStaj_NSV.TabIndex = 3;
            // 
            // textBoxSred_NSV
            // 
            textBoxSred_NSV.BackColor = SystemColors.Menu;
            textBoxSred_NSV.BorderStyle = BorderStyle.None;
            textBoxSred_NSV.Location = new Point(3, 136);
            textBoxSred_NSV.Multiline = true;
            textBoxSred_NSV.Name = "textBoxSred_NSV";
            textBoxSred_NSV.Size = new Size(115, 69);
            textBoxSred_NSV.TabIndex = 2;
            textBoxSred_NSV.Text = "Средний стаж\r\n\r\nСредний оклад";
            // 
            // buttonVipoln_NSV
            // 
            buttonVipoln_NSV.Location = new Point(47, 100);
            buttonVipoln_NSV.Name = "buttonVipoln_NSV";
            buttonVipoln_NSV.Size = new Size(95, 34);
            buttonVipoln_NSV.TabIndex = 1;
            buttonVipoln_NSV.Text = "Выполнить";
            toolTip_NSV.SetToolTip(buttonVipoln_NSV, "Выполняется фильтрация по стажу");
            buttonVipoln_NSV.UseVisualStyleBackColor = true;
            buttonVipoln_NSV.Click += buttonVipoln_NSV_Click;
            // 
            // textBoxMaks
            // 
            textBoxMaks.Location = new Point(118, 67);
            textBoxMaks.Multiline = true;
            textBoxMaks.Name = "textBoxMaks";
            textBoxMaks.Size = new Size(68, 27);
            textBoxMaks.TabIndex = 0;
            // 
            // textBoxMin_NSV
            // 
            textBoxMin_NSV.Location = new Point(118, 34);
            textBoxMin_NSV.Multiline = true;
            textBoxMin_NSV.Name = "textBoxMin_NSV";
            textBoxMin_NSV.Size = new Size(68, 27);
            textBoxMin_NSV.TabIndex = 0;
            // 
            // textBoxStag_NSV
            // 
            textBoxStag_NSV.BackColor = SystemColors.Menu;
            textBoxStag_NSV.BorderStyle = BorderStyle.None;
            textBoxStag_NSV.Font = new Font("Segoe UI", 11F);
            textBoxStag_NSV.Location = new Point(3, 34);
            textBoxStag_NSV.Multiline = true;
            textBoxStag_NSV.Name = "textBoxStag_NSV";
            textBoxStag_NSV.ReadOnly = true;
            textBoxStag_NSV.Size = new Size(90, 60);
            textBoxStag_NSV.TabIndex = 0;
            textBoxStag_NSV.Text = "Мин. стаж\r\n\r\nМакс. стаж";
            // 
            // panelTop_NSV
            // 
            panelTop_NSV.Controls.Add(panelGrafik_NSV);
            panelTop_NSV.Controls.Add(panelFiltr_NSV);
            panelTop_NSV.Controls.Add(panelSearch_NSV);
            panelTop_NSV.Controls.Add(panelKnopki_NSV);
            panelTop_NSV.Dock = DockStyle.Top;
            panelTop_NSV.Location = new Point(0, 0);
            panelTop_NSV.Name = "panelTop_NSV";
            panelTop_NSV.Size = new Size(1035, 245);
            panelTop_NSV.TabIndex = 0;
            // 
            // panelGrafik_NSV
            // 
            panelGrafik_NSV.Controls.Add(groupBoxGrafik_NSV);
            panelGrafik_NSV.Dock = DockStyle.Fill;
            panelGrafik_NSV.Location = new Point(450, 0);
            panelGrafik_NSV.Name = "panelGrafik_NSV";
            panelGrafik_NSV.Size = new Size(282, 245);
            panelGrafik_NSV.TabIndex = 3;
            // 
            // groupBoxGrafik_NSV
            // 
            groupBoxGrafik_NSV.Controls.Add(buttonGrafik_NSV);
            groupBoxGrafik_NSV.Controls.Add(chartGrafik_NSV);
            groupBoxGrafik_NSV.Dock = DockStyle.Fill;
            groupBoxGrafik_NSV.Font = new Font("Segoe UI", 11F);
            groupBoxGrafik_NSV.Location = new Point(0, 0);
            groupBoxGrafik_NSV.Name = "groupBoxGrafik_NSV";
            groupBoxGrafik_NSV.Size = new Size(282, 245);
            groupBoxGrafik_NSV.TabIndex = 0;
            groupBoxGrafik_NSV.TabStop = false;
            groupBoxGrafik_NSV.Text = "График";
            // 
            // buttonGrafik_NSV
            // 
            buttonGrafik_NSV.Dock = DockStyle.Bottom;
            buttonGrafik_NSV.Location = new Point(3, 170);
            buttonGrafik_NSV.Name = "buttonGrafik_NSV";
            buttonGrafik_NSV.Size = new Size(276, 72);
            buttonGrafik_NSV.TabIndex = 1;
            buttonGrafik_NSV.Text = "Отобразить";
            toolTip_NSV.SetToolTip(buttonGrafik_NSV, "Отобразить на графике оклады\r\n");
            buttonGrafik_NSV.UseVisualStyleBackColor = true;
            buttonGrafik_NSV.Click += buttonGrafik_NSV_Click;
            // 
            // chartGrafik_NSV
            // 
            chartArea1.Name = "ChartArea1";
            chartGrafik_NSV.ChartAreas.Add(chartArea1);
            chartGrafik_NSV.Dock = DockStyle.Top;
            legend1.Name = "Legend1";
            chartGrafik_NSV.Legends.Add(legend1);
            chartGrafik_NSV.Location = new Point(3, 23);
            chartGrafik_NSV.Name = "chartGrafik_NSV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGrafik_NSV.Series.Add(series1);
            chartGrafik_NSV.Size = new Size(276, 147);
            chartGrafik_NSV.TabIndex = 0;
            chartGrafik_NSV.Text = "Оклад Водителей";
            // 
            // panelFiltr_NSV
            // 
            panelFiltr_NSV.Controls.Add(groupBoxFilter_NSV);
            panelFiltr_NSV.Dock = DockStyle.Right;
            panelFiltr_NSV.Location = new Point(732, 0);
            panelFiltr_NSV.Name = "panelFiltr_NSV";
            panelFiltr_NSV.Size = new Size(192, 245);
            panelFiltr_NSV.TabIndex = 2;
            // 
            // panelSearch_NSV
            // 
            panelSearch_NSV.Controls.Add(groupBoxSearch_NSV);
            panelSearch_NSV.Dock = DockStyle.Right;
            panelSearch_NSV.Location = new Point(924, 0);
            panelSearch_NSV.Name = "panelSearch_NSV";
            panelSearch_NSV.Size = new Size(111, 245);
            panelSearch_NSV.TabIndex = 1;
            // 
            // panelFall_NSV
            // 
            panelFall_NSV.Controls.Add(dataGridViewVivod_NSV);
            panelFall_NSV.Dock = DockStyle.Fill;
            panelFall_NSV.Location = new Point(0, 245);
            panelFall_NSV.Name = "panelFall_NSV";
            panelFall_NSV.Size = new Size(1035, 270);
            panelFall_NSV.TabIndex = 1;
            // 
            // dataGridViewVivod_NSV
            // 
            dataGridViewVivod_NSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVivod_NSV.Dock = DockStyle.Fill;
            dataGridViewVivod_NSV.Location = new Point(0, 0);
            dataGridViewVivod_NSV.Name = "dataGridViewVivod_NSV";
            dataGridViewVivod_NSV.ReadOnly = true;
            dataGridViewVivod_NSV.ScrollBars = ScrollBars.Vertical;
            dataGridViewVivod_NSV.Size = new Size(1035, 270);
            dataGridViewVivod_NSV.TabIndex = 0;
            // 
            // toolTip_NSV
            // 
            toolTip_NSV.ToolTipIcon = ToolTipIcon.Info;
            toolTip_NSV.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain_NSV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 515);
            Controls.Add(panelFall_NSV);
            Controls.Add(panelTop_NSV);
            Name = "FormMain_NSV";
            Text = "Автотранспортное предприятие";
            WindowState = FormWindowState.Maximized;
            groupBoxSearch_NSV.ResumeLayout(false);
            groupBoxSearch_NSV.PerformLayout();
            panelKnopki_NSV.ResumeLayout(false);
            groupBoxKnopki_NSV.ResumeLayout(false);
            groupBoxFilter_NSV.ResumeLayout(false);
            groupBoxFilter_NSV.PerformLayout();
            panelTop_NSV.ResumeLayout(false);
            panelGrafik_NSV.ResumeLayout(false);
            groupBoxGrafik_NSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGrafik_NSV).EndInit();
            panelFiltr_NSV.ResumeLayout(false);
            panelSearch_NSV.ResumeLayout(false);
            panelFall_NSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVivod_NSV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxSearch_NSV;
        private Panel panelKnopki_NSV;
        private GroupBox groupBoxKnopki_NSV;
        private Button buttonDelete_NSV;
        private Button buttonSort_NSV;
        private Button buttonIzmen_NSV;
        private Button buttonDobavit_NSV;
        private GroupBox groupBoxFilter_NSV;
        private Panel panelTop_NSV;
        private GroupBox groupBoxGrafik_NSV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrafik_NSV;
        private Panel panelSearch_NSV;
        private Panel panelGrafik_NSV;
        private Panel panelFiltr_NSV;
        private Panel panelFall_NSV;
        private Button buttonOpenDrugoi_NSV;
        private Button buttonSohr_NSV;
        private Button buttonOProg_NSV;
        private DataGridView dataGridViewVivod_NSV;
        private ToolTip toolTip_NSV;
        private TextBox textBoxMaks;
        private TextBox textBoxPoisk_NSV;
        private TextBox textBoxMin_NSV;
        private TextBox textBoxStag_NSV;
        private Button buttonSearch_NSV;
        private Button buttonVipoln_NSV;
        private TextBox textBoxPoiskName_NSV;
        private Button buttonGrafik_NSV;
        private TextBox textBoxSred_NSV;
        private TextBox textBoxOklad_NSV;
        private TextBox textBoxStaj_NSV;
        private Button buttonSred_NSV;
        private SaveFileDialog saveFileDialog_NSV;
        private OpenFileDialog openFileDialog1;
    }
}
