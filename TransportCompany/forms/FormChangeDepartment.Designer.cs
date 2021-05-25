namespace TransportCompany.forms
{
    partial class FormChangeDepartment
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
            this.textBoxDepName = new System.Windows.Forms.TextBox();
            this.textBoxCompName = new System.Windows.Forms.TextBox();
            this.buttonChangeStopType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Наименование компании";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Наименование отдела";
            // 
            // textBoxDepName
            // 
            this.textBoxDepName.Location = new System.Drawing.Point(284, 22);
            this.textBoxDepName.MaxLength = 50;
            this.textBoxDepName.Name = "textBoxDepName";
            this.textBoxDepName.Size = new System.Drawing.Size(238, 22);
            this.textBoxDepName.TabIndex = 17;
            // 
            // textBoxCompName
            // 
            this.textBoxCompName.Location = new System.Drawing.Point(284, 61);
            this.textBoxCompName.MaxLength = 50;
            this.textBoxCompName.Name = "textBoxCompName";
            this.textBoxCompName.Size = new System.Drawing.Size(238, 22);
            this.textBoxCompName.TabIndex = 18;
            this.textBoxCompName.Text = "ООО \"СДК-Магистраль\"";
            // 
            // buttonChangeStopType
            // 
            this.buttonChangeStopType.Location = new System.Drawing.Point(206, 111);
            this.buttonChangeStopType.Name = "buttonChangeStopType";
            this.buttonChangeStopType.Size = new System.Drawing.Size(109, 33);
            this.buttonChangeStopType.TabIndex = 16;
            this.buttonChangeStopType.Text = "Сохранить";
            this.buttonChangeStopType.UseVisualStyleBackColor = true;
            this.buttonChangeStopType.Click += new System.EventHandler(this.buttonChangeStopType_Click);
            // 
            // FormChangeDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 156);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDepName);
            this.Controls.Add(this.textBoxCompName);
            this.Controls.Add(this.buttonChangeStopType);
            this.Name = "FormChangeDepartment";
            this.Text = "Информация об отделе";
            this.Load += new System.EventHandler(this.FormChangeDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxDepName;
        public System.Windows.Forms.TextBox textBoxCompName;
        private System.Windows.Forms.Button buttonChangeStopType;
    }
}