namespace Lesson1_EF_Insert
{
    partial class FormBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBolumler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxBolumAdi = new System.Windows.Forms.TextBox();
            this.textBoxKontenjan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBolumEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBolumGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBolumSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // textBoxBolumAdi
            // 
            this.textBoxBolumAdi.Location = new System.Drawing.Point(67, 13);
            this.textBoxBolumAdi.Name = "textBoxBolumAdi";
            this.textBoxBolumAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxBolumAdi.TabIndex = 1;
            // 
            // textBoxKontenjan
            // 
            this.textBoxKontenjan.Location = new System.Drawing.Point(67, 40);
            this.textBoxKontenjan.Name = "textBoxKontenjan";
            this.textBoxKontenjan.Size = new System.Drawing.Size(100, 20);
            this.textBoxKontenjan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bölüm Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kontenjan";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBolumEkle,
            this.toolStripButtonBolumGuncelle,
            this.toolStripButtonBolumSil,
            this.toolStripButtonTemizle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(481, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonBolumEkle
            // 
            this.toolStripButtonBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBolumEkle.Image")));
            this.toolStripButtonBolumEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBolumEkle.Name = "toolStripButtonBolumEkle";
            this.toolStripButtonBolumEkle.Size = new System.Drawing.Size(48, 22);
            this.toolStripButtonBolumEkle.Text = "Ekle";
            this.toolStripButtonBolumEkle.Click += new System.EventHandler(this.toolStripButtonBolumEkle_Click);
            // 
            // toolStripButtonBolumGuncelle
            // 
            this.toolStripButtonBolumGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBolumGuncelle.Image")));
            this.toolStripButtonBolumGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBolumGuncelle.Name = "toolStripButtonBolumGuncelle";
            this.toolStripButtonBolumGuncelle.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonBolumGuncelle.Text = "Güncelle";
            this.toolStripButtonBolumGuncelle.Click += new System.EventHandler(this.toolStripButtonBolumGuncelle_Click);
            // 
            // toolStripButtonBolumSil
            // 
            this.toolStripButtonBolumSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBolumSil.Image")));
            this.toolStripButtonBolumSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBolumSil.Name = "toolStripButtonBolumSil";
            this.toolStripButtonBolumSil.Size = new System.Drawing.Size(39, 22);
            this.toolStripButtonBolumSil.Text = "Sil";
            this.toolStripButtonBolumSil.Click += new System.EventHandler(this.toolStripButtonBolumSil_Click);
            // 
            // toolStripButtonTemizle
            // 
            this.toolStripButtonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTemizle.Image")));
            this.toolStripButtonTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTemizle.Name = "toolStripButtonTemizle";
            this.toolStripButtonTemizle.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonTemizle.Text = "Temizle";
            this.toolStripButtonTemizle.Click += new System.EventHandler(this.toolStripButtonTemizle_Click);
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Location = new System.Drawing.Point(259, 13);
            this.textBoxAciklama.Multiline = true;
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(180, 115);
            this.textBoxAciklama.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Açıklama";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxAciklama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxKontenjan);
            this.groupBox1.Controls.Add(this.textBoxBolumAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 150);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bölüm Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 192);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bölüm Listesi";
            // 
            // FormBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormBolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxBolumAdi;
        private System.Windows.Forms.TextBox textBoxKontenjan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBolumEkle;
        private System.Windows.Forms.ToolStripButton toolStripButtonBolumGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonBolumSil;
        private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
        private System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

