namespace TransportCompany.forms
{
    partial class FormChooseCertificate
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
            this.comboBoxCertificates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCertificates
            // 
            this.comboBoxCertificates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCertificates.FormattingEnabled = true;
            this.comboBoxCertificates.Location = new System.Drawing.Point(226, 30);
            this.comboBoxCertificates.Name = "comboBoxCertificates";
            this.comboBoxCertificates.Size = new System.Drawing.Size(238, 24);
            this.comboBoxCertificates.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Выберите номер акта";
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(121, 94);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(227, 34);
            this.buttonChoose.TabIndex = 69;
            this.buttonChoose.Text = "Перейти к печати акта";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // FormChooseCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 160);
            this.Controls.Add(this.comboBoxCertificates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChoose);
            this.Name = "FormChooseCertificate";
            this.Text = "Печать акта выполненных работ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxCertificates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChoose;
    }
}