namespace TransportCompany.forms
{
    partial class FormChooseEmployee
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
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.dateService = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxService = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.labelContractNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxName
            // 
            this.comboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(235, 53);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(238, 24);
            this.comboBoxName.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "ФИО сотрудника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Предоставляемая услуга";
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(202, 253);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(105, 33);
            this.buttonChoose.TabIndex = 60;
            this.buttonChoose.Text = "Назначить";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // dateService
            // 
            this.dateService.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateService.Location = new System.Drawing.Point(235, 203);
            this.dateService.Name = "dateService";
            this.dateService.Size = new System.Drawing.Size(238, 22);
            this.dateService.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Дата оказания";
            // 
            // textBoxService
            // 
            this.textBoxService.Location = new System.Drawing.Point(235, 105);
            this.textBoxService.MaxLength = 50;
            this.textBoxService.Name = "textBoxService";
            this.textBoxService.Size = new System.Drawing.Size(238, 22);
            this.textBoxService.TabIndex = 63;
            this.textBoxService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxService_KeyPress);
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(235, 153);
            this.textBoxCost.MaxLength = 10;
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(238, 22);
            this.textBoxCost.TabIndex = 65;
            this.textBoxCost.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCost_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Стоимость услуги";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Location = new System.Drawing.Point(526, 53);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersWidth = 51;
            this.dataGridViewServices.RowTemplate.Height = 24;
            this.dataGridViewServices.Size = new System.Drawing.Size(696, 254);
            this.dataGridViewServices.TabIndex = 66;
            // 
            // labelContractNum
            // 
            this.labelContractNum.AutoSize = true;
            this.labelContractNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContractNum.Location = new System.Drawing.Point(1117, 25);
            this.labelContractNum.Name = "labelContractNum";
            this.labelContractNum.Size = new System.Drawing.Size(0, 25);
            this.labelContractNum.TabIndex = 98;
            this.labelContractNum.Click += new System.EventHandler(this.labelContractNum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(521, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 25);
            this.label2.TabIndex = 97;
            this.label2.Text = "Список сотрудников для работы над договором №";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormChooseEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 335);
            this.Controls.Add(this.labelContractNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewServices);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxService);
            this.Controls.Add(this.dateService);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.label1);
            this.Name = "FormChooseEmployee";
            this.Text = "Назначение сотрудников для работы над заказом";
            this.Load += new System.EventHandler(this.FormChooseEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.DateTimePicker dateService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxService;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Label labelContractNum;
        private System.Windows.Forms.Label label2;
    }
}