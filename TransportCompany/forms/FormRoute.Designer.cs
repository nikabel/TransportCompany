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
            this.label6 = new System.Windows.Forms.Label();
            this.dateArrival = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.dateDeparture = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxApplicationNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRouteNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAddRoute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 91;
            this.label6.Text = "Дата прибытия";
            // 
            // dateArrival
            // 
            this.dateArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateArrival.Location = new System.Drawing.Point(235, 248);
            this.dateArrival.Name = "dateArrival";
            this.dateArrival.Size = new System.Drawing.Size(238, 22);
            this.dateArrival.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 83;
            this.label5.Text = "Дата отправления";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(235, 162);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(238, 22);
            this.textBoxDistance.TabIndex = 90;
            // 
            // dateDeparture
            // 
            this.dateDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDeparture.Location = new System.Drawing.Point(235, 206);
            this.dateDeparture.Name = "dateDeparture";
            this.dateDeparture.Size = new System.Drawing.Size(238, 22);
            this.dateDeparture.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "Общее расстояние";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(235, 117);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(238, 24);
            this.comboBoxEmployee.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "ФИО сотрудника";
            // 
            // comboBoxApplicationNum
            // 
            this.comboBoxApplicationNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApplicationNum.FormattingEnabled = true;
            this.comboBoxApplicationNum.Location = new System.Drawing.Point(235, 71);
            this.comboBoxApplicationNum.Name = "comboBoxApplicationNum";
            this.comboBoxApplicationNum.Size = new System.Drawing.Size(238, 24);
            this.comboBoxApplicationNum.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Номер заявки";
            // 
            // textBoxRouteNum
            // 
            this.textBoxRouteNum.Location = new System.Drawing.Point(235, 28);
            this.textBoxRouteNum.Name = "textBoxRouteNum";
            this.textBoxRouteNum.Size = new System.Drawing.Size(238, 22);
            this.textBoxRouteNum.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 63;
            this.label8.Text = "Номер маршрута";
            // 
            // buttonAddRoute
            // 
            this.buttonAddRoute.Location = new System.Drawing.Point(167, 294);
            this.buttonAddRoute.Name = "buttonAddRoute";
            this.buttonAddRoute.Size = new System.Drawing.Size(164, 38);
            this.buttonAddRoute.TabIndex = 60;
            this.buttonAddRoute.Text = "Создать маршрут";
            this.buttonAddRoute.UseVisualStyleBackColor = true;
            this.buttonAddRoute.Click += new System.EventHandler(this.buttonAddStop_Click);
            // 
            // FormRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 354);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateArrival);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAddRoute);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.textBoxRouteNum);
            this.Controls.Add(this.dateDeparture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxApplicationNum);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.label3);
            this.Name = "FormRoute";
            this.Text = "Формирование маршрута";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddRoute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRouteNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateArrival;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.DateTimePicker dateDeparture;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBoxApplicationNum;
        private System.Windows.Forms.Label label2;
    }
}