using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWindLoginScreen
{
    public partial class KategoriIslemleri : Form
    {
        int rowindex = -1;
        public KategoriIslemleri()
        {
            InitializeComponent();
            KategoriListele();
        }
        public void KategoriListele()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Categories";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Kategori No");
            dt.Columns.Add("Kategori İsmi");
            dt.Columns.Add("Açıklama");
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string description = reader.GetString(2);
                dt.Rows.Add(id, name, description);
            }
            //dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.ClearSelection();
                rowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (rowindex != -1)
                {
                    //MessageBox.Show("Sağ Button", "Tıklandı");
                    contextMenuStrip1.Show(dataGridView1, e.X, e.Y);

                    dataGridView1.Rows[rowindex].Selected = true;
                }
            }
        }
        private void TSMI_duzenle_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                btn_ekle_duzenle.Text = "Düzenle";
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                //MessageBox.Show(id.ToString(), "Seçilen Kategori ID");

                //Category c = new Category();
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT CategoryID,CategoryName,Description FROM Categories WHERE CategoryID=@id";
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tb_id.Text = reader.GetInt32(0).ToString();
                        tb_name.Text = reader.GetString(1);
                        tb_aciklama.Text = reader.IsDBNull(2) == false ? reader.GetString(2) : "";
                    }
                }
                catch
                {
                    MessageBox.Show("Kategori getirilirkene bir hata oluşuveedi", "Hata Var");
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void btn_ekle_duzenle_Click(object sender, EventArgs e)
        {
            if (btn_ekle_duzenle.Text == "Ekle")
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
                    KategoriListele();
                }

            }
            if (btn_ekle_duzenle.Text == "Düzenle")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Categories SET CategoryName=@name, Description=@des WHERE CategoryID=@id";
                cmd.Parameters.AddWithValue("@name", tb_name.Text);
                cmd.Parameters.AddWithValue("@des", tb_aciklama.Text);
                cmd.Parameters.AddWithValue("id", tb_id.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Katergori başarıyla güncelledi", "Başarılı");
                    btn_ekle_duzenle.Text = "Ekle";

                }
                catch
                {
                    MessageBox.Show("Kategori güncellenirken bir hata ile karşılaşıldı", "Hata");
                }
                finally
                {
                    con.Close();
                }
                KategoriListele();
                tb_id.Text = tb_name.Text = tb_aciklama.Text = "";
            }
        }
        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                if (MessageBox.Show($"{id} id'li Kategori Silinecektir.\nOnaylıyor Musunuz?", "Kategori Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM Categories WHERE CategoryID = @id";
                    cmd.Parameters.AddWithValue ("id", id);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kategori Silinmiştir", "Başarılı");
                    }
                    finally
                    {
                        con.Close();
                    }
                    KategoriListele();
                }
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_aciklama.Text = tb_id.Text = tb_name.Text = "";
        }
    }
}
