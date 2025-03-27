using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1_EF_Insert
{
    public partial class FormSiniflar : Form
    {
        private int sinifId;

        public FormSiniflar()
        {
            InitializeComponent();
        }

        YazilimKursuDBEntities db = new YazilimKursuDBEntities();
        private void FormSiniflar_Load(object sender, EventArgs e)
        {
            dataGridViewSinifListesi.DataSource = db.Siniflar.ToList();

            comboBoxBolumler.DataSource = db.Bolumler.Where(k => k.IsActive == true).ToList();
            //
            comboBoxBolumler.DisplayMember = "BolumAdi";//Combobox içinde db den istenilen tablodan kolon adı getirilir. Bu displayMemeber ile Combobox içinde text olarak gösterilmesini sağlar
            comboBoxBolumler.ValueMember = "BolumlerId";//Value(değer) memeber Id alanlarını tutmak için kullanılır. Projenin içinde ComboBox içinde yer alan datalarını Id değerleri lazım olduğında SelectedValue ,le Id değerini çekmek için kulanılır

        }
        private void toolStripButtonSinifEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string sinifAdi = textBoxSinifAdi.Text;
                var varmıKayıt = db.Siniflar.Where(k => k.SinifAdi == sinifAdi).FirstOrDefault();

                

                
                if (varmıKayıt == null)
                {

                    
                    if (!string.IsNullOrEmpty(sinifAdi))
                    {
                        Siniflar eklenecekSinif = new Siniflar();
                        eklenecekSinif.SinifAdi = textBoxSinifAdi.Text;
                        eklenecekSinif.BolumId = (int)comboBoxBolumler.SelectedValue;
                        eklenecekSinif.Aciklama = textBoxAciklama.Text;
                        eklenecekSinif.EgitmenId = 1;
                        
                        
                        db.Entry(eklenecekSinif).State = System.Data.Entity.EntityState.Added;
                        int kayitsonuc = db.SaveChanges();
                        if (kayitsonuc > 0)
                        {
                            MessageBox.Show("Sınıf Eklendi");
                            dataGridViewSinifListesi.DataSource = db.Siniflar.ToList();
                        }
                        else
                        {
                            MessageBox.Show("Başarısız");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sınıf Eklenemedi");
                    }
                }
                else
                {
                    MessageBox.Show(textBoxSinifAdi.Text + " adında kayıt var");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex.Message);
                //throw;
            }


        }



        private void toolStripButtonSinifGuncelle_Click(object sender, EventArgs e)
        {

            if (sinifId > 0)
            {
                string sinifAdi = textBoxSinifAdi.Text;
                var getirSinif = db.Siniflar.Where(k => k.SiniflarId == sinifId).FirstOrDefault();
                var varmiKayit = db.Siniflar.Where(k => k.SinifAdi == sinifAdi).FirstOrDefault();
                if (varmiKayit != null)
                {
                    MessageBox.Show(textBoxSinifAdi.Text + " adında kayıt var");
                    return;//metodu bitir
                }
                getirSinif.SinifAdi = textBoxSinifAdi.Text;
                getirSinif.BolumId = (int)comboBoxBolumler.SelectedValue;
                int guncelleSonuc = db.SaveChanges();
                if (guncelleSonuc > 0)
                {
                    MessageBox.Show("Başarılı bir şekilde güncellendi");
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız");
                }
            }
            else
            {
                MessageBox.Show("Bölüm seçimi yapınız");
            }

        }





        
        public void Temizle()
        {
            dataGridViewSinifListesi.DataSource = db.Bolumler.Where(k => k.IsActive == true).ToList();

            textBoxSinifAdi.Clear();
            
            sinifId = 0;
        }
    }
}
