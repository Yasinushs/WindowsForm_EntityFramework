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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemBolumler_Click(object sender, EventArgs e)
        {
            FormBolumler frmBolumler = new FormBolumler();
          frmBolumler.MdiParent = this;//??
            frmBolumler.Show();
        }

        private void toolStripMenuItemSiniflar_Click(object sender, EventArgs e)
        {
            FormSiniflar frmSiniflar = new FormSiniflar();
            frmSiniflar.MdiParent = this;
            frmSiniflar.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
