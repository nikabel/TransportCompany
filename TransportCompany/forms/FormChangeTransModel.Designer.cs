namespace TransportCompany.forms
{
    partial class FormChangeTransModel
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModelDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxModelName = new System.Windows.Forms.TextBox();
            this.textBoxMarkName = new System.Windows.Forms.TextBox();
            this.buttonChangeStopType = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxModelCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Характеристика модели";
            // 
            // textBoxModelDesc
            // 
            this.textBoxModelDesc.Location = new System.Drawing.Point(274, 96);
            this.textBoxModelDesc.Name = "textBoxModelDesc";
            this.textBoxModelDesc.Size = new System.Drawing.Size(238, 22);
            this.textBoxModelDesc.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Наименование марки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Наименование модели";
            // 
            // textBoxModelName
            // 
            this.textBoxModelName.Location = new System.Drawing.Point(274, 21);
            this.textBoxModelName.Name = "textBoxModelName";
            this.textBoxModelName.Size = new System.Drawing.Size(238, 22);
            this.textBoxModelName.TabIndex = 24;
            // 
            // textBoxMarkName
            // 
            this.textBoxMarkName.Location = new System.Drawing.Point(274, 60);
            this.textBoxMarkName.Name = "textBoxMarkName";
            this.textBoxMarkName.Size = new System.Drawing.Size(238, 22);
            this.textBoxMarkName.TabIndex = 25;
            // 
            // buttonChangeStopType
            // 
            this.buttonChangeStopType.Location = new System.Drawing.Point(204, 185);
            this.buttonChangeStopType.Name = "buttonChangeStopType";
            this.buttonChangeStopType.Size = new System.Drawing.Size(101, 28);
            this.buttonChangeStopType.TabIndex = 23;
            this.buttonChangeStopType.Text = "Сохранить";
            this.buttonChangeStopType.UseVisualStyleBackColor = true;
            this.buttonChangeStopType.Click += new System.EventHandler(this.buttonChangeStopType_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Количество в автопарке";
            // 
            // textBoxModelCount
            // 
            this.textBoxModelCount.Location = new System.Drawing.Point(274, 136);
            this.textBoxModelCount.Name = "textBoxModelCount";
            this.textBoxModelCount.Size = new System.Drawing.Size(238, 22);
            this.textBoxModelCount.TabIndex = 30;
            // 
            // FormChangeTransModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 235);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxModelCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxModelDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxModelName);
            this.Controls.Add(this.textBoxMarkName);
            this.Controls.Add(this.buttonChangeStopType);
            this.Name = "FormChangeTransModel";
            this.Text = "Информация о моделях транспорта";
            this.Load += new System.EventHandler(this.FormChangeTransModel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxModelDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxModelName;
        public System.Windows.Forms.TextBox textBoxMarkName;
        private System.Windows.Forms.Button buttonChangeStopType;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxModelCount;
    }
}