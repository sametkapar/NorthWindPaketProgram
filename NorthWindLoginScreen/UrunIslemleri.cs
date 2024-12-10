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
            SqlDataReader reader =  cmd.ExecuteReader();
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
    }
}
