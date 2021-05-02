namespace TransportCompany
{
    partial class FormChangeStopType
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
            this.textBoxUpdateStopTypeName = new System.Windows.Forms.TextBox();
            this.buttonChangeStopType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Наименование операции";
            // 
            // textBoxUpdateStopTypeName
            // 
            this.textBoxUpdateStopTypeName.Location = new System.Drawing.Point(274, 19);
            this.textBoxUpdateStopTypeName.Name = "textBoxUpdateStopTypeName";
            this.textBoxUpdateStopTypeName.Size = new System.Drawing.Size(238, 22);
            this.textBoxUpdateStopTypeName.TabIndex = 12;
            // 
            // buttonChangeStopType
            // 
            this.buttonChangeStopType.Location = new System.Drawing.Point(209, 69);
            this.buttonChangeStopType.Name = "buttonChangeStopType";
            this.buttonChangeStopType.Size = new System.Drawing.Size(109, 33);
            this.buttonChangeStopType.TabIndex = 11;
            this.buttonChangeStopType.Text = "Сохранить";
            this.buttonChangeStopType.UseVisualStyleBackColor = true;
            this.buttonChangeStopType.Click += new System.EventHandler(this.buttonChangeStopType_Click);
            // 
            // FormChangeStopType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 116);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUpdateStopTypeName);
            this.Controls.Add(this.buttonChangeStopType);
            this.Name = "FormChangeStopType";
            this.Text = "Информация об операциях";
            this.Load += new System.EventHandler(this.FormChangeStopType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxUpdateStopTypeName;
        private System.Windows.Forms.Button buttonChangeStopType;
    }
}