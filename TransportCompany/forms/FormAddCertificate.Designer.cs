namespace TransportCompany.forms
{
    partial class FormAddCertificate
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
            this.textBoxCertificateNum = new System.Windows.Forms.TextBox();
            this.dateSign = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxContracts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCertificateNum
            // 
            this.textBoxCertificateNum.Location = new System.Drawing.Point(222, 66);
            this.textBoxCertificateNum.MaxLength = 50;
            this.textBoxCertificateNum.Name = "textBoxCertificateNum";
            this.textBoxCertificateNum.Size = new System.Drawing.Size(238, 22);
            this.textBoxCertificateNum.TabIndex = 76;
            // 
            // dateSign
            // 
            this.dateSign.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSign.Location = new System.Drawing.Point(222, 111);
            this.dateSign.Name = "dateSign";
            this.dateSign.Size = new System.Drawing.Size(238, 22);
            this.dateSign.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "Дата подписания";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(180, 163);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 34);
            this.buttonAdd.TabIndex = 73;
            this.buttonAdd.Text = "Оформить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "Номер акта";
            // 
            // comboBoxContracts
            // 
            this.comboBoxContracts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContracts.FormattingEnabled = true;
            this.comboBoxContracts.Location = new System.Drawing.Point(222, 21);
            this.comboBoxContracts.Name = "comboBoxContracts";
            this.comboBoxContracts.Size = new System.Drawing.Size(238, 24);
            this.comboBoxContracts.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Номер договора";
            // 
            // FormAddCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 218);
            this.Controls.Add(this.textBoxCertificateNum);
            this.Controls.Add(this.dateSign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxContracts);
            this.Controls.Add(this.label2);
            this.Name = "FormAddCertificate";
            this.Text = "Оформление акта выполненных работ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCertificateNum;
        private System.Windows.Forms.DateTimePicker dateSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBoxContracts;
        private System.Windows.Forms.Label label2;
    }
}