namespace TransportCompany.forms
{
    partial class FormControlOrder
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
            this.buttonChangeStop = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateStop = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewStops = new System.Windows.Forms.DataGridView();
            this.labelRouteId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStops)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangeStop
            // 
            this.buttonChangeStop.Location = new System.Drawing.Point(930, 156);
            this.buttonChangeStop.Name = "buttonChangeStop";
            this.buttonChangeStop.Size = new System.Drawing.Size(112, 39);
            this.buttonChangeStop.TabIndex = 68;
            this.buttonChangeStop.Text = "Изменить";
            this.buttonChangeStop.UseVisualStyleBackColor = true;
            this.buttonChangeStop.Click += new System.EventHandler(this.buttonAddStop_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(807, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 17);
            this.label9.TabIndex = 71;
            this.label9.Text = "Фактическая дата остановки";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dateStop
            // 
            this.dateStop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStop.Location = new System.Drawing.Point(1027, 108);
            this.dateStop.Name = "dateStop";
            this.dateStop.Size = new System.Drawing.Size(120, 22);
            this.dateStop.TabIndex = 73;
            // 
            // dataGridViewStops
            // 
            this.dataGridViewStops.AllowUserToAddRows = false;
            this.dataGridViewStops.AllowUserToDeleteRows = false;
            this.dataGridViewStops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStops.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewStops.Name = "dataGridViewStops";
            this.dataGridViewStops.RowHeadersVisible = false;
            this.dataGridViewStops.RowHeadersWidth = 51;
            this.dataGridViewStops.RowTemplate.Height = 24;
            this.dataGridViewStops.Size = new System.Drawing.Size(775, 214);
            this.dataGridViewStops.TabIndex = 79;
            // 
            // labelRouteId
            // 
            this.labelRouteId.AutoSize = true;
            this.labelRouteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRouteId.Location = new System.Drawing.Point(394, 29);
            this.labelRouteId.Name = "labelRouteId";
            this.labelRouteId.Size = new System.Drawing.Size(0, 25);
            this.labelRouteId.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "Список остановок в маршруте №";
            // 
            // FormControlOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 286);
            this.Controls.Add(this.labelRouteId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewStops);
            this.Controls.Add(this.buttonChangeStop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateStop);
            this.Name = "FormControlOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контроль за ходом выполнения заказа";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeStop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateStop;
        private System.Windows.Forms.DataGridView dataGridViewStops;
        private System.Windows.Forms.Label labelRouteId;
        private System.Windows.Forms.Label label1;
    }
}