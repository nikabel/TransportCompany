namespace TransportCompany.forms
{
    partial class SetWorkChooseContractForm
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
            this.buttonChoose = new System.Windows.Forms.Button();
            this.comboBoxContractNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxContracts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(142, 119);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(227, 34);
            this.buttonChoose.TabIndex = 63;
            this.buttonChoose.Text = "Перейти к назначению работ";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // comboBoxContractNum
            // 
            this.comboBoxContractNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContractNum.FormattingEnabled = true;
            this.comboBoxContractNum.Location = new System.Drawing.Point(254, -101);
            this.comboBoxContractNum.Name = "comboBoxContractNum";
            this.comboBoxContractNum.Size = new System.Drawing.Size(238, 24);
            this.comboBoxContractNum.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, -98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Номер договора";
            // 
            // comboBoxContracts
            // 
            this.comboBoxContracts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContracts.FormattingEnabled = true;
            this.comboBoxContracts.Location = new System.Drawing.Point(247, 55);
            this.comboBoxContracts.Name = "comboBoxContracts";
            this.comboBoxContracts.Size = new System.Drawing.Size(238, 24);
            this.comboBoxContracts.TabIndex = 65;
            this.comboBoxContracts.SelectedIndexChanged += new System.EventHandler(this.comboBoxContracts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Выберите номер договора";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SetWorkChooseContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 191);
            this.Controls.Add(this.comboBoxContracts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.comboBoxContractNum);
            this.Controls.Add(this.label2);
            this.Name = "SetWorkChooseContractForm";
            this.Text = "Назначение сотрудников для работы над заказом";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChoose;
        public System.Windows.Forms.ComboBox comboBoxContractNum;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBoxContracts;
        private System.Windows.Forms.Label label1;
    }
}