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
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBiAdr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
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
            this.textBoxAdr.Location = new System.Drawing.Point(274, 142);
            this.textBoxAdr.Multiline = true;
            this.textBoxAdr.Name = "textBoxAdr";
            this.textBoxAdr.Size = new System.Drawing.Size(238, 54);
            this.textBoxAdr.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 91;
            this.label7.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(274, 59);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(238, 22);
            this.textBoxEmail.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 88;
            this.label6.Text = "Юридический адрес";
            // 
            // textBoxBiAdr
            // 
            this.textBoxBiAdr.Location = new System.Drawing.Point(274, 217);
            this.textBoxBiAdr.Multiline = true;
            this.textBoxBiAdr.Name = "textBoxBiAdr";
            this.textBoxBiAdr.Size = new System.Drawing.Size(238, 54);
            this.textBoxBiAdr.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "Номер телефона";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(274, 100);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(238, 22);
            this.textBoxTel.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 83;
            this.label5.Text = "ФИО";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(274, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(238, 22);
            this.textBoxName.TabIndex = 82;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(196, 304);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(111, 39);
            this.buttonChange.TabIndex = 81;
            this.buttonChange.Text = "Сохранить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // FormChangeIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxBiAdr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonChange);
            this.Name = "FormChangeIndividual";
            this.Text = "Информация о заказчиках";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxAdr;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxBiAdr;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonChange;
    }
}