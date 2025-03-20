namespace Lesson1_EF_Insert
{
    partial class FormSiniflar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiniflar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSinifEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSinifGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSinifSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSinifListesi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSinifAdi = new System.Windows.Forms.TextBox();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.comboBoxBolumler = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinifListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSinifEkle,
            this.toolStripButtonSinifGuncelle,
            this.toolStripButtonSinifSil,
            this.toolStripButtonTemizle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(640, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSinifEkle
            // 
            this.toolStripButtonSinifEkle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSinifEkle.Image")));
            this.toolStripButtonSinifEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSinifEkle.Name = "toolStripButtonSinifEkle";
            this.toolStripButtonSinifEkle.Size = new System.Drawing.Size(48, 22);
            this.toolStripButtonSinifEkle.Text = "Ekle";
            this.toolStripButtonSinifEkle.Click += new System.EventHandler(this.toolStripButtonSinifEkle_Click);
            // 
            // toolStripButtonSinifGuncelle
            // 
            this.toolStripButtonSinifGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSinifGuncelle.Image")));
            this.toolStripButtonSinifGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSinifGuncelle.Name = "toolStripButtonSinifGuncelle";
            this.toolStripButtonSinifGuncelle.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonSinifGuncelle.Text = "Güncelle";
            // 
            // toolStripButtonSinifSil
            // 
            this.toolStripButtonSinifSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSinifSil.Image")));
            this.toolStripButtonSinifSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSinifSil.Name = "toolStripButtonSinifSil";
            this.toolStripButtonSinifSil.Size = new System.Drawing.Size(39, 22);
            this.toolStripButtonSinifSil.Text = "Sil";
            // 
            // toolStripButtonTemizle
            // 
            this.toolStripButtonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTemizle.Image")));
            this.toolStripButtonTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTemizle.Name = "toolStripButtonTemizle";
            this.toolStripButtonTemizle.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonTemizle.Text = "Temizle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxBolumler);
            this.groupBox1.Controls.Add(this.textBoxAciklama);
            this.groupBox1.Controls.Add(this.textBoxSinifAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınıf Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewSinifListesi);
            this.groupBox2.Location = new System.Drawing.Point(13, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 196);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınıf Listesi";
            // 
            // dataGridViewSinifListesi
            // 
            this.dataGridViewSinifListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinifListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSinifListesi.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewSinifListesi.Name = "dataGridViewSinifListesi";
            this.dataGridViewSinifListesi.Size = new System.Drawing.Size(609, 177);
            this.dataGridViewSinifListesi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıf Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölümü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama";
            // 
            // textBoxSinifAdi
            // 
            this.textBoxSinifAdi.Location = new System.Drawing.Point(77, 20);
            this.textBoxSinifAdi.Name = "textBoxSinifAdi";
            this.textBoxSinifAdi.Size = new System.Drawing.Size(180, 20);
            this.textBoxSinifAdi.TabIndex = 3;
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Location = new System.Drawing.Point(336, 17);
            this.textBoxAciklama.Multiline = true;
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(180, 115);
            this.textBoxAciklama.TabIndex = 4;
            // 
            // comboBoxBolumler
            // 
            this.comboBoxBolumler.FormattingEnabled = true;
            this.comboBoxBolumler.Location = new System.Drawing.Point(77, 64);
            this.comboBoxBolumler.Name = "comboBoxBolumler";
            this.comboBoxBolumler.Size = new System.Drawing.Size(180, 21);
            this.comboBoxBolumler.TabIndex = 5;
            // 
            // FormSiniflar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormSiniflar";
            this.Text = "FormSiniflar";
            this.Load += new System.EventHandler(this.FormSiniflar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinifListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSinifEkle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSinifGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSinifSil;
        private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewSinifListesi;
        private System.Windows.Forms.ComboBox comboBoxBolumler;
        private System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.TextBox textBoxSinifAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}