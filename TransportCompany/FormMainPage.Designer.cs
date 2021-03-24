namespace TransportCompany
{
    partial class FormMainPage
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
            this.menuStripMainPage = new System.Windows.Forms.MenuStrip();
            this.справочныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оперативныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainPage
            // 
            this.menuStripMainPage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMainPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочныеДанныеToolStripMenuItem,
            this.оперативныеДанныеToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStripMainPage.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainPage.Name = "menuStripMainPage";
            this.menuStripMainPage.Size = new System.Drawing.Size(800, 26);
            this.menuStripMainPage.TabIndex = 0;
            this.menuStripMainPage.Text = "menuStrip1";
            // 
            // справочныеДанныеToolStripMenuItem
            // 
            this.справочныеДанныеToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справочныеДанныеToolStripMenuItem.Name = "справочныеДанныеToolStripMenuItem";
            this.справочныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.справочныеДанныеToolStripMenuItem.Text = "Справочные данные";
            // 
            // оперативныеДанныеToolStripMenuItem
            // 
            this.оперативныеДанныеToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.оперативныеДанныеToolStripMenuItem.Name = "оперативныеДанныеToolStripMenuItem";
            this.оперативныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.оперативныеДанныеToolStripMenuItem.Text = "Оперативные данные";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.menuStripMainPage);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStripMainPage;
            this.Name = "FormMainPage";
            this.Text = "Автоматизированная система учета работы компании ООО \"СДК-Магистраль\"";
            this.menuStripMainPage.ResumeLayout(false);
            this.menuStripMainPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainPage;
        private System.Windows.Forms.ToolStripMenuItem справочныеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оперативныеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}