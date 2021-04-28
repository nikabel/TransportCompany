namespace TransportCompany.forms
{
    partial class FormAddCargo
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
            this.comboBoxCargoType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCargoVolume = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCargoNum = new System.Windows.Forms.TextBox();
            this.buttonAddCargo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCargoName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCargoWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCargoCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTransport = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelApplicationNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCargoType
            // 
            this.comboBoxCargoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCargoType.FormattingEnabled = true;
            this.comboBoxCargoType.Location = new System.Drawing.Point(227, 193);
            this.comboBoxCargoType.Name = "comboBoxCargoType";
            this.comboBoxCargoType.Size = new System.Drawing.Size(238, 24);
            this.comboBoxCargoType.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 109;
            this.label7.Text = "Вид груза";
            // 
            // textBoxCargoVolume
            // 
            this.textBoxCargoVolume.Location = new System.Drawing.Point(227, 151);
            this.textBoxCargoVolume.Name = "textBoxCargoVolume";
            this.textBoxCargoVolume.Size = new System.Drawing.Size(238, 22);
            this.textBoxCargoVolume.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 107;
            this.label6.Text = "Объем груза";
            // 
            // textBoxCargoNum
            // 
            this.textBoxCargoNum.Location = new System.Drawing.Point(227, 23);
            this.textBoxCargoNum.Name = "textBoxCargoNum";
            this.textBoxCargoNum.Size = new System.Drawing.Size(238, 22);
            this.textBoxCargoNum.TabIndex = 104;
            // 
            // buttonAddCargo
            // 
            this.buttonAddCargo.Location = new System.Drawing.Point(168, 339);
            this.buttonAddCargo.Name = "buttonAddCargo";
            this.buttonAddCargo.Size = new System.Drawing.Size(167, 38);
            this.buttonAddCargo.TabIndex = 101;
            this.buttonAddCargo.Text = "Добавить груз";
            this.buttonAddCargo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 100;
            this.label3.Text = "Номер груза";
            // 
            // textBoxCargoName
            // 
            this.textBoxCargoName.Location = new System.Drawing.Point(227, 65);
            this.textBoxCargoName.Name = "textBoxCargoName";
            this.textBoxCargoName.Size = new System.Drawing.Size(238, 22);
            this.textBoxCargoName.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 112;
            this.label1.Text = "Наименование груза";
            // 
            // textBoxCargoWeight
            // 
            this.textBoxCargoWeight.Location = new System.Drawing.Point(227, 110);
            this.textBoxCargoWeight.Name = "textBoxCargoWeight";
            this.textBoxCargoWeight.Size = new System.Drawing.Size(238, 22);
            this.textBoxCargoWeight.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 114;
            this.label4.Text = "Вес груза";
            // 
            // textBoxCargoCost
            // 
            this.textBoxCargoCost.Location = new System.Drawing.Point(227, 238);
            this.textBoxCargoCost.Name = "textBoxCargoCost";
            this.textBoxCargoCost.Size = new System.Drawing.Size(238, 22);
            this.textBoxCargoCost.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 116;
            this.label5.Text = "Стоимость груза";
            // 
            // comboBoxTransport
            // 
            this.comboBoxTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransport.FormattingEnabled = true;
            this.comboBoxTransport.Location = new System.Drawing.Point(227, 284);
            this.comboBoxTransport.Name = "comboBoxTransport";
            this.comboBoxTransport.Size = new System.Drawing.Size(238, 24);
            this.comboBoxTransport.TabIndex = 119;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 118;
            this.label8.Text = "Транспорт";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(511, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(498, 312);
            this.dataGridView1.TabIndex = 120;
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCargo.Location = new System.Drawing.Point(511, 23);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(274, 25);
            this.labelCargo.TabIndex = 121;
            this.labelCargo.Text = "Список грузов в заявке №";
            this.labelCargo.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelApplicationNum
            // 
            this.labelApplicationNum.AutoSize = true;
            this.labelApplicationNum.Location = new System.Drawing.Point(791, 28);
            this.labelApplicationNum.Name = "labelApplicationNum";
            this.labelApplicationNum.Size = new System.Drawing.Size(0, 17);
            this.labelApplicationNum.TabIndex = 122;
            // 
            // FormAddCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 395);
            this.Controls.Add(this.labelApplicationNum);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxTransport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCargoCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCargoWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCargoName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCargoType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCargoVolume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCargoNum);
            this.Controls.Add(this.buttonAddCargo);
            this.Controls.Add(this.label3);
            this.Name = "FormAddCargo";
            this.Text = "Добавление груза";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBoxCargoType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCargoVolume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCargoNum;
        private System.Windows.Forms.Button buttonAddCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCargoName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCargoWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCargoCost;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBoxTransport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelApplicationNum;
    }
}