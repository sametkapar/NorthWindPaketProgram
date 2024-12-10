using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWindLoginScreen
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            GirisFormu frm = new GirisFormu();
            frm.ShowDialog();

            toolStripStatusLabel1.Text = "Kullanıcı = " + LoginUser.user.FullName + " ☜(ﾟヮﾟ☜)";
        }

        private void TSMI_kategori_Click(object sender, EventArgs e)
        {
            KategoriIslemleri ki = new KategoriIslemleri();
            ki.ShowDialog();
        }

        private void TSMI_urunler_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;
            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(UrunIslemleri))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                UrunIslemleri frm = new UrunIslemleri();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }
    }
}
