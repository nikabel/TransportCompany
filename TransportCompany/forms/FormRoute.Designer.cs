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
            this.groupBoxLoading = new System.Windows.Forms.GroupBox();
            this.groupBoxDischarge = new System.Windows.Forms.GroupBox();
            this.groupBoxStop = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLoadAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerLoading = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRouteNum = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDischarge = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDischargeAddress = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxStopAddress = new System.Windows.Forms.TextBox();
            this.dateTimePickerStop = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxStopType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAddLoad = new System.Windows.Forms.Button();
            this.buttonAddDischarge = new System.Windows.Forms.Button();
            this.buttonAddStop = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxLoading.SuspendLayout();
            this.groupBoxDischarge.SuspendLayout();
            this.groupBoxStop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxLoading
            // 
            this.groupBoxLoading.Controls.Add(this.buttonAddLoad);
            this.groupBoxLoading.Controls.Add(this.comboBoxRouteNum);
            this.groupBoxLoading.Controls.Add(this.dateTimePickerLoading);
            this.groupBoxLoading.Controls.Add(this.label2);
            this.groupBoxLoading.Controls.Add(this.label1);
            this.groupBoxLoading.Controls.Add(this.label6);
            this.groupBoxLoading.Controls.Add(this.textBoxLoadAddress);
            this.groupBoxLoading.Location = new System.Drawing.Point(12, 13);
            this.groupBoxLoading.Name = "groupBoxLoading";
            this.groupBoxLoading.Size = new System.Drawing.Size(383, 261);
            this.groupBoxLoading.TabIndex = 1;
            this.groupBoxLoading.TabStop = false;
            this.groupBoxLoading.Text = "Добавить погрузку";
            // 
            // groupBoxDischarge
            // 
            this.groupBoxDischarge.Controls.Add(this.buttonAddDischarge);
            this.groupBoxDischarge.Controls.Add(this.comboBox1);
            this.groupBoxDischarge.Controls.Add(this.textBoxDischargeAddress);
            this.groupBoxDischarge.Controls.Add(this.dateTimePickerDischarge);
            this.groupBoxDischarge.Controls.Add(this.label5);
            this.groupBoxDischarge.Controls.Add(this.label3);
            this.groupBoxDischarge.Controls.Add(this.label4);
            this.groupBoxDischarge.Location = new System.Drawing.Point(424, 13);
            this.groupBoxDischarge.Name = "groupBoxDischarge";
            this.groupBoxDischarge.Size = new System.Drawing.Size(388, 263);
            this.groupBoxDischarge.TabIndex = 2;
            this.groupBoxDischarge.TabStop = false;
            this.groupBoxDischarge.Text = "Добавить разгрузку";
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
            this.groupBoxStop.Location = new System.Drawing.Point(837, 13);
            this.groupBoxStop.Name = "groupBoxStop";
            this.groupBoxStop.Size = new System.Drawing.Size(392, 263);
            this.groupBoxStop.TabIndex = 3;
            this.groupBoxStop.TabStop = false;
            this.groupBoxStop.Text = "Добавить остановку";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Адрес";
            // 
            // textBoxLoadAddress
            // 
            this.textBoxLoadAddress.Location = new System.Drawing.Point(133, 35);
            this.textBoxLoadAddress.Multiline = true;
            this.textBoxLoadAddress.Name = "textBoxLoadAddress";
            this.textBoxLoadAddress.Size = new System.Drawing.Size(238, 54);
            this.textBoxLoadAddress.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Дата погрузки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Номер маршрута";
            // 
            // dateTimePickerLoading
            // 
            this.dateTimePickerLoading.Location = new System.Drawing.Point(133, 117);
            this.dateTimePickerLoading.Name = "dateTimePickerLoading";
            this.dateTimePickerLoading.Size = new System.Drawing.Size(238, 22);
            this.dateTimePickerLoading.TabIndex = 52;
            // 
            // comboBoxRouteNum
            // 
            this.comboBoxRouteNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRouteNum.FormattingEnabled = true;
            this.comboBoxRouteNum.Location = new System.Drawing.Point(133, 165);
            this.comboBoxRouteNum.Name = "comboBoxRouteNum";
            this.comboBoxRouteNum.Size = new System.Drawing.Size(238, 24);
            this.comboBoxRouteNum.TabIndex = 53;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 24);
            this.comboBox1.TabIndex = 59;
            // 
            // dateTimePickerDischarge
            // 
            this.dateTimePickerDischarge.Location = new System.Drawing.Point(136, 117);
            this.dateTimePickerDischarge.Name = "dateTimePickerDischarge";
            this.dateTimePickerDischarge.Size = new System.Drawing.Size(238, 22);
            this.dateTimePickerDischarge.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Номер маршрута";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Дата разгрузки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Адрес";
            // 
            // textBoxDischargeAddress
            // 
            this.textBoxDischargeAddress.Location = new System.Drawing.Point(136, 35);
            this.textBoxDischargeAddress.Multiline = true;
            this.textBoxDischargeAddress.Name = "textBoxDischargeAddress";
            this.textBoxDischargeAddress.Size = new System.Drawing.Size(238, 54);
            this.textBoxDischargeAddress.TabIndex = 54;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(137, 182);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(238, 24);
            this.comboBox2.TabIndex = 65;
            // 
            // textBoxStopAddress
            // 
            this.textBoxStopAddress.Location = new System.Drawing.Point(137, 32);
            this.textBoxStopAddress.Multiline = true;
            this.textBoxStopAddress.Name = "textBoxStopAddress";
            this.textBoxStopAddress.Size = new System.Drawing.Size(238, 54);
            this.textBoxStopAddress.TabIndex = 60;
            // 
            // dateTimePickerStop
            // 
            this.dateTimePickerStop.Location = new System.Drawing.Point(137, 99);
            this.dateTimePickerStop.Name = "dateTimePickerStop";
            this.dateTimePickerStop.Size = new System.Drawing.Size(238, 22);
            this.dateTimePickerStop.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "Адрес";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 63;
            this.label8.Text = "Номер маршрута";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 62;
            this.label9.Text = "Дата остановки";
            // 
            // comboBoxStopType
            // 
            this.comboBoxStopType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopType.FormattingEnabled = true;
            this.comboBoxStopType.Location = new System.Drawing.Point(137, 141);
            this.comboBoxStopType.Name = "comboBoxStopType";
            this.comboBoxStopType.Size = new System.Drawing.Size(238, 24);
            this.comboBoxStopType.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 66;
            this.label10.Text = "Тип остановки";
            // 
            // buttonAddLoad
            // 
            this.buttonAddLoad.Location = new System.Drawing.Point(133, 214);
            this.buttonAddLoad.Name = "buttonAddLoad";
            this.buttonAddLoad.Size = new System.Drawing.Size(90, 33);
            this.buttonAddLoad.TabIndex = 54;
            this.buttonAddLoad.Text = "Добавить";
            this.buttonAddLoad.UseVisualStyleBackColor = true;
            // 
            // buttonAddDischarge
            // 
            this.buttonAddDischarge.Location = new System.Drawing.Point(146, 219);
            this.buttonAddDischarge.Name = "buttonAddDischarge";
            this.buttonAddDischarge.Size = new System.Drawing.Size(86, 33);
            this.buttonAddDischarge.TabIndex = 55;
            this.buttonAddDischarge.Text = "Добавить";
            this.buttonAddDischarge.UseVisualStyleBackColor = true;
            // 
            // buttonAddStop
            // 
            this.buttonAddStop.Location = new System.Drawing.Point(168, 224);
            this.buttonAddStop.Name = "buttonAddStop";
            this.buttonAddStop.Size = new System.Drawing.Size(84, 23);
            this.buttonAddStop.TabIndex = 60;
            this.buttonAddStop.Text = "Добавить";
            this.buttonAddStop.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(16, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 29);
            this.label11.TabIndex = 55;
            this.label11.Text = "Маршрут";
            // 
            // FormRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 645);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBoxStop);
            this.Controls.Add(this.groupBoxDischarge);
            this.Controls.Add(this.groupBoxLoading);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRoute";
            this.Text = "Формирование маршрута";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxLoading.ResumeLayout(false);
            this.groupBoxLoading.PerformLayout();
            this.groupBoxDischarge.ResumeLayout(false);
            this.groupBoxDischarge.PerformLayout();
            this.groupBoxStop.ResumeLayout(false);
            this.groupBoxStop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxLoading;
        private System.Windows.Forms.GroupBox groupBoxDischarge;
        private System.Windows.Forms.GroupBox groupBoxStop;
        private System.Windows.Forms.DateTimePicker dateTimePickerLoading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxLoadAddress;
        private System.Windows.Forms.Button buttonAddLoad;
        public System.Windows.Forms.ComboBox comboBoxRouteNum;
        private System.Windows.Forms.Button buttonAddDischarge;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox textBoxDischargeAddress;
        private System.Windows.Forms.DateTimePicker dateTimePickerDischarge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddStop;
        public System.Windows.Forms.ComboBox comboBoxStopType;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.TextBox textBoxStopAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerStop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
    }
}