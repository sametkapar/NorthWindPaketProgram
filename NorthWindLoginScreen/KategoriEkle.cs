using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWindLoginScreen
{
    public partial class KategoriEkle : Form
    {
        public KategoriEkle()
        {
            InitializeComponent();
        }

        private void btn_ekle_duzenle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text))
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Categories (CategoryName,Description) VALUES (@name,@des)";
                cmd.Parameters.AddWithValue("@name", tb_name.Text);
                cmd.Parameters.AddWithValue("@des", tb_aciklama.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    tb_aciklama.Text = tb_name.Text = "";
                    MessageBox.Show("Kategori başarıyla eklenmiştir.", "Başarılı");

                }
                catch
                {
                    MessageBox.Show("Kategori ekleme işleminde bir hata ile karşılaşıldı", "Hata");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_aciklama.Text = tb_id.Text = tb_name.Text = "";
        }
    }
}
