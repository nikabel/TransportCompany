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
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxApplicationNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRouteNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAddRoute = new System.Windows.Forms.Button();
            this.textBoxDepartureNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDepartureAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateDeparture = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxArrivalNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateArrival = new System.Windows.Forms.DateTimePicker();
            this.textBoxArrivalAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(256, 204);
            this.textBoxDistance.MaxLength = 12;
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(238, 22);
            this.textBoxDistance.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "Общее расстояние";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(256, 159);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(238, 24);
            this.comboBoxEmployee.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "ФИО сотрудника";
            // 
            // comboBoxApplicationNum
            // 
            this.comboBoxApplicationNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApplicationNum.FormattingEnabled = true;
            this.comboBoxApplicationNum.Location = new System.Drawing.Point(256, 113);
            this.comboBoxApplicationNum.Name = "comboBoxApplicationNum";
            this.comboBoxApplicationNum.Size = new System.Drawing.Size(238, 24);
            this.comboBoxApplicationNum.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Номер заявки";
            // 
            // textBoxRouteNum
            // 
            this.textBoxRouteNum.Location = new System.Drawing.Point(256, 70);
            this.textBoxRouteNum.MaxLength = 32;
            this.textBoxRouteNum.Name = "textBoxRouteNum";
            this.textBoxRouteNum.Size = new System.Drawing.Size(238, 22);
            this.textBoxRouteNum.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 63;
            this.label8.Text = "Номер маршрута";
            // 
            // buttonAddRoute
            // 
            this.buttonAddRoute.Location = new System.Drawing.Point(160, 269);
            this.buttonAddRoute.Name = "buttonAddRoute";
            this.buttonAddRoute.Size = new System.Drawing.Size(164, 38);
            this.buttonAddRoute.TabIndex = 60;
            this.buttonAddRoute.Text = "Создать маршрут";
            this.buttonAddRoute.UseVisualStyleBackColor = true;
            this.buttonAddRoute.Click += new System.EventHandler(this.buttonAddStop_Click);
            // 
            // textBoxDepartureNum
            // 
            this.textBoxDepartureNum.Location = new System.Drawing.Point(148, 36);
            this.textBoxDepartureNum.MaxLength = 32;
            this.textBoxDepartureNum.Name = "textBoxDepartureNum";
            this.textBoxDepartureNum.Size = new System.Drawing.Size(238, 22);
            this.textBoxDepartureNum.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 98;
            this.label1.Text = "Номер остановки";
            // 
            // textBoxDepartureAddress
            // 
            this.textBoxDepartureAddress.Location = new System.Drawing.Point(148, 75);
            this.textBoxDepartureAddress.MaxLength = 150;
            this.textBoxDepartureAddress.Multiline = true;
            this.textBoxDepartureAddress.Name = "textBoxDepartureAddress";
            this.textBoxDepartureAddress.Size = new System.Drawing.Size(238, 54);
            this.textBoxDepartureAddress.TabIndex = 94;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 96;
            this.label9.Text = "Дата отправления";
            // 
            // dateDeparture
            // 
            this.dateDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDeparture.Location = new System.Drawing.Point(148, 142);
            this.dateDeparture.Name = "dateDeparture";
            this.dateDeparture.Size = new System.Drawing.Size(238, 22);
            this.dateDeparture.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 95;
            this.label7.Text = "Адрес отправления";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDepartureNum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateDeparture);
            this.groupBox1.Controls.Add(this.textBoxDepartureAddress);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(526, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 175);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация об отправлении";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxArrivalNum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateArrival);
            this.groupBox2.Controls.Add(this.textBoxArrivalAddress);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(526, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 175);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о прибытии";
            // 
            // textBoxArrivalNum
            // 
            this.textBoxArrivalNum.Location = new System.Drawing.Point(148, 36);
            this.textBoxArrivalNum.MaxLength = 32;
            this.textBoxArrivalNum.Name = "textBoxArrivalNum";
            this.textBoxArrivalNum.Size = new System.Drawing.Size(238, 22);
            this.textBoxArrivalNum.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 95;
            this.label5.Text = "Адрес прибытия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 98;
            this.label6.Text = "Номер остановки";
            // 
            // dateArrival
            // 
            this.dateArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateArrival.Location = new System.Drawing.Point(148, 142);
            this.dateArrival.Name = "dateArrival";
            this.dateArrival.Size = new System.Drawing.Size(238, 22);
            this.dateArrival.TabIndex = 97;
            // 
            // textBoxArrivalAddress
            // 
            this.textBoxArrivalAddress.Location = new System.Drawing.Point(148, 75);
            this.textBoxArrivalAddress.MaxLength = 150;
            this.textBoxArrivalAddress.Multiline = true;
            this.textBoxArrivalAddress.Name = "textBoxArrivalAddress";
            this.textBoxArrivalAddress.Size = new System.Drawing.Size(238, 54);
            this.textBoxArrivalAddress.TabIndex = 94;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 96;
            this.label10.Text = "Дата прибытия";
            // 
            // FormRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAddRoute);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.textBoxRouteNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxApplicationNum);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.label3);
            this.Name = "FormRoute";
            this.Text = "Формирование маршрута";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddRoute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRouteNum;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBoxApplicationNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDepartureNum;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxDepartureAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateDeparture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxArrivalNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateArrival;
        public System.Windows.Forms.TextBox textBoxArrivalAddress;
        private System.Windows.Forms.Label label10;
    }
}