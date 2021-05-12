namespace TransportCompany.forms
{
    partial class FormChooseContract
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
            this.comboBoxContracts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxContracts
            // 
            this.comboBoxContracts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContracts.FormattingEnabled = true;
            this.comboBoxContracts.Location = new System.Drawing.Point(237, 40);
            this.comboBoxContracts.Name = "comboBoxContracts";
            this.comboBoxContracts.Size = new System.Drawing.Size(238, 24);
            this.comboBoxContracts.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Выберите номер договора";
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(132, 104);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(227, 34);
            this.buttonChoose.TabIndex = 66;
            this.buttonChoose.Text = "Перейти к печати договора";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // FormChooseContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 158);
            this.Controls.Add(this.comboBoxContracts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChoose);
            this.Name = "FormChooseContract";
            this.Text = "Печать договора об оказании услуг";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxContracts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChoose;
    }
}