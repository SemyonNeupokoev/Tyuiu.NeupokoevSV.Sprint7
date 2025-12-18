namespace Tyuiu.NeupokoevSV.Sprint7.Project.V8
{
    partial class FormAbout_NSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_NSV));
            labelInfo_NSV = new Label();
            pictureBoxMe_NSV = new PictureBox();
            buttonOk_NSV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_NSV).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_NSV
            // 
            labelInfo_NSV.AutoSize = true;
            labelInfo_NSV.Font = new Font("Segoe UI", 12F);
            labelInfo_NSV.Location = new Point(200, 9);
            labelInfo_NSV.Name = "labelInfo_NSV";
            labelInfo_NSV.Size = new Size(396, 189);
            labelInfo_NSV.TabIndex = 0;
            labelInfo_NSV.Text = resources.GetString("labelInfo_NSV.Text");
            // 
            // pictureBoxMe_NSV
            // 
            pictureBoxMe_NSV.Image = Properties.Resources.aa;
            pictureBoxMe_NSV.Location = new Point(12, 9);
            pictureBoxMe_NSV.Name = "pictureBoxMe_NSV";
            pictureBoxMe_NSV.Size = new Size(171, 213);
            pictureBoxMe_NSV.TabIndex = 1;
            pictureBoxMe_NSV.TabStop = false;
            // 
            // buttonOk_NSV
            // 
            buttonOk_NSV.Font = new Font("Segoe UI", 12F);
            buttonOk_NSV.Location = new Point(521, 224);
            buttonOk_NSV.Name = "buttonOk_NSV";
            buttonOk_NSV.Size = new Size(75, 37);
            buttonOk_NSV.TabIndex = 2;
            buttonOk_NSV.Text = "OK";
            buttonOk_NSV.UseVisualStyleBackColor = true;
            buttonOk_NSV.Click += buttonOk_NSV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 273);
            Controls.Add(buttonOk_NSV);
            Controls.Add(pictureBoxMe_NSV);
            Controls.Add(labelInfo_NSV);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_NSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_NSV;
        private PictureBox pictureBoxMe_NSV;
        private Button buttonOk_NSV;
    }
}