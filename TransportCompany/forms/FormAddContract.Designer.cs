namespace TransportCompany.forms
{
    partial class FormAddContract
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
            this.textBoxContractNum = new System.Windows.Forms.TextBox();
            this.dateSign = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateExpierience = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxContractNum
            // 
            this.textBoxContractNum.Location = new System.Drawing.Point(222, 24);
            this.textBoxContractNum.Name = "textBoxContractNum";
            this.textBoxContractNum.Size = new System.Drawing.Size(238, 22);
            this.textBoxContractNum.TabIndex = 85;
            // 
            // dateSign
            // 
            this.dateSign.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSign.Location = new System.Drawing.Point(222, 111);
            this.dateSign.Name = "dateSign";
            this.dateSign.Size = new System.Drawing.Size(238, 22);
            this.dateSign.TabIndex = 84;
            this.dateSign.ValueChanged += new System.EventHandler(this.dateSign_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "Дата подписания";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(170, 206);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 35);
            this.buttonAdd.TabIndex = 82;
            this.buttonAdd.Text = "Оформить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "Заказчик";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(222, 66);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(238, 24);
            this.comboBoxCustomer.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "Номер договора";
            // 
            // dateExpierience
            // 
            this.dateExpierience.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateExpierience.Location = new System.Drawing.Point(222, 154);
            this.dateExpierience.Name = "dateExpierience";
            this.dateExpierience.Size = new System.Drawing.Size(238, 22);
            this.dateExpierience.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "Дата истечения";
            // 
            // FormAddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 271);
            this.Controls.Add(this.dateExpierience);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxContractNum);
            this.Controls.Add(this.dateSign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.label2);
            this.Name = "FormAddContract";
            this.Text = "Формирование договора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxContractNum;
        private System.Windows.Forms.DateTimePicker dateSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateExpierience;
        private System.Windows.Forms.Label label1;
    }
}