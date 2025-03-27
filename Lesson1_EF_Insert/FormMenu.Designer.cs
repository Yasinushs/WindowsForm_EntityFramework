namespace Lesson1_EF_Insert
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemBolumler = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSiniflar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOgrenci = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBolumler,
            this.toolStripMenuItemSiniflar,
            this.toolStripMenuItemOgrenci});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1037, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemBolumler
            // 
            this.toolStripMenuItemBolumler.Name = "toolStripMenuItemBolumler";
            this.toolStripMenuItemBolumler.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItemBolumler.Text = "Bolumler";
            this.toolStripMenuItemBolumler.Click += new System.EventHandler(this.toolStripMenuItemBolumler_Click);
            // 
            // toolStripMenuItemSiniflar
            // 
            this.toolStripMenuItemSiniflar.Name = "toolStripMenuItemSiniflar";
            this.toolStripMenuItemSiniflar.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItemSiniflar.Text = "Sınıflar";
            this.toolStripMenuItemSiniflar.Click += new System.EventHandler(this.toolStripMenuItemSiniflar_Click);
            // 
            // toolStripMenuItemOgrenci
            // 
            this.toolStripMenuItemOgrenci.Name = "toolStripMenuItemOgrenci";
            this.toolStripMenuItemOgrenci.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuItemOgrenci.Text = "Öğrenciler";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 680);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBolumler;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSiniflar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOgrenci;
    }
}