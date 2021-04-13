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
            this.textBoxDriverName = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModelName = new System.Windows.Forms.TextBox();
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Гос. номер транспорта";
            // 
            // textBoxLicensePlate
            // 
            this.textBoxLicensePlate.Location = new System.Drawing.Point(283, 20);
            this.textBoxLicensePlate.Name = "textBoxLicensePlate";
            this.textBoxLicensePlate.Size = new System.Drawing.Size(238, 22);
            this.textBoxLicensePlate.TabIndex = 27;
            // 
            // textBoxDriverName
            // 
            this.textBoxDriverName.Location = new System.Drawing.Point(283, 59);
            this.textBoxDriverName.Name = "textBoxDriverName";
            this.textBoxDriverName.Size = new System.Drawing.Size(238, 22);
            this.textBoxDriverName.TabIndex = 28;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(212, 145);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(101, 28);
            this.buttonChange.TabIndex = 26;
            this.buttonChange.Text = "Сохранить";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Наименование модели";
            // 
            // textBoxModelName
            // 
            this.textBoxModelName.Location = new System.Drawing.Point(283, 99);
            this.textBoxModelName.Name = "textBoxModelName";
            this.textBoxModelName.Size = new System.Drawing.Size(238, 22);
            this.textBoxModelName.TabIndex = 31;
            // 
            // FormChangeTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxModelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLicensePlate);
            this.Controls.Add(this.textBoxDriverName);
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
        public System.Windows.Forms.TextBox textBoxDriverName;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxModelName;
    }
}