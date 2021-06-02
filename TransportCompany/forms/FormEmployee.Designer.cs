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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfficeEmployee)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOfficeEmployee
            // 
            this.dataGridViewOfficeEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOfficeEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOfficeEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfficeEmployee.Location = new System.Drawing.Point(6, 409);
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
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(720, 62);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(123, 32);
            this.buttonDeleteEmployee.TabIndex = 19;
            this.buttonDeleteEmployee.Text = "Удалить";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteStopType_Click);
            // 
            // buttonChangeEmployee
            // 
            this.buttonChangeEmployee.Location = new System.Drawing.Point(225, 630);
            this.buttonChangeEmployee.Name = "buttonChangeEmployee";
            this.buttonChangeEmployee.Size = new System.Drawing.Size(123, 32);
            this.buttonChangeEmployee.TabIndex = 20;
            this.buttonChangeEmployee.Text = "Изменить";
            this.buttonChangeEmployee.UseVisualStyleBackColor = true;
            this.buttonChangeEmployee.Click += new System.EventHandler(this.buttonChangeStopType_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(35, 630);
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
            this.groupBox3.Location = new System.Drawing.Point(9, 29);
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
            this.dataGridViewDriver.Location = new System.Drawing.Point(446, 409);
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
            this.label1.Location = new System.Drawing.Point(8, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Офисные сотрудники";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Водители";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
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
            this.dataGridViewEmployee.Location = new System.Drawing.Point(6, 154);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersVisible = false;
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(953, 205);
            this.dataGridViewEmployee.TabIndex = 28;
            // 
            // buttonAddDriver
            // 
            this.buttonAddDriver.Location = new System.Drawing.Point(543, 630);
            this.buttonAddDriver.Name = "buttonAddDriver";
            this.buttonAddDriver.Size = new System.Drawing.Size(124, 32);
            this.buttonAddDriver.TabIndex = 29;
            this.buttonAddDriver.Text = "Добавить";
            this.buttonAddDriver.UseVisualStyleBackColor = true;
            this.buttonAddDriver.Click += new System.EventHandler(this.buttonAddDriver_Click);
            // 
            // buttonChangeDriver
            // 
            this.buttonChangeDriver.Location = new System.Drawing.Point(711, 630);
            this.buttonChangeDriver.Name = "buttonChangeDriver";
            this.buttonChangeDriver.Size = new System.Drawing.Size(123, 32);
            this.buttonChangeDriver.TabIndex = 30;
            this.buttonChangeDriver.Text = "Изменить";
            this.buttonChangeDriver.UseVisualStyleBackColor = true;
            this.buttonChangeDriver.Click += new System.EventHandler(this.buttonChangeDriver_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(979, 710);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonDeleteEmployee);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.dataGridViewEmployee);
            this.tabPage1.Controls.Add(this.buttonChangeDriver);
            this.tabPage1.Controls.Add(this.buttonAddEmployee);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonAddDriver);
            this.tabPage1.Controls.Add(this.dataGridViewDriver);
            this.tabPage1.Controls.Add(this.buttonChangeEmployee);
            this.tabPage1.Controls.Add(this.dataGridViewOfficeEmployee);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(971, 681);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDeleteUser);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridViewUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(971, 681);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(8, 307);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(957, 366);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Пользователи";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddUser);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxEmployees);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxLogin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(39, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить пользователя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ФИО сотрудника";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(202, 88);
            this.textBoxLogin.MaxLength = 20;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(244, 22);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(202, 138);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(244, 22);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Location = new System.Drawing.Point(202, 43);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(244, 24);
            this.comboBoxEmployees.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Логин";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Пароль";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(490, 83);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(115, 32);
            this.buttonAddUser.TabIndex = 6;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(773, 131);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(115, 32);
            this.buttonDeleteUser.TabIndex = 7;
            this.buttonDeleteUser.Text = "Удалить";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 710);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о сотрудниках";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfficeEmployee)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEmployees;
    }
}