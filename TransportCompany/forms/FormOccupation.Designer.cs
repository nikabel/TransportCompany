namespace TransportCompany.forms
{
    partial class FormOccupation
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOccTrans = new System.Windows.Forms.DataGridView();
            this.dataGridViewFreeTrans = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewOccDriver = new System.Windows.Forms.DataGridView();
            this.dataGridViewFreeDriver = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOccTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeTrans)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOccDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewOccTrans);
            this.tabPage1.Controls.Add(this.dataGridViewFreeTrans);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сведения о задействованом транспорте";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сведения о свободном транспорте";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewOccTrans
            // 
            this.dataGridViewOccTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOccTrans.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOccTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOccTrans.Location = new System.Drawing.Point(8, 271);
            this.dataGridViewOccTrans.Name = "dataGridViewOccTrans";
            this.dataGridViewOccTrans.RowHeadersVisible = false;
            this.dataGridViewOccTrans.RowHeadersWidth = 51;
            this.dataGridViewOccTrans.RowTemplate.Height = 24;
            this.dataGridViewOccTrans.Size = new System.Drawing.Size(776, 194);
            this.dataGridViewOccTrans.TabIndex = 1;
            // 
            // dataGridViewFreeTrans
            // 
            this.dataGridViewFreeTrans.AllowUserToAddRows = false;
            this.dataGridViewFreeTrans.AllowUserToDeleteRows = false;
            this.dataGridViewFreeTrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFreeTrans.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFreeTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFreeTrans.Location = new System.Drawing.Point(8, 43);
            this.dataGridViewFreeTrans.Name = "dataGridViewFreeTrans";
            this.dataGridViewFreeTrans.RowHeadersVisible = false;
            this.dataGridViewFreeTrans.RowHeadersWidth = 51;
            this.dataGridViewFreeTrans.RowTemplate.Height = 24;
            this.dataGridViewFreeTrans.Size = new System.Drawing.Size(776, 184);
            this.dataGridViewFreeTrans.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridViewOccDriver);
            this.tabPage2.Controls.Add(this.dataGridViewFreeDriver);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сведения о задействованных водителях";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сведения о свободных водителях";
            // 
            // dataGridViewOccDriver
            // 
            this.dataGridViewOccDriver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOccDriver.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOccDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOccDriver.Location = new System.Drawing.Point(9, 270);
            this.dataGridViewOccDriver.Name = "dataGridViewOccDriver";
            this.dataGridViewOccDriver.RowHeadersVisible = false;
            this.dataGridViewOccDriver.RowHeadersWidth = 51;
            this.dataGridViewOccDriver.RowTemplate.Height = 24;
            this.dataGridViewOccDriver.Size = new System.Drawing.Size(776, 195);
            this.dataGridViewOccDriver.TabIndex = 1;
            // 
            // dataGridViewFreeDriver
            // 
            this.dataGridViewFreeDriver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFreeDriver.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFreeDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFreeDriver.Location = new System.Drawing.Point(8, 46);
            this.dataGridViewFreeDriver.Name = "dataGridViewFreeDriver";
            this.dataGridViewFreeDriver.RowHeadersVisible = false;
            this.dataGridViewFreeDriver.RowHeadersWidth = 51;
            this.dataGridViewFreeDriver.RowTemplate.Height = 24;
            this.dataGridViewFreeDriver.Size = new System.Drawing.Size(776, 181);
            this.dataGridViewFreeDriver.TabIndex = 0;
            // 
            // FormOccupation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormOccupation";
            this.Text = "Сведения о занятости транспорта и водителей";
            this.Load += new System.EventHandler(this.FormOccupation_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOccTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeTrans)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOccDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFreeDriver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewFreeTrans;
        private System.Windows.Forms.DataGridView dataGridViewOccTrans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewOccDriver;
        private System.Windows.Forms.DataGridView dataGridViewFreeDriver;
    }
}