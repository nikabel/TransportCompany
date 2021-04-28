namespace TransportCompany.forms
{
    partial class FormAddStop
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
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.textBoxStopAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddStop = new System.Windows.Forms.Button();
            this.dateTimePickerStop = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxStopNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelContractNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Location = new System.Drawing.Point(234, 173);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(238, 24);
            this.comboBoxOperation.TabIndex = 91;
            // 
            // textBoxStopAddress
            // 
            this.textBoxStopAddress.Location = new System.Drawing.Point(234, 63);
            this.textBoxStopAddress.Multiline = true;
            this.textBoxStopAddress.Name = "textBoxStopAddress";
            this.textBoxStopAddress.Size = new System.Drawing.Size(238, 54);
            this.textBoxStopAddress.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 86;
            this.label9.Text = "Дата остановки";
            // 
            // buttonAddStop
            // 
            this.buttonAddStop.Location = new System.Drawing.Point(190, 223);
            this.buttonAddStop.Name = "buttonAddStop";
            this.buttonAddStop.Size = new System.Drawing.Size(102, 33);
            this.buttonAddStop.TabIndex = 84;
            this.buttonAddStop.Text = "Добавить";
            this.buttonAddStop.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerStop
            // 
            this.dateTimePickerStop.Location = new System.Drawing.Point(234, 130);
            this.dateTimePickerStop.Name = "dateTimePickerStop";
            this.dateTimePickerStop.Size = new System.Drawing.Size(238, 22);
            this.dateTimePickerStop.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 85;
            this.label7.Text = "Адрес";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 17);
            this.label10.TabIndex = 89;
            this.label10.Text = "Наименование операции";
            // 
            // textBoxStopNum
            // 
            this.textBoxStopNum.Location = new System.Drawing.Point(234, 24);
            this.textBoxStopNum.Name = "textBoxStopNum";
            this.textBoxStopNum.Size = new System.Drawing.Size(238, 22);
            this.textBoxStopNum.TabIndex = 93;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 92;
            this.label8.Text = "Номер остановки";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(496, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(687, 313);
            this.dataGridView1.TabIndex = 94;
            // 
            // labelContractNum
            // 
            this.labelContractNum.AutoSize = true;
            this.labelContractNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContractNum.Location = new System.Drawing.Point(846, 20);
            this.labelContractNum.Name = "labelContractNum";
            this.labelContractNum.Size = new System.Drawing.Size(0, 25);
            this.labelContractNum.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(491, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 25);
            this.label1.TabIndex = 95;
            this.label1.Text = "Список остановок в маршруте №";
            // 
            // FormAddStop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 376);
            this.Controls.Add(this.labelContractNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxStopNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.textBoxStopAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonAddStop);
            this.Controls.Add(this.dateTimePickerStop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Name = "FormAddStop";
            this.Text = "Добавление остановки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxOperation;
        public System.Windows.Forms.TextBox textBoxStopAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddStop;
        private System.Windows.Forms.DateTimePicker dateTimePickerStop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStopNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelContractNum;
        private System.Windows.Forms.Label label1;
    }
}