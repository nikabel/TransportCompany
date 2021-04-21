namespace TransportCompany.forms
{
    partial class FormRoute
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxStop = new System.Windows.Forms.GroupBox();
            this.buttonAddStop = new System.Windows.Forms.Button();
            this.comboBoxStopType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxStopAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerStop = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxStop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(542, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(687, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxStop
            // 
            this.groupBoxStop.Controls.Add(this.buttonAddStop);
            this.groupBoxStop.Controls.Add(this.comboBoxStopType);
            this.groupBoxStop.Controls.Add(this.label10);
            this.groupBoxStop.Controls.Add(this.comboBox2);
            this.groupBoxStop.Controls.Add(this.textBoxStopAddress);
            this.groupBoxStop.Controls.Add(this.label9);
            this.groupBoxStop.Controls.Add(this.dateTimePickerStop);
            this.groupBoxStop.Controls.Add(this.label8);
            this.groupBoxStop.Controls.Add(this.label7);
            this.groupBoxStop.Location = new System.Drawing.Point(12, 11);
            this.groupBoxStop.Name = "groupBoxStop";
            this.groupBoxStop.Size = new System.Drawing.Size(506, 314);
            this.groupBoxStop.TabIndex = 3;
            this.groupBoxStop.TabStop = false;
            this.groupBoxStop.Text = "Добавить остановку";
            // 
            // buttonAddStop
            // 
            this.buttonAddStop.Location = new System.Drawing.Point(183, 230);
            this.buttonAddStop.Name = "buttonAddStop";
            this.buttonAddStop.Size = new System.Drawing.Size(89, 33);
            this.buttonAddStop.TabIndex = 60;
            this.buttonAddStop.Text = "Добавить";
            this.buttonAddStop.UseVisualStyleBackColor = true;
            // 
            // comboBoxStopType
            // 
            this.comboBoxStopType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopType.FormattingEnabled = true;
            this.comboBoxStopType.Location = new System.Drawing.Point(238, 185);
            this.comboBoxStopType.Name = "comboBoxStopType";
            this.comboBoxStopType.Size = new System.Drawing.Size(238, 24);
            this.comboBoxStopType.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 17);
            this.label10.TabIndex = 66;
            this.label10.Text = "Наименование операции";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(238, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(238, 24);
            this.comboBox2.TabIndex = 65;
            // 
            // textBoxStopAddress
            // 
            this.textBoxStopAddress.Location = new System.Drawing.Point(238, 76);
            this.textBoxStopAddress.Multiline = true;
            this.textBoxStopAddress.Name = "textBoxStopAddress";
            this.textBoxStopAddress.Size = new System.Drawing.Size(238, 54);
            this.textBoxStopAddress.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 62;
            this.label9.Text = "Дата остановки";
            // 
            // dateTimePickerStop
            // 
            this.dateTimePickerStop.Location = new System.Drawing.Point(238, 143);
            this.dateTimePickerStop.Name = "dateTimePickerStop";
            this.dateTimePickerStop.Size = new System.Drawing.Size(238, 22);
            this.dateTimePickerStop.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 63;
            this.label8.Text = "Номер маршрута";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "Адрес";
            // 
            // FormRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 361);
            this.Controls.Add(this.groupBoxStop);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRoute";
            this.Text = "Формирование маршрута";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxStop.ResumeLayout(false);
            this.groupBoxStop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxStop;
        private System.Windows.Forms.Button buttonAddStop;
        public System.Windows.Forms.ComboBox comboBoxStopType;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.TextBox textBoxStopAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerStop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}