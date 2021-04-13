namespace TransportCompany.forms
{
    partial class FormChangeSpec
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSpecName = new System.Windows.Forms.TextBox();
            this.textBoxSpecDesc = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Описание специализации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Наименование специализации";
            // 
            // textBoxSpecName
            // 
            this.textBoxSpecName.Location = new System.Drawing.Point(274, 22);
            this.textBoxSpecName.Name = "textBoxSpecName";
            this.textBoxSpecName.Size = new System.Drawing.Size(238, 22);
            this.textBoxSpecName.TabIndex = 22;
            // 
            // textBoxSpecDesc
            // 
            this.textBoxSpecDesc.Location = new System.Drawing.Point(274, 61);
            this.textBoxSpecDesc.Name = "textBoxSpecDesc";
            this.textBoxSpecDesc.Size = new System.Drawing.Size(238, 22);
            this.textBoxSpecDesc.TabIndex = 23;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(206, 109);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(101, 28);
            this.buttonChange.TabIndex = 21;
            this.buttonChange.Text = "Сохранить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // FormChangeSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 153);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSpecName);
            this.Controls.Add(this.textBoxSpecDesc);
            this.Controls.Add(this.buttonChange);
            this.Name = "FormChangeSpec";
            this.Text = "Информация о специализациях сотрудников";
            this.Load += new System.EventHandler(this.FormChangeSpec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxSpecName;
        public System.Windows.Forms.TextBox textBoxSpecDesc;
        private System.Windows.Forms.Button buttonChange;
    }
}