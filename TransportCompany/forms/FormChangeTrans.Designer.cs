namespace TransportCompany.forms
{
    partial class FormChangeTrans
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLicensePlate = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDrivers = new System.Windows.Forms.ComboBox();
            this.comboBoxModels = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "ФИО водителя";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Гос. номер транспорта";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxLicensePlate
            // 
            this.textBoxLicensePlate.Location = new System.Drawing.Point(283, 20);
            this.textBoxLicensePlate.MaxLength = 9;
            this.textBoxLicensePlate.Name = "textBoxLicensePlate";
            this.textBoxLicensePlate.Size = new System.Drawing.Size(238, 22);
            this.textBoxLicensePlate.TabIndex = 27;
            this.textBoxLicensePlate.TextChanged += new System.EventHandler(this.textBoxLicensePlate_TextChanged);
            this.textBoxLicensePlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLicensePlate_KeyPress);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(207, 153);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(120, 37);
            this.buttonChange.TabIndex = 26;
            this.buttonChange.Text = "Сохранить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Наименование модели";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.Location = new System.Drawing.Point(283, 62);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(238, 24);
            this.comboBoxDrivers.TabIndex = 33;
            this.comboBoxDrivers.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrivers_SelectedIndexChanged);
            // 
            // comboBoxModels
            // 
            this.comboBoxModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModels.FormattingEnabled = true;
            this.comboBoxModels.Location = new System.Drawing.Point(283, 102);
            this.comboBoxModels.Name = "comboBoxModels";
            this.comboBoxModels.Size = new System.Drawing.Size(238, 24);
            this.comboBoxModels.TabIndex = 34;
            this.comboBoxModels.SelectedIndexChanged += new System.EventHandler(this.comboBoxModels_SelectedIndexChanged);
            // 
            // FormChangeTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 210);
            this.Controls.Add(this.comboBoxModels);
            this.Controls.Add(this.comboBoxDrivers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLicensePlate);
            this.Controls.Add(this.buttonChange);
            this.Name = "FormChangeTrans";
            this.Text = "Информация о транспорте";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxLicensePlate;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxDrivers;
        public System.Windows.Forms.ComboBox comboBoxModels;
    }
}