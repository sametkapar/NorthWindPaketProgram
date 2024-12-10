namespace NorthWindLoginScreen
{
    partial class UrunIslemleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV_Urun = new System.Windows.Forms.DataGridView();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_satisEvet = new System.Windows.Forms.RadioButton();
            this.rb_satisHayir = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_kategoriAdi = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_katEkle = new System.Windows.Forms.Button();
            this.DGV_tedarikci = new System.Windows.Forms.DataGridView();
            this.btn_ekle_duzenle = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_reOrderLevel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Urun)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_tedarikci)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_ekle_duzenle);
            this.groupBox1.Controls.Add(this.btn_katEkle);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cb_kategoriAdi);
            this.groupBox1.Controls.Add(this.rb_satisHayir);
            this.groupBox1.Controls.Add(this.rb_satisEvet);
            this.groupBox1.Controls.Add(this.tb_reOrderLevel);
            this.groupBox1.Controls.Add(this.tb_stock);
            this.groupBox1.Controls.Add(this.tb_price);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1069, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DGV_Urun);
            this.groupBox2.Location = new System.Drawing.Point(12, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1069, 369);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Listesi";
            // 
            // DGV_Urun
            // 
            this.DGV_Urun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Urun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Urun.Location = new System.Drawing.Point(3, 18);
            this.DGV_Urun.Name = "DGV_Urun";
            this.DGV_Urun.RowHeadersWidth = 51;
            this.DGV_Urun.RowTemplate.Height = 24;
            this.DGV_Urun.Size = new System.Drawing.Size(1063, 348);
            this.DGV_Urun.TabIndex = 0;
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Location = new System.Drawing.Point(127, 21);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(209, 22);
            this.tb_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(127, 57);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(209, 22);
            this.tb_name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Fiyatı:";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(127, 93);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(209, 22);
            this.tb_price.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stok Miktarı:";
            // 
            // tb_stock
            // 
            this.tb_stock.Location = new System.Drawing.Point(127, 129);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(209, 22);
            this.tb_stock.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Satışta mı:";
            // 
            // rb_satisEvet
            // 
            this.rb_satisEvet.AutoSize = true;
            this.rb_satisEvet.Location = new System.Drawing.Point(148, 202);
            this.rb_satisEvet.Name = "rb_satisEvet";
            this.rb_satisEvet.Size = new System.Drawing.Size(55, 20);
            this.rb_satisEvet.TabIndex = 2;
            this.rb_satisEvet.TabStop = true;
            this.rb_satisEvet.Text = "Evet";
            this.rb_satisEvet.UseVisualStyleBackColor = true;
            // 
            // rb_satisHayir
            // 
            this.rb_satisHayir.AutoSize = true;
            this.rb_satisHayir.Location = new System.Drawing.Point(254, 202);
            this.rb_satisHayir.Name = "rb_satisHayir";
            this.rb_satisHayir.Size = new System.Drawing.Size(60, 20);
            this.rb_satisHayir.TabIndex = 2;
            this.rb_satisHayir.TabStop = true;
            this.rb_satisHayir.Text = "Hayır";
            this.rb_satisHayir.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kategori Adı:";
            // 
            // cb_kategoriAdi
            // 
            this.cb_kategoriAdi.FormattingEnabled = true;
            this.cb_kategoriAdi.Location = new System.Drawing.Point(458, 24);
            this.cb_kategoriAdi.Name = "cb_kategoriAdi";
            this.cb_kategoriAdi.Size = new System.Drawing.Size(150, 24);
            this.cb_kategoriAdi.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.DGV_tedarikci);
            this.groupBox3.Location = new System.Drawing.Point(702, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 204);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tedarikçi Bilgileri";
            // 
            // btn_katEkle
            // 
            this.btn_katEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_katEkle.Location = new System.Drawing.Point(614, 24);
            this.btn_katEkle.Name = "btn_katEkle";
            this.btn_katEkle.Size = new System.Drawing.Size(29, 24);
            this.btn_katEkle.TabIndex = 5;
            this.btn_katEkle.Text = "+";
            this.btn_katEkle.UseVisualStyleBackColor = true;
            this.btn_katEkle.Click += new System.EventHandler(this.btn_katEkle_Click);
            // 
            // DGV_tedarikci
            // 
            this.DGV_tedarikci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_tedarikci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_tedarikci.Location = new System.Drawing.Point(3, 18);
            this.DGV_tedarikci.Name = "DGV_tedarikci";
            this.DGV_tedarikci.RowHeadersWidth = 51;
            this.DGV_tedarikci.RowTemplate.Height = 24;
            this.DGV_tedarikci.Size = new System.Drawing.Size(355, 183);
            this.DGV_tedarikci.TabIndex = 0;
            // 
            // btn_ekle_duzenle
            // 
            this.btn_ekle_duzenle.Location = new System.Drawing.Point(544, 197);
            this.btn_ekle_duzenle.Name = "btn_ekle_duzenle";
            this.btn_ekle_duzenle.Size = new System.Drawing.Size(80, 25);
            this.btn_ekle_duzenle.TabIndex = 6;
            this.btn_ekle_duzenle.Text = "Ekle";
            this.btn_ekle_duzenle.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(458, 197);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(80, 25);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Temizle";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Min Stok Miktarı:";
            // 
            // tb_reOrderLevel
            // 
            this.tb_reOrderLevel.Enabled = false;
            this.tb_reOrderLevel.Location = new System.Drawing.Point(127, 165);
            this.tb_reOrderLevel.Name = "tb_reOrderLevel";
            this.tb_reOrderLevel.Size = new System.Drawing.Size(209, 22);
            this.tb_reOrderLevel.TabIndex = 1;
            // 
            // UrunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 643);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UrunIslemleri";
            this.Text = "Ürün İşlemleri";
            this.Load += new System.EventHandler(this.UrunIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Urun)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_tedarikci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Urun;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_kategoriAdi;
        private System.Windows.Forms.RadioButton rb_satisHayir;
        private System.Windows.Forms.RadioButton rb_satisEvet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_katEkle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGV_tedarikci;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_ekle_duzenle;
        private System.Windows.Forms.TextBox tb_reOrderLevel;
        private System.Windows.Forms.Label label7;
    }
}