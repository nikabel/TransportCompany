namespace TransportCompany.forms
{
    partial class FormChangeIndividual
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxACC = new System.Windows.Forms.TextBox();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.textBoxRCBIC = new System.Windows.Forms.TextBox();
            this.textBoxOGRN = new System.Windows.Forms.TextBox();
            this.textBoxCorrACC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBankName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 93;
            this.label1.Text = "Фактический адрес";
            // 
            // textBoxAdr
            // 
            this.textBoxAdr.Location = new System.Drawing.Point(202, 142);
            this.textBoxAdr.MaxLength = 300;
            this.textBoxAdr.Multiline = true;
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(238, 54);
            this.textBoxAdr.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 91;
            this.label7.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(202, 59);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(238, 22);
            this.textBoxEmail.TabIndex = 90;
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmail_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "Номер телефона";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(202, 100);
            this.textBoxTel.MaxLength = 11;
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(238, 22);
            this.textBoxTel.TabIndex = 85;
            this.textBoxTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTel_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 83;
            this.label5.Text = "ФИО";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(202, 20);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(238, 22);
            this.textBoxName.TabIndex = 82;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(173, 481);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(111, 39);
            this.buttonChange.TabIndex = 81;
            this.buttonChange.Text = "Сохранить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxACC
            // 
            this.textBoxACC.Location = new System.Drawing.Point(202, 218);
            this.textBoxACC.MaxLength = 20;
            this.textBoxACC.Name = "textBoxACC";
            this.textBoxACC.Size = new System.Drawing.Size(238, 22);
            this.textBoxACC.TabIndex = 94;
            this.textBoxACC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxACC_KeyPress);
            // 
            // textBoxINN
            // 
            this.textBoxINN.Location = new System.Drawing.Point(202, 259);
            this.textBoxINN.MaxLength = 12;
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(238, 22);
            this.textBoxINN.TabIndex = 95;
            this.textBoxINN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxINN_KeyPress);
            // 
            // textBoxRCBIC
            // 
            this.textBoxRCBIC.Location = new System.Drawing.Point(202, 301);
            this.textBoxRCBIC.MaxLength = 9;
            this.textBoxRCBIC.Name = "textBoxRCBIC";
            this.textBoxRCBIC.Size = new System.Drawing.Size(238, 22);
            this.textBoxRCBIC.TabIndex = 96;
            this.textBoxRCBIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRCBIC_KeyPress);
            // 
            // textBoxOGRN
            // 
            this.textBoxOGRN.Location = new System.Drawing.Point(202, 344);
            this.textBoxOGRN.MaxLength = 13;
            this.textBoxOGRN.Name = "textBoxOGRN";
            this.textBoxOGRN.Size = new System.Drawing.Size(238, 22);
            this.textBoxOGRN.TabIndex = 97;
            this.textBoxOGRN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOGRN_KeyPress);
            // 
            // textBoxCorrACC
            // 
            this.textBoxCorrACC.Location = new System.Drawing.Point(202, 385);
            this.textBoxCorrACC.MaxLength = 20;
            this.textBoxCorrACC.Name = "textBoxCorrACC";
            this.textBoxCorrACC.Size = new System.Drawing.Size(238, 22);
            this.textBoxCorrACC.TabIndex = 98;
            this.textBoxCorrACC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCorrACC_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 99;
            this.label2.Text = "Расчетный счет";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 100;
            this.label3.Text = "ИНН";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 101;
            this.label6.Text = "БИК";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 102;
            this.label8.Text = "ОГРНИП";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 17);
            this.label9.TabIndex = 103;
            this.label9.Text = "Корреспондентский счет";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 105;
            this.label10.Text = "Название банка";
            // 
            // textBoxBankName
            // 
            this.textBoxBankName.Location = new System.Drawing.Point(202, 428);
            this.textBoxBankName.MaxLength = 50;
            this.textBoxBankName.Name = "textBoxBankName";
            this.textBoxBankName.Size = new System.Drawing.Size(238, 22);
            this.textBoxBankName.TabIndex = 104;
            // 
            // FormChangeIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 532);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxBankName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCorrACC);
            this.Controls.Add(this.textBoxOGRN);
            this.Controls.Add(this.textBoxRCBIC);
            this.Controls.Add(this.textBoxINN);
            this.Controls.Add(this.textBoxACC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonChange);
            this.Name = "FormChangeIndividual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о заказчиках";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxAdr;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonChange;
        public System.Windows.Forms.TextBox textBoxACC;
        public System.Windows.Forms.TextBox textBoxINN;
        public System.Windows.Forms.TextBox textBoxRCBIC;
        public System.Windows.Forms.TextBox textBoxOGRN;
        public System.Windows.Forms.TextBox textBoxCorrACC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textBoxBankName;
    }
}