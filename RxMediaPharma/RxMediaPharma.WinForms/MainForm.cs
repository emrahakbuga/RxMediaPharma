using RxMediaPharma.Business.FormsBusiness;
using RxMediaPharma.Entity.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RxMediaPharma.WinForms
{
    public partial class MainForm : Form
    {
        private static MainForm singletonInstance;
        protected string dbPath = "";
        protected List<int> nextPrevList;
        protected int nextPrevCurrentIndex;

        public MainForm()
        {
            InitializeComponent();
            nextPrevList = new List<int>();
            nextPrevCurrentIndex = -1;
        }

        /// <summary>
        /// SinglePage Application Olarak İstendiginden Bu Sekilde Yapilmistir
        /// Uygulmama single instance yani tek pencere olarak calismalidir. Birden fazla uygulama calistiralamamalidir
        /// </summary>
        /// <returns></returns>
        public static MainForm GetInstance()
        {
            if (singletonInstance == null)
                singletonInstance = new MainForm();

            return singletonInstance;
        }

        private void RxMediaPharma_Load(object sender, EventArgs e)
        {
            productListBox.DisplayMember = "ILAC_ACIKLAMA";
            productListBox.ValueMember = "ILAC_FORM_ID";

            activeIngredientListView.Columns.Add("ETKIN MADDE", 127);
            activeIngredientListView.Columns.Add("MIKTAR", 61);
            activeIngredientListView.Columns.Add("BIRIM", 51);

            lblFavorite.Visible = false;
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dbPath = Path.GetFullPath(openFileDialog1.FileName.ToString());
                BindDataToProductList();
            }
        }

        /// <summary>
        /// Soldaki urun listesinin ustunde bir arama kutucugu bulunmaktadir ve urunlerin adi ile arama yapma imkani sunmaktadir. Aram sonuclari alttaki
        /// urun listesinde filtrelenmis olarak goruntulenmelidir.
        /// Arama kutucugu barkod ile de urunu bulabilmeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = productSearchBox.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
                BindDataToProductList();
            else
                productListBox.DataSource = MainFormBM.GetSearchProductList(dbPath, searchText);
        }


        private void BindDataToProductList()
        {
            productListBox.DataSource = MainFormBM.GetAllProductList(dbPath);
        }

        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           int productFormId = Convert.ToInt32(productListBox.SelectedValue);
            ProductDetailBind(productFormId);
            if (!nextPrevList.Contains(productFormId))
            {
                nextPrevList.Add(productFormId);
                nextPrevCurrentIndex = nextPrevList.Count - 1;
            }
        }

        private void ProductDetailBind(int productFormId)
        {
            ProductDetailDTO productDetail = MainFormBM.GetProductDetailById(dbPath, productFormId);
            label1.Text = productDetail.IlacAdi + " " + productDetail.Olcu;
            label2.Text = productDetail.Ambalaj;
            lblBarkod.Text = productDetail.Barkod;
            label16.Text = productDetail.Firma;
            label17.Text = productDetail.Fiyat.ToString() + " TL";
            label29.Text = "( " + productDetail.FiyatTarih + " )";
            label18.Text = productDetail.KamuFiyati.ToString() + " TL";
            label19.Text = productDetail.KamuOdenen.ToString() + " TL";
            label30.Text = "( " + productDetail.FiyatFark.ToString() + " TL FİYAT FARKI )";
            label20.Text = productDetail.DepocuFiyat.ToString() + " TL + KDV";
            label21.Text = productDetail.ImalatciFiyat.ToString() + " TL + KDV";
            label22.Text = "%8";                                           // DB' de KDV Alani Bulunamadi
            label23.Text = productDetail.JenerikOriginal;
            label24.Text = productDetail.SGKkodu;
            label25.Text = productDetail.ATCKodu;
            label26.Text = productDetail.Recete;
            label27.Text = productDetail.Barkod;

            lblFavorite.Visible = productDetail.Favori;
            btnFavorite.Image = (lblFavorite.Visible ? Properties.Resources.favorite_red : Properties.Resources.favorite);

            if (productDetail.Resim != null)
            {
                MemoryStream blobData = new MemoryStream(productDetail.Resim);
                productPictureBox.Image = Image.FromStream(blobData);
            }
            else
                productPictureBox.Image = null;

            BindProductActiveIngredientList(productFormId);
        }

        private void BindProductActiveIngredientList(int productFormId)
        {
            activeIngredientListView.Items.Clear();
            DataTable dt = MainFormBM.GetProductActiveIngredientList(dbPath, productFormId);
            foreach (DataRow row in dt.Rows)
            {
                string[] infos = { row["ETKINMADDE"].ToString(), row["MIKTAR"].ToString(), row["BIRIM"].ToString() };
                ListViewItem item = new ListViewItem(infos);
                activeIngredientListView.Items.Add(item);
            }
        }

        private void btnKUB_Click(object sender, EventArgs e)
        {
            if (productListBox.SelectedValue != null)
            {
                int productFormId = Convert.ToInt32(productListBox.SelectedValue);
                string htmlContent = MainFormBM.GetProductHtmlContent(dbPath, productFormId);
                PopupForm pForm = new PopupForm(htmlContent);
                pForm.Show();
            }
        }

        /// <summary>
        /// Ürünü Favorilere Ekler, Ürün Favori Olarak Ekliyse Çıkarır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (productListBox.SelectedValue != null)
            {
                int productFormId = Convert.ToInt32(productListBox.SelectedValue);
                lblFavorite.Visible = !(MainFormBM.IsFavoriteProduct(dbPath, productFormId));
                btnFavorite.Image = (lblFavorite.Visible ? Properties.Resources.favorite_red : Properties.Resources.favorite);
                MainFormBM.FavoriteProductUpdate(dbPath, productFormId, lblFavorite.Visible);
            }
        }

        private void btnBarkodCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblBarkod.Text))
                Clipboard.SetText(lblBarkod.Text);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nextPrevList.Count > 0 && nextPrevCurrentIndex + 1 < nextPrevList.Count)
            {
                int productFormId = nextPrevList[nextPrevCurrentIndex + 1];
                productListBox.SelectedValue = productFormId;
                nextPrevCurrentIndex++;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (nextPrevList.Count > 0 && nextPrevCurrentIndex > 0)
            {
                int productFormId = nextPrevList[nextPrevCurrentIndex - 1];
                productListBox.SelectedValue = productFormId;
                nextPrevCurrentIndex--;
            }
        }
    }
}
