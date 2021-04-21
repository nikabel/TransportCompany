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
            this.comboBoxContractNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxSevices = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCertificateNum
            // 
            this.textBoxCertificateNum.Location = new System.Drawing.Point(224, 72);
            this.textBoxCertificateNum.Name = "textBoxCertificateNum";
            this.textBoxCertificateNum.Size = new System.Drawing.Size(238, 22);
            this.textBoxCertificateNum.TabIndex = 76;
            // 
            // dateSign
            // 
            this.dateSign.Location = new System.Drawing.Point(224, 117);
            this.dateSign.Name = "dateSign";
            this.dateSign.Size = new System.Drawing.Size(238, 22);
            this.dateSign.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "Дата подписания";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(182, 287);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(99, 28);
            this.buttonAdd.TabIndex = 73;
            this.buttonAdd.Text = "Оформить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "Номер акта";
            // 
            // comboBoxContractNum
            // 
            this.comboBoxContractNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContractNum.FormattingEnabled = true;
            this.comboBoxContractNum.Location = new System.Drawing.Point(224, 27);
            this.comboBoxContractNum.Name = "comboBoxContractNum";
            this.comboBoxContractNum.Size = new System.Drawing.Size(238, 24);
            this.comboBoxContractNum.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Номер договора";
            // 
            // listBoxSevices
            // 
            this.listBoxSevices.FormattingEnabled = true;
            this.listBoxSevices.ItemHeight = 16;
            this.listBoxSevices.Location = new System.Drawing.Point(224, 160);
            this.listBoxSevices.Name = "listBoxSevices";
            this.listBoxSevices.Size = new System.Drawing.Size(238, 100);
            this.listBoxSevices.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 78;
            this.label5.Text = "Услуги";
            // 
            // FormAddCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 331);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxSevices);
            this.Controls.Add(this.textBoxCertificateNum);
            this.Controls.Add(this.dateSign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxContractNum);
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
        public System.Windows.Forms.ComboBox comboBoxContractNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxSevices;
        private System.Windows.Forms.Label label5;
    }
}