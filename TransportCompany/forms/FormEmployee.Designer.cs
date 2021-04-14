namespace TransportCompany.forms
{
    partial class FormEmployee
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
            this.dataGridViewOfficeEmployee = new System.Windows.Forms.DataGridView();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonChangeEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearchEmployee = new System.Windows.Forms.TextBox();
            this.buttonSearchEmployee = new System.Windows.Forms.Button();
            this.dataGridViewDriver = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.buttonAddDriver = new System.Windows.Forms.Button();
            this.buttonChangeDriver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfficeEmployee)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOfficeEmployee
            // 
            this.dataGridViewOfficeEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOfficeEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOfficeEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfficeEmployee.Location = new System.Drawing.Point(12, 401);
            this.dataGridViewOfficeEmployee.Name = "dataGridViewOfficeEmployee";
            this.dataGridViewOfficeEmployee.RowHeadersVisible = false;
            this.dataGridViewOfficeEmployee.RowHeadersWidth = 51;
            this.dataGridViewOfficeEmployee.RowTemplate.Height = 24;
            this.dataGridViewOfficeEmployee.Size = new System.Drawing.Size(410, 205);
            this.dataGridViewOfficeEmployee.TabIndex = 23;
            this.dataGridViewOfficeEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStopType_CellContentClick);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(697, 54);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(123, 32);
            this.buttonDeleteEmployee.TabIndex = 19;
            this.buttonDeleteEmployee.Text = "Удалить";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteStopType_Click);
            // 
            // buttonChangeEmployee
            // 
            this.buttonChangeEmployee.Location = new System.Drawing.Point(224, 629);
            this.buttonChangeEmployee.Name = "buttonChangeEmployee";
            this.buttonChangeEmployee.Size = new System.Drawing.Size(123, 32);
            this.buttonChangeEmployee.TabIndex = 20;
            this.buttonChangeEmployee.Text = "Изменить";
            this.buttonChangeEmployee.UseVisualStyleBackColor = true;
            this.buttonChangeEmployee.Click += new System.EventHandler(this.buttonChangeStopType_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(35, 629);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(124, 32);
            this.buttonAddEmployee.TabIndex = 21;
            this.buttonAddEmployee.Text = "Добавить";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddStopType_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelSearch);
            this.groupBox3.Controls.Add(this.textBoxSearchEmployee);
            this.groupBox3.Controls.Add(this.buttonSearchEmployee);
            this.groupBox3.Location = new System.Drawing.Point(26, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 90);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск информации о сотрудниках";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(6, 40);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(115, 17);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Имя сотрудника";
            // 
            // textBoxSearchEmployee
            // 
            this.textBoxSearchEmployee.Location = new System.Drawing.Point(138, 37);
            this.textBoxSearchEmployee.Name = "textBoxSearchEmployee";
            this.textBoxSearchEmployee.Size = new System.Drawing.Size(274, 22);
            this.textBoxSearchEmployee.TabIndex = 1;
            // 
            // buttonSearchEmployee
            // 
            this.buttonSearchEmployee.Location = new System.Drawing.Point(442, 32);
            this.buttonSearchEmployee.Name = "buttonSearchEmployee";
            this.buttonSearchEmployee.Size = new System.Drawing.Size(106, 33);
            this.buttonSearchEmployee.TabIndex = 0;
            this.buttonSearchEmployee.Text = "Найти";
            this.buttonSearchEmployee.UseVisualStyleBackColor = true;
            this.buttonSearchEmployee.Click += new System.EventHandler(this.buttonSearchEmployee_Click);
            // 
            // dataGridViewDriver
            // 
            this.dataGridViewDriver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDriver.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDriver.Location = new System.Drawing.Point(450, 401);
            this.dataGridViewDriver.Name = "dataGridViewDriver";
            this.dataGridViewDriver.RowHeadersVisible = false;
            this.dataGridViewDriver.RowHeadersWidth = 51;
            this.dataGridViewDriver.RowTemplate.Height = 24;
            this.dataGridViewDriver.Size = new System.Drawing.Size(515, 205);
            this.dataGridViewDriver.TabIndex = 24;
            this.dataGridViewDriver.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDriver_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Офисные сотрудники";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Водители";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Сотрудники";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(12, 153);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersVisible = false;
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(953, 205);
            this.dataGridViewEmployee.TabIndex = 28;
            // 
            // buttonAddDriver
            // 
            this.buttonAddDriver.Location = new System.Drawing.Point(517, 629);
            this.buttonAddDriver.Name = "buttonAddDriver";
            this.buttonAddDriver.Size = new System.Drawing.Size(124, 32);
            this.buttonAddDriver.TabIndex = 29;
            this.buttonAddDriver.Text = "Добавить";
            this.buttonAddDriver.UseVisualStyleBackColor = true;
            this.buttonAddDriver.Click += new System.EventHandler(this.buttonAddDriver_Click);
            // 
            // buttonChangeDriver
            // 
            this.buttonChangeDriver.Location = new System.Drawing.Point(676, 629);
            this.buttonChangeDriver.Name = "buttonChangeDriver";
            this.buttonChangeDriver.Size = new System.Drawing.Size(123, 32);
            this.buttonChangeDriver.TabIndex = 30;
            this.buttonChangeDriver.Text = "Изменить";
            this.buttonChangeDriver.UseVisualStyleBackColor = true;
            this.buttonChangeDriver.Click += new System.EventHandler(this.buttonChangeDriver_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 674);
            this.Controls.Add(this.buttonChangeDriver);
            this.Controls.Add(this.buttonAddDriver);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDriver);
            this.Controls.Add(this.dataGridViewOfficeEmployee);
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.buttonChangeEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormEmployee";
            this.Text = "Информация о сотрудниках";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfficeEmployee)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOfficeEmployee;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        public System.Windows.Forms.Button buttonChangeEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearchEmployee;
        private System.Windows.Forms.Button buttonSearchEmployee;
        private System.Windows.Forms.DataGridView dataGridViewDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button buttonAddDriver;
        public System.Windows.Forms.Button buttonChangeDriver;
    }
}