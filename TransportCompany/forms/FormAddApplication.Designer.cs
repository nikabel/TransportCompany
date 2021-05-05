namespace TransportCompany.forms
{
    partial class FormAddApplication
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
            this.textBoxApplicationNum = new System.Windows.Forms.TextBox();
            this.dateSign = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxContracts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDelivery = new System.Windows.Forms.DateTimePicker();
            this.textBoxFreight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxInsurance = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxApplicationNum
            // 
            this.textBoxApplicationNum.Location = new System.Drawing.Point(223, 67);
            this.textBoxApplicationNum.Name = "textBoxApplicationNum";
            this.textBoxApplicationNum.Size = new System.Drawing.Size(238, 22);
            this.textBoxApplicationNum.TabIndex = 85;
            // 
            // dateSign
            // 
            this.dateSign.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSign.Location = new System.Drawing.Point(223, 112);
            this.dateSign.Name = "dateSign";
            this.dateSign.Size = new System.Drawing.Size(238, 22);
            this.dateSign.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "Дата подписания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "Номер заявки";
            // 
            // comboBoxContracts
            // 
            this.comboBoxContracts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContracts.FormattingEnabled = true;
            this.comboBoxContracts.Location = new System.Drawing.Point(223, 22);
            this.comboBoxContracts.Name = "comboBoxContracts";
            this.comboBoxContracts.Size = new System.Drawing.Size(238, 24);
            this.comboBoxContracts.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "Номер договора";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "Срок доставки";
            // 
            // dateDelivery
            // 
            this.dateDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDelivery.Location = new System.Drawing.Point(223, 153);
            this.dateDelivery.Name = "dateDelivery";
            this.dateDelivery.Size = new System.Drawing.Size(238, 22);
            this.dateDelivery.TabIndex = 89;
            // 
            // textBoxFreight
            // 
            this.textBoxFreight.Location = new System.Drawing.Point(223, 195);
            this.textBoxFreight.Name = "textBoxFreight";
            this.textBoxFreight.Size = new System.Drawing.Size(238, 22);
            this.textBoxFreight.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "Сумма фрахта";
            // 
            // comboBoxInsurance
            // 
            this.comboBoxInsurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInsurance.FormattingEnabled = true;
            this.comboBoxInsurance.Location = new System.Drawing.Point(223, 237);
            this.comboBoxInsurance.Name = "comboBoxInsurance";
            this.comboBoxInsurance.Size = new System.Drawing.Size(238, 24);
            this.comboBoxInsurance.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 92;
            this.label7.Text = "Страхование груза";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 37);
            this.button1.TabIndex = 97;
            this.button1.Text = "Оформить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxInsurance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFreight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateDelivery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxApplicationNum);
            this.Controls.Add(this.dateSign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxContracts);
            this.Controls.Add(this.label2);
            this.Name = "FormAddApplication";
            this.Text = "Составление заявки на перевозку груза";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxApplicationNum;
        private System.Windows.Forms.DateTimePicker dateSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBoxContracts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDelivery;
        private System.Windows.Forms.TextBox textBoxFreight;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox comboBoxInsurance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}