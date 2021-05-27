namespace TransportCompany.forms
{
    partial class FormChooseApplication
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
            this.comboBoxApps = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxApps
            // 
            this.comboBoxApps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApps.FormattingEnabled = true;
            this.comboBoxApps.Location = new System.Drawing.Point(221, 28);
            this.comboBoxApps.Name = "comboBoxApps";
            this.comboBoxApps.Size = new System.Drawing.Size(238, 24);
            this.comboBoxApps.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Выберите номер заявки";
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(116, 92);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(227, 34);
            this.buttonChoose.TabIndex = 72;
            this.buttonChoose.Text = "Перейти к печати заявки";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // FormChooseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 154);
            this.Controls.Add(this.comboBoxApps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChoose);
            this.Name = "FormChooseApplication";
            this.Text = "Печать заявки на перевозку груза";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxApps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChoose;
    }
}