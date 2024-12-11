using NorthWindLoginScreen.Model;
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
using System.Xml.Linq;

namespace NorthWindLoginScreen
{
    public partial class UrunIslemleri : Form
    {
        int rowindex, rowindex2 = -1;
        public UrunIslemleri()
        {
            InitializeComponent();
        }

        private void UrunIslemleri_Load(object sender, EventArgs e)
        {
            TedarikciListele();
            UrunListele();
            KategoriListele();
        }
        public void UrunListele()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT ProductID, ProductName, CompanyName, CategoryName, UnitPrice, UnitsInstock, ReorderLevel, Discontinued FROM Products as P JOIN Categories as C ON C.CategoryID = P.CategoryID JOIN Suppliers as S ON S.SupplierID= P.SupplierID";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ürün Adı");
            dt.Columns.Add("Tedarikçi Şirket");
            dt.Columns.Add("Kategori Adı");
            dt.Columns.Add("Ürün Fiyatı");
            dt.Columns.Add("Stok Miktarı");
            dt.Columns.Add("Minimum Stok Miktarı");
            dt.Columns.Add("Satışıta mı");
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string isim = reader.GetString(1);
                string sirket = reader.GetString(2);
                string kategori = reader.GetString(3);
                decimal fiyat = reader.GetDecimal(4);
                short stokMik = reader.GetInt16(5);
                short minStok = reader.GetInt16(6);
                bool gelen = reader.GetBoolean(7);
                string satistami = gelen ? "Evet" : "Hayır";


                dt.Rows.Add(id, isim, sirket, kategori, fiyat, stokMik, minStok, satistami);
            }
            DGV_Urun.DataSource = dt;

        }
        public void TedarikciListele()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT SupplierID, CompanyName, ContactName, Phone, Address FROM Suppliers";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Şirket Adı");
            dt.Columns.Add("Temsilci Adı");
            dt.Columns.Add("Telefon");
            dt.Columns.Add("Adress");
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string sirket = reader.GetString(1);
                string temsilci = reader.GetString(2);
                string telefon = reader.GetString(3);
                string adres = reader.GetString(4);
                dt.Rows.Add(id, sirket, temsilci, telefon, adres);
            }
            DGV_tedarikci.DataSource = dt;
        }
        public void KategoriListele()
        {
            List<Category> kategoriler = new List<Category>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT CategoryID, CategoryName FROM Categories";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Category k = new Category();
                k.ID = reader.GetInt32(0);
                k.Name = reader.GetString(1);
                kategoriler.Add(k);
            }
            con.Close();
            cb_kategoriAdi.Items.Clear();
            cb_kategoriAdi.DataSource = kategoriler;
            cb_kategoriAdi.ValueMember = "ID";
            cb_kategoriAdi.DisplayMember = "Name";
        }
        private void btn_katEkle_Click(object sender, EventArgs e)
        {
            KategoriEkle ki = new KategoriEkle();
            ki.Show();
        }

        private void DGV_Urun_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DGV_Urun.ClearSelection();
                rowindex = DGV_Urun.HitTest(e.X, e.Y).RowIndex;
                if (rowindex != -1)
                {
                    //MessageBox.Show("Sağ Button", "Tıklandı");
                    contextMenuStrip1.Show(DGV_Urun, e.X, e.Y);

                    DGV_Urun.Rows[rowindex].Selected = true;
                }
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                btn_ekle_duzenle.Text = "Düzenle";
                int id = Convert.ToInt32(DGV_Urun.Rows[rowindex].Cells[0].Value);
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock, ReorderLevel, Discontinued FROM Products WHERE ProductID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tb_ID.Text = reader.GetInt32(0).ToString();
                        tb_name.Text = reader.GetString(1);
                        tb_price.Text = reader.GetDecimal(2).ToString();
                        tb_stock.Text = reader.GetInt16(3).ToString();
                        tb_reOrderLevel.Text = reader.GetInt16(4).ToString();
                        bool dis = reader.GetBoolean(5);
                        if (dis == true)
                        {
                            rb_satisEvet.Checked = true;
                        }
                        else
                        {
                            rb_satisHayir.Checked = true;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Kategori getirilirken bir hata oluştu", "Hata");
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
                    cmd.CommandText = "INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice, UnitInStock, ReorderLevel, Discontinued) VALUES (@name,@sID,@cID,@price,@stok,@minstok,@dis)";
                    cmd.Parameters.AddWithValue("@name", tb_name.Text);
                    int sid = Convert.ToInt32(DGV_tedarikci.Rows[rowindex].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@sID", sid);
                    int cid = cb_kategoriAdi.SelectedIndex;
                    cmd.Parameters.AddWithValue("@cID", cid);
                    decimal price = Convert.ToDecimal(tb_price.Text);
                    cmd.Parameters.AddWithValue("@price", price);
                    int stok = Convert.ToInt16(tb_stock.Text);
                    cmd.Parameters.AddWithValue("@stok", stok);
                    int reord = Convert.ToInt16(tb_reOrderLevel.Text);
                    cmd.Parameters.AddWithValue("@minstok", reord);
                    bool dis = rb_satisEvet.Checked;
                    if (dis == true)
                    {
                        cmd.Parameters.AddWithValue("@dis", rb_satisEvet.Checked);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@dis", rb_satisHayir.Checked);
                    }
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ürün başarıyla eklenmiştir.", "Başarılı");

                    }
                    catch
                    {
                        MessageBox.Show("Ürün ekleme işleminde bir hata ile karşılaşıldı", "Hata");
                    }
                    finally
                    {
                        con.Close();
                    }
                    KategoriListele();
                    tb_ID.Text = tb_name.Text = tb_price.Text = tb_reOrderLevel.Text = tb_stock.Text = "";


                }
            }
            if (btn_ekle_duzenle.Text == "Düzenle")
            {
                if (!string.IsNullOrEmpty(tb_name.Text))
                {

                }
            }
        }
        private void DGV_tedarikci_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DGV_tedarikci.ClearSelection();
                rowindex2 = DGV_tedarikci.HitTest(e.X, e.Y).RowIndex;
                if (rowindex2 != -1)
                {
                    DGV_tedarikci.Rows[rowindex2].Selected = true;
                }
            }
        }
    }
}
