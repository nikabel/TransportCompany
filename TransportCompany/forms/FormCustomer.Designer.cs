namespace TransportCompany.forms
{
    partial class FormCustomer
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
            this.buttonChangeEntity = new System.Windows.Forms.Button();
            this.buttonAddEntity = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEntityCustomer = new System.Windows.Forms.DataGridView();
            this.dataGridViewIndividualCustomer = new System.Windows.Forms.DataGridView();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.buttonChangeIndividual = new System.Windows.Forms.Button();
            this.buttonAddIndividual = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearchCustomer = new System.Windows.Forms.TextBox();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntityCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndividualCustomer)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChangeEntity
            // 
            this.buttonChangeEntity.Location = new System.Drawing.Point(676, 623);
            this.buttonChangeEntity.Name = "buttonChangeEntity";
            this.buttonChangeEntity.Size = new System.Drawing.Size(123, 32);
            this.buttonChangeEntity.TabIndex = 42;
            this.buttonChangeEntity.Text = "Изменить";
            this.buttonChangeEntity.UseVisualStyleBackColor = true;
            this.buttonChangeEntity.Click += new System.EventHandler(this.buttonChangeEntity_Click);
            // 
            // buttonAddEntity
            // 
            this.buttonAddEntity.Location = new System.Drawing.Point(517, 623);
            this.buttonAddEntity.Name = "buttonAddEntity";
            this.buttonAddEntity.Size = new System.Drawing.Size(124, 32);
            this.buttonAddEntity.TabIndex = 41;
            this.buttonAddEntity.Text = "Добавить";
            this.buttonAddEntity.UseVisualStyleBackColor = true;
            this.buttonAddEntity.Click += new System.EventHandler(this.buttonAddEntity_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(12, 147);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersVisible = false;
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(953, 205);
            this.dataGridViewCustomer.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Заказчики";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Юридические лица";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Физические лица";
            // 
            // dataGridViewEntityCustomer
            // 
            this.dataGridViewEntityCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewEntityCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEntityCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntityCustomer.Location = new System.Drawing.Point(393, 395);
            this.dataGridViewEntityCustomer.Name = "dataGridViewEntityCustomer";
            this.dataGridViewEntityCustomer.RowHeadersVisible = false;
            this.dataGridViewEntityCustomer.RowHeadersWidth = 51;
            this.dataGridViewEntityCustomer.RowTemplate.Height = 24;
            this.dataGridViewEntityCustomer.Size = new System.Drawing.Size(572, 205);
            this.dataGridViewEntityCustomer.TabIndex = 36;
            // 
            // dataGridViewIndividualCustomer
            // 
            this.dataGridViewIndividualCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewIndividualCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewIndividualCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIndividualCustomer.Location = new System.Drawing.Point(12, 395);
            this.dataGridViewIndividualCustomer.Name = "dataGridViewIndividualCustomer";
            this.dataGridViewIndividualCustomer.RowHeadersVisible = false;
            this.dataGridViewIndividualCustomer.RowHeadersWidth = 51;
            this.dataGridViewIndividualCustomer.RowTemplate.Height = 24;
            this.dataGridViewIndividualCustomer.Size = new System.Drawing.Size(360, 205);
            this.dataGridViewIndividualCustomer.TabIndex = 35;
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(697, 48);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(123, 32);
            this.buttonDeleteCustomer.TabIndex = 31;
            this.buttonDeleteCustomer.Text = "Удалить";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // buttonChangeIndividual
            // 
            this.buttonChangeIndividual.Location = new System.Drawing.Point(224, 623);
            this.buttonChangeIndividual.Name = "buttonChangeIndividual";
            this.buttonChangeIndividual.Size = new System.Drawing.Size(123, 32);
            this.buttonChangeIndividual.TabIndex = 32;
            this.buttonChangeIndividual.Text = "Изменить";
            this.buttonChangeIndividual.UseVisualStyleBackColor = true;
            this.buttonChangeIndividual.Click += new System.EventHandler(this.buttonChangeIndividual_Click);
            // 
            // buttonAddIndividual
            // 
            this.buttonAddIndividual.Location = new System.Drawing.Point(35, 623);
            this.buttonAddIndividual.Name = "buttonAddIndividual";
            this.buttonAddIndividual.Size = new System.Drawing.Size(124, 32);
            this.buttonAddIndividual.TabIndex = 33;
            this.buttonAddIndividual.Text = "Добавить";
            this.buttonAddIndividual.UseVisualStyleBackColor = true;
            this.buttonAddIndividual.Click += new System.EventHandler(this.buttonAddIndividual_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelSearch);
            this.groupBox3.Controls.Add(this.textBoxSearchCustomer);
            this.groupBox3.Controls.Add(this.buttonSearchCustomer);
            this.groupBox3.Location = new System.Drawing.Point(26, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 90);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск информации о сотрудниках";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(6, 40);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(107, 17);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Имя заказчика";
            // 
            // textBoxSearchCustomer
            // 
            this.textBoxSearchCustomer.Location = new System.Drawing.Point(138, 37);
            this.textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            this.textBoxSearchCustomer.Size = new System.Drawing.Size(274, 22);
            this.textBoxSearchCustomer.TabIndex = 1;
            // 
            // buttonSearchCustomer
            // 
            this.buttonSearchCustomer.Location = new System.Drawing.Point(442, 32);
            this.buttonSearchCustomer.Name = "buttonSearchCustomer";
            this.buttonSearchCustomer.Size = new System.Drawing.Size(106, 33);
            this.buttonSearchCustomer.TabIndex = 0;
            this.buttonSearchCustomer.Text = "Найти";
            this.buttonSearchCustomer.UseVisualStyleBackColor = true;
            this.buttonSearchCustomer.Click += new System.EventHandler(this.buttonSearchCustomer_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 670);
            this.Controls.Add(this.buttonChangeEntity);
            this.Controls.Add(this.buttonAddEntity);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEntityCustomer);
            this.Controls.Add(this.dataGridViewIndividualCustomer);
            this.Controls.Add(this.buttonDeleteCustomer);
            this.Controls.Add(this.buttonChangeIndividual);
            this.Controls.Add(this.buttonAddIndividual);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о заказчиках";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntityCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndividualCustomer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonChangeEntity;
        private System.Windows.Forms.Button buttonAddEntity;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEntityCustomer;
        private System.Windows.Forms.DataGridView dataGridViewIndividualCustomer;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        public System.Windows.Forms.Button buttonChangeIndividual;
        private System.Windows.Forms.Button buttonAddIndividual;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearchCustomer;
        private System.Windows.Forms.Button buttonSearchCustomer;
    }
}