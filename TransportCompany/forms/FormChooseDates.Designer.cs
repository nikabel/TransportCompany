namespace TransportCompany.forms
{
    partial class FormChooseDates
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
            this.label9 = new System.Windows.Forms.Label();
            this.dateFirst = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateSecond = new System.Windows.Forms.DateTimePicker();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(54, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(455, 29);
            this.label9.TabIndex = 89;
            this.label9.Text = "Выберите период завершения заказа";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dateFirst
            // 
            this.dateFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFirst.Location = new System.Drawing.Point(91, 96);
            this.dateFirst.Name = "dateFirst";
            this.dateFirst.Size = new System.Drawing.Size(137, 22);
            this.dateFirst.TabIndex = 90;
            this.dateFirst.Value = new System.DateTime(2021, 5, 30, 13, 6, 30, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 29);
            this.label1.TabIndex = 91;
            this.label1.Text = "с";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(273, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 92;
            this.label2.Text = "по";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateSecond
            // 
            this.dateSecond.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSecond.Location = new System.Drawing.Point(372, 98);
            this.dateSecond.Name = "dateSecond";
            this.dateSecond.Size = new System.Drawing.Size(137, 22);
            this.dateSecond.TabIndex = 93;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(155, 161);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(247, 45);
            this.buttonPrint.TabIndex = 94;
            this.buttonPrint.Text = "Печать сведений о завершенных заказах";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // FormChooseDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 241);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dateSecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateFirst);
            this.Name = "FormChooseDates";
            this.Text = "Сведения о завершенных заказах";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateSecond;
        private System.Windows.Forms.Button buttonPrint;
    }
}