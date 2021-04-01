namespace TransportCompany
{
    partial class StopTypeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDeleteStopType = new System.Windows.Forms.Button();
            this.buttonChangeStopType = new System.Windows.Forms.Button();
            this.buttonAddStopType = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearchStopType = new System.Windows.Forms.TextBox();
            this.buttonSearchTransportType = new System.Windows.Forms.Button();
            this.dataGridViewStopType = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStopType)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteStopType
            // 
            this.buttonDeleteStopType.Location = new System.Drawing.Point(626, 50);
            this.buttonDeleteStopType.Name = "buttonDeleteStopType";
            this.buttonDeleteStopType.Size = new System.Drawing.Size(123, 32);
            this.buttonDeleteStopType.TabIndex = 12;
            this.buttonDeleteStopType.Text = "Удалить";
            this.buttonDeleteStopType.UseVisualStyleBackColor = true;
            this.buttonDeleteStopType.Click += new System.EventHandler(this.buttonDeleteStopType_Click);
            // 
            // buttonChangeStopType
            // 
            this.buttonChangeStopType.Location = new System.Drawing.Point(626, 12);
            this.buttonChangeStopType.Name = "buttonChangeStopType";
            this.buttonChangeStopType.Size = new System.Drawing.Size(123, 32);
            this.buttonChangeStopType.TabIndex = 13;
            this.buttonChangeStopType.Text = "Изменить";
            this.buttonChangeStopType.UseVisualStyleBackColor = true;
            this.buttonChangeStopType.Click += new System.EventHandler(this.buttonChangeStopType_Click);
            // 
            // buttonAddStopType
            // 
            this.buttonAddStopType.Location = new System.Drawing.Point(626, 88);
            this.buttonAddStopType.Name = "buttonAddStopType";
            this.buttonAddStopType.Size = new System.Drawing.Size(124, 32);
            this.buttonAddStopType.TabIndex = 14;
            this.buttonAddStopType.Text = "Добавить";
            this.buttonAddStopType.UseVisualStyleBackColor = true;
            this.buttonAddStopType.Click += new System.EventHandler(this.buttonAddStopType_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelSearch);
            this.groupBox3.Controls.Add(this.textBoxSearchStopType);
            this.groupBox3.Controls.Add(this.buttonSearchTransportType);
            this.groupBox3.Location = new System.Drawing.Point(12, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 90);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск информации о видах остановок";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(6, 40);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(105, 17);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Вид остановки";
            // 
            // textBoxSearchStopType
            // 
            this.textBoxSearchStopType.Location = new System.Drawing.Point(138, 37);
            this.textBoxSearchStopType.Name = "textBoxSearchStopType";
            this.textBoxSearchStopType.Size = new System.Drawing.Size(274, 22);
            this.textBoxSearchStopType.TabIndex = 1;
            // 
            // buttonSearchTransportType
            // 
            this.buttonSearchTransportType.Location = new System.Drawing.Point(442, 32);
            this.buttonSearchTransportType.Name = "buttonSearchTransportType";
            this.buttonSearchTransportType.Size = new System.Drawing.Size(106, 33);
            this.buttonSearchTransportType.TabIndex = 0;
            this.buttonSearchTransportType.Text = "Найти";
            this.buttonSearchTransportType.UseVisualStyleBackColor = true;
            this.buttonSearchTransportType.Click += new System.EventHandler(this.buttonSearchTransportType_Click);
            // 
            // dataGridViewStopType
            // 
            this.dataGridViewStopType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStopType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStopType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStopType.Location = new System.Drawing.Point(12, 126);
            this.dataGridViewStopType.Name = "dataGridViewStopType";
            this.dataGridViewStopType.RowHeadersVisible = false;
            this.dataGridViewStopType.RowHeadersWidth = 51;
            this.dataGridViewStopType.RowTemplate.Height = 24;
            this.dataGridViewStopType.Size = new System.Drawing.Size(748, 312);
            this.dataGridViewStopType.TabIndex = 18;
            // 
            // StopTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.dataGridViewStopType);
            this.Controls.Add(this.buttonDeleteStopType);
            this.Controls.Add(this.buttonChangeStopType);
            this.Controls.Add(this.buttonAddStopType);
            this.Controls.Add(this.groupBox3);
            this.Name = "StopTypeForm";
            this.Text = "Информация о видах остановок";
            this.Load += new System.EventHandler(this.StopTypeForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStopType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDeleteStopType;
        public System.Windows.Forms.Button buttonChangeStopType;
        private System.Windows.Forms.Button buttonAddStopType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearchStopType;
        private System.Windows.Forms.Button buttonSearchTransportType;
        private System.Windows.Forms.DataGridView dataGridViewStopType;
    }
}

