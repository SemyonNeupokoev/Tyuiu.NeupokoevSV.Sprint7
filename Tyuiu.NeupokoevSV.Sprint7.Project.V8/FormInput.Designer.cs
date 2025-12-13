using System.Windows.Forms;
using System.Drawing;
namespace Tyuiu.NeupokoevSV.Sprint7.Project.V8
{
    partial class FormInput
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
            dateTimePickerBirthDate_NSV = new DateTimePicker();
            textBoxSalary_NSV = new TextBox();
            textBoxExperience_NSV = new TextBox();
            textBoxMiddleName_NSV = new TextBox();
            textBoxFirstName_NSV = new TextBox();
            textBoxLastName_NSV = new TextBox();
            labelSalary_NSV = new Label();
            labelExperience_NSV = new Label();
            labelBirthDate_NSV = new Label();
            labelMiddleName_NSV = new Label();
            labelFirstName_NSV = new Label();
            labelLastName_NSV = new Label();
            labelTabNumber_NSV = new Label();
            textBoxTabNumber_NSV = new TextBox();
            buttonSave_NSV = new Button();
            buttonCancel_NSV = new Button();
            SuspendLayout();
            // 
            // dateTimePickerBirthDate_NSV
            // 
            dateTimePickerBirthDate_NSV.Location = new Point(181, 140);
            dateTimePickerBirthDate_NSV.Name = "dateTimePickerBirthDate_NSV";
            dateTimePickerBirthDate_NSV.Size = new Size(149, 23);
            dateTimePickerBirthDate_NSV.TabIndex = 21;
            // 
            // textBoxSalary_NSV
            // 
            textBoxSalary_NSV.Location = new Point(181, 214);
            textBoxSalary_NSV.Name = "textBoxSalary_NSV";
            textBoxSalary_NSV.Size = new Size(149, 23);
            textBoxSalary_NSV.TabIndex = 20;
            // 
            // textBoxExperience_NSV
            // 
            textBoxExperience_NSV.Location = new Point(181, 176);
            textBoxExperience_NSV.Name = "textBoxExperience_NSV";
            textBoxExperience_NSV.Size = new Size(149, 23);
            textBoxExperience_NSV.TabIndex = 19;
            // 
            // textBoxMiddleName_NSV
            // 
            textBoxMiddleName_NSV.Location = new Point(181, 104);
            textBoxMiddleName_NSV.Name = "textBoxMiddleName_NSV";
            textBoxMiddleName_NSV.Size = new Size(149, 23);
            textBoxMiddleName_NSV.TabIndex = 18;
            // 
            // textBoxFirstName_NSV
            // 
            textBoxFirstName_NSV.Location = new Point(181, 74);
            textBoxFirstName_NSV.Name = "textBoxFirstName_NSV";
            textBoxFirstName_NSV.Size = new Size(149, 23);
            textBoxFirstName_NSV.TabIndex = 17;
            // 
            // textBoxLastName_NSV
            // 
            textBoxLastName_NSV.Location = new Point(181, 41);
            textBoxLastName_NSV.Name = "textBoxLastName_NSV";
            textBoxLastName_NSV.Size = new Size(149, 23);
            textBoxLastName_NSV.TabIndex = 16;
            // 
            // labelSalary_NSV
            // 
            labelSalary_NSV.AutoSize = true;
            labelSalary_NSV.Location = new Point(121, 212);
            labelSalary_NSV.Name = "labelSalary_NSV";
            labelSalary_NSV.Size = new Size(41, 15);
            labelSalary_NSV.TabIndex = 15;
            labelSalary_NSV.Text = "Оклад";
            // 
            // labelExperience_NSV
            // 
            labelExperience_NSV.AutoSize = true;
            labelExperience_NSV.Location = new Point(83, 179);
            labelExperience_NSV.Name = "labelExperience_NSV";
            labelExperience_NSV.Size = new Size(79, 15);
            labelExperience_NSV.TabIndex = 14;
            labelExperience_NSV.Text = "Стаж работы";
            // 
            // labelBirthDate_NSV
            // 
            labelBirthDate_NSV.AutoSize = true;
            labelBirthDate_NSV.Location = new Point(72, 140);
            labelBirthDate_NSV.Name = "labelBirthDate_NSV";
            labelBirthDate_NSV.Size = new Size(90, 15);
            labelBirthDate_NSV.TabIndex = 13;
            labelBirthDate_NSV.Text = "Дата рождения";
            // 
            // labelMiddleName_NSV
            // 
            labelMiddleName_NSV.AutoSize = true;
            labelMiddleName_NSV.Location = new Point(104, 107);
            labelMiddleName_NSV.Name = "labelMiddleName_NSV";
            labelMiddleName_NSV.Size = new Size(58, 15);
            labelMiddleName_NSV.TabIndex = 12;
            labelMiddleName_NSV.Text = "Отчество";
            // 
            // labelFirstName_NSV
            // 
            labelFirstName_NSV.AutoSize = true;
            labelFirstName_NSV.Location = new Point(131, 77);
            labelFirstName_NSV.Name = "labelFirstName_NSV";
            labelFirstName_NSV.Size = new Size(31, 15);
            labelFirstName_NSV.TabIndex = 11;
            labelFirstName_NSV.Text = "Имя";
            // 
            // labelLastName_NSV
            // 
            labelLastName_NSV.AutoSize = true;
            labelLastName_NSV.Location = new Point(104, 41);
            labelLastName_NSV.Name = "labelLastName_NSV";
            labelLastName_NSV.Size = new Size(58, 15);
            labelLastName_NSV.TabIndex = 10;
            labelLastName_NSV.Text = "Фамилия";
            // 
            // labelTabNumber_NSV
            // 
            labelTabNumber_NSV.AutoSize = true;
            labelTabNumber_NSV.Location = new Point(55, 9);
            labelTabNumber_NSV.Name = "labelTabNumber_NSV";
            labelTabNumber_NSV.Size = new Size(108, 15);
            labelTabNumber_NSV.TabIndex = 9;
            labelTabNumber_NSV.Text = "Табельный номер";
            // 
            // textBoxTabNumber_NSV
            // 
            textBoxTabNumber_NSV.Location = new Point(181, 9);
            textBoxTabNumber_NSV.Name = "textBoxTabNumber_NSV";
            textBoxTabNumber_NSV.Size = new Size(149, 23);
            textBoxTabNumber_NSV.TabIndex = 8;
            // 
            // buttonSave_NSV
            // 
            buttonSave_NSV.Location = new Point(181, 254);
            buttonSave_NSV.Name = "buttonSave_NSV";
            buttonSave_NSV.Size = new Size(61, 41);
            buttonSave_NSV.TabIndex = 22;
            buttonSave_NSV.Text = "Save";
            buttonSave_NSV.UseVisualStyleBackColor = true;
            buttonSave_NSV.Click += buttonSave_NSV_Click;
            // 
            // buttonCancel_NSV
            // 
            buttonCancel_NSV.Location = new Point(262, 254);
            buttonCancel_NSV.Name = "buttonCancel_NSV";
            buttonCancel_NSV.Size = new Size(68, 41);
            buttonCancel_NSV.TabIndex = 23;
            buttonCancel_NSV.Text = "Cancel";
            buttonCancel_NSV.UseVisualStyleBackColor = true;
            buttonCancel_NSV.Click += buttonCancel_NSV_Click;
            // 
            // FormInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 314);
            Controls.Add(buttonCancel_NSV);
            Controls.Add(buttonSave_NSV);
            Controls.Add(textBoxExperience_NSV);
            Controls.Add(textBoxSalary_NSV);
            Controls.Add(labelExperience_NSV);
            Controls.Add(dateTimePickerBirthDate_NSV);
            Controls.Add(labelSalary_NSV);
            Controls.Add(textBoxMiddleName_NSV);
            Controls.Add(labelBirthDate_NSV);
            Controls.Add(textBoxLastName_NSV);
            Controls.Add(textBoxFirstName_NSV);
            Controls.Add(labelMiddleName_NSV);
            Controls.Add(labelFirstName_NSV);
            Controls.Add(labelLastName_NSV);
            Controls.Add(labelTabNumber_NSV);
            Controls.Add(textBoxTabNumber_NSV);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(384, 353);
            Name = "FormInput";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ввод данных";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerBirthDate_NSV;
        private TextBox textBoxSalary_NSV;
        private TextBox textBoxExperience_NSV;
        private TextBox textBoxMiddleName_NSV;
        private TextBox textBoxFirstName_NSV;
        private TextBox textBoxLastName_NSV;
        private Label labelSalary_NSV;
        private Label labelExperience_NSV;
        private Label labelBirthDate_NSV;
        private Label labelMiddleName_NSV;
        private Label labelFirstName_NSV;
        private Label labelLastName_NSV;
        private Label labelTabNumber_NSV;
        private TextBox textBoxTabNumber_NSV;
        private Button buttonSave_NSV;
        private Button buttonCancel_NSV;
    }
}