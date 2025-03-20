using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1_EF_Insert
{
    public partial class FormBolumler : Form
    {

        private int bolumId;
        YazilimKursuDBEntities db = new YazilimKursuDBEntities();//instance al db
        public FormBolumler()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YazilimKursuDBEntities db = new YazilimKursuDBEntities();
            dataGridView1.DataSource = db.Bolumler.ToList();

        }

       


        private void Temizle()
        {
            dataGridView1.DataSource = db.Bolumler.Where(k => k.IsActive == true).ToList();

            textBoxBolumAdi.Clear();
            textBoxKontenjan.Clear();
            bolumId = 0;
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //string getirilenBolumAdi = dataGridView1.CurrentRow.Cells["BolumAdi"].Value.ToString();
            //// MessageBox.Show(getirilenBolumAdi);
            //textBoxBolumAdi.Text = getirilenBolumAdi;
            //yukardaki kodun kısa hali aşağıdaki gibidir.
            textBoxBolumAdi.Text = dataGridView1.CurrentRow.Cells["BolumAdi"].Value.ToString();
            textBoxKontenjan.Text = dataGridView1.CurrentRow.Cells["Kontejan"].Value.ToString();
            bolumId = Convert.ToInt16(dataGridView1.CurrentRow.Cells["BolumlerId"].Value);
        }

        

        private void toolStripButtonSinifEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string bolumAdi = textBoxBolumAdi.Text;
                string kontenjan = textBoxKontenjan.Text;

                //Linq=> C# içiine SQL kodlarını yazmak için kullanılır.
                var varmiKayit = db.Bolumler.Where(k => k.BolumAdi == bolumAdi).FirstOrDefault();

                if (varmiKayit == null)
                {
                    if (!string.IsNullOrEmpty(bolumAdi) && !string.IsNullOrEmpty(kontenjan))
                    {
                        //EF ile Insert işlemi


                        Bolumler bolumEklenecekler = new Bolumler();
                        bolumEklenecekler.BolumAdi = textBoxBolumAdi.Text;
                        //bolumEklenecekler.Kontenjan = 15; 
                        bolumEklenecekler.Kontejan = Convert.ToInt16(textBoxKontenjan.Text);
                        bolumEklenecekler.IsActive = true;

                        //EF ile SQL kayı 
                        db.Bolumler.Add(bolumEklenecekler);
                        //eklenenleri save yap db

                        int kayitSonuc = db.SaveChanges();
                        if (kayitSonuc > 0)
                        {
                            dataGridView1.DataSource = db.Bolumler.ToList();//EF ile list yap
                            MessageBox.Show("Bölüm ekleme başarılı");

                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Başarısız");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bölüm adı/kontenjan boş olamaz");
                    }

                }
                else
                {
                    MessageBox.Show(textBoxBolumAdi.Text + " adında kayıt var");
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Ekleme esnasında hata oluştu:" + ex.Message);
            }
        }

        private void toolStripButtonSinifGuncelle_Click(object sender, EventArgs e)
        {
            if (bolumId > 0)
            {
                //YazilimKursuDBEntities db = new YazilimKursuDBEntities();
                //Linq=> C# içiine SQL kodlarını yazmak için kullanılır.
                var getirBolum = db.Bolumler.Where(k => k.BolumlerId == bolumId).FirstOrDefault();
                //.Where(k=>k.BolumlerId==9);=> where ile linq kullandık
                //k=>k.BolumlerId==9=> Lambda Expression kısmı
                //FirstOrDefault()=> ilk bulduğunu getirir.
                var varmiKayit = db.Bolumler.Where(k => k.BolumAdi == textBoxBolumAdi.Text).FirstOrDefault();

                if (varmiKayit != null)
                {
                    MessageBox.Show(textBoxBolumAdi.Text + " adında kayıt var");
                    return;//metodu bitir
                }

                getirBolum.BolumAdi = textBoxBolumAdi.Text;
                getirBolum.Kontejan = Convert.ToInt16(textBoxKontenjan.Text);

                int guncelleSonuc = db.SaveChanges();//db ye kaydet
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

        private void toolStripButtonSinifSil_Click(object sender, EventArgs e)
        {
            if (bolumId == 0)
            {
                MessageBox.Show("Bölüm seçimi yapınız");
                return;
            }
            //YazilimKursuDBEntities db = new YazilimKursuDBEntities();
            var getirBolum = db.Bolumler.Where(k => k.BolumlerId == bolumId).FirstOrDefault();
            //db.Bolumler.Remove(getirBolum);
            getirBolum.IsActive = false;

            int silSonuc = db.SaveChanges();
            if (silSonuc > 0)
            {
                dataGridView1.DataSource = db.Bolumler.ToList();
                MessageBox.Show("Başarılı bir şekilde silindi");
                Temizle();
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız");
            }
        }

        private void toolStripButtonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
