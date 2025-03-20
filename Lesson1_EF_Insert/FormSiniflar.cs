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
        public FormSiniflar()
        {
            InitializeComponent();
        }

        YazilimKursuDBEntities db= new YazilimKursuDBEntities();
        private void toolStripButtonSinifEkle_Click(object sender, EventArgs e)
        {
            try
            {

                Siniflar eklenecekSinif = new Siniflar();
                eklenecekSinif.SinifAdi = textBoxSinifAdi.Text;
                eklenecekSinif.BolumId = (int)comboBoxBolumler.SelectedValue;
                eklenecekSinif.Aciklama = textBoxAciklama.Text;
                db.Entry(eklenecekSinif).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:"+ex.Message);
                //throw;
            }

        }

        private void FormSiniflar_Load(object sender, EventArgs e)
        {
            dataGridViewSinifListesi.DataSource = db.Siniflar.ToList();

            comboBoxBolumler.DataSource = db.Bolumler.Where(k=>k.IsActive ==true).ToList();
            //
            comboBoxBolumler.DisplayMember = "BolumAdi";//Combobox içinde db den istenilen tablodan kolon adı getirilir. Bu displayMemeber ile Combobox içinde text olarak gösterilmesini sağlar
            comboBoxBolumler.ValueMember = "BolumlerId";//Value(değer) memeber Id alanlarını tutmak için kullanılır. Projenin içinde ComboBox içinde yer alan datalarını Id değerleri lazım olduğında SelectedValue ,le Id değerini çekmek için kulanılır

        }
    }
}
