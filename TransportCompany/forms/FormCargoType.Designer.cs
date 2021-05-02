namespace TransportCompany.forms
{
    partial class FormCargoType
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCargoTypeName = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Вид груза";
            // 
            // textBoxCargoTypeName
            // 
            this.textBoxCargoTypeName.Location = new System.Drawing.Point(165, 38);
            this.textBoxCargoTypeName.Name = "textBoxCargoTypeName";
            this.textBoxCargoTypeName.Size = new System.Drawing.Size(238, 22);
            this.textBoxCargoTypeName.TabIndex = 17;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(165, 89);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(101, 28);
            this.buttonChange.TabIndex = 16;
            this.buttonChange.Text = "Сохранить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // FormCargoType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 151);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCargoTypeName);
            this.Controls.Add(this.buttonChange);
            this.Name = "FormCargoType";
            this.Text = "Информация о видах грузов";
            this.Load += new System.EventHandler(this.FormCargoType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxCargoTypeName;
        private System.Windows.Forms.Button buttonChange;
    }
}