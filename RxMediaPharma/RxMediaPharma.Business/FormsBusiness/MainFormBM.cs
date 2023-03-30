using RxMediaPharma.Business.Enum;
using RxMediaPharma.Entity;
using RxMediaPharma.Entity.DTO;
using System;
using System.Data;
using System.Linq;

namespace RxMediaPharma.Business.FormsBusiness
{
    public class MainFormBM : BaseBM
    {
        public static DataTable GetAllProductList(string dbPath)
        {
            SQLiteDbManager dbManager = new SQLiteDbManager();
            var conn = dbManager.CreateConnection(dbPath);
            return SQLiteDbManager.ReadDataTableWithSqlStrings(conn, SqlStrings.ilac_menu_list);
        }

        public static DataTable GetSearchProductList(string dbPath, string searchText)
        {
            DataTable dt = GetAllProductList(dbPath);
            var searchList = (from item in dt.AsEnumerable()
                              where item.Field<string>("ILAC_ACIKLAMA").ToUpper().Contains(searchText.ToUpper())
                              || item.Field<string>("BARKOD").Contains(searchText.ToUpper())
                              select item).ToList();

            return (searchList.Any() ? searchList.CopyToDataTable() : null);
        }

        public static ProductDetailDTO GetProductDetailById(string dbPath, int productFormId)
        {
            SQLiteDbManager dbManager = new SQLiteDbManager();
            var conn = dbManager.CreateConnection(dbPath);
            DataTable productDetailDT = SQLiteDbManager.ReadDataTableWithSqlStrings(conn, String.Format(SqlStrings.ilac_detay, productFormId));

            ProductDetailDTO productDetail = new ProductDetailDTO();
            if (productDetailDT.Rows.Count > 0)
            {
                productDetail.Id = Convert.ToInt32(productDetailDT.Rows[0]["ID"]);
                productDetail.IlacAdi = productDetailDT.Rows[0].Field<string>("ILAC_ADI");
                productDetail.Olcu = productDetailDT.Rows[0].Field<string>("OLCU");
                productDetail.Ambalaj = productDetailDT.Rows[0].Field<string>("AMBALAJ");
                productDetail.Barkod = productDetailDT.Rows[0].Field<string>("BARKOD");
                productDetail.Firma = productDetailDT.Rows[0].Field<string>("FIRMA");
                productDetail.Fiyat = (!String.IsNullOrEmpty(productDetailDT.Rows[0]["FIYAT"].ToString()) ? Convert.ToDecimal(productDetailDT.Rows[0]["FIYAT"]) : (decimal?)null);
                productDetail.KamuFiyati = (!String.IsNullOrEmpty(productDetailDT.Rows[0]["KAMUFIYATI"].ToString()) ? Convert.ToDecimal(productDetailDT.Rows[0]["KAMUFIYATI"]) : (decimal?)null);
                productDetail.KamuOdenen = (!String.IsNullOrEmpty(productDetailDT.Rows[0]["KAMUODENEN"].ToString()) ? Convert.ToDecimal(productDetailDT.Rows[0]["KAMUODENEN"]) : (decimal?)null);
                productDetail.FiyatFark = (!String.IsNullOrEmpty(productDetailDT.Rows[0]["FIYAT_FARK"].ToString()) ? Convert.ToDecimal(productDetailDT.Rows[0]["FIYAT_FARK"]) : (decimal?)null);
                productDetail.DepocuFiyat = (!String.IsNullOrEmpty(productDetailDT.Rows[0]["DEPOCU"].ToString()) ? Convert.ToDecimal(productDetailDT.Rows[0]["DEPOCU"]) : (decimal?)null);
                productDetail.ImalatciFiyat = (!String.IsNullOrEmpty(productDetailDT.Rows[0]["IMALATCI"].ToString()) ? Convert.ToDecimal(productDetailDT.Rows[0]["IMALATCI"]) : (decimal?)null);
                productDetail.FiyatTarih = productDetailDT.Rows[0].Field<string>("FIYATTARIH");
                productDetail.JenerikOriginal = productDetailDT.Rows[0].Field<string>("JENERIKORIJINAL");
                productDetail.SGKkodu = productDetailDT.Rows[0].Field<string>("SGKETKINKODU");
                productDetail.ATCKodu = productDetailDT.Rows[0].Field<string>("ATCKODU");
                productDetail.Recete = productDetailDT.Rows[0].Field<string>("RECETE");
                productDetail.Favori = (!String.IsNullOrEmpty(productDetailDT.Rows[0]["IS_FAVORITE"].ToString()) ? Convert.ToBoolean(productDetailDT.Rows[0]["IS_FAVORITE"]) : false);
                productDetail.Resim = (!String.IsNullOrEmpty(productDetailDT.Rows[0]["AMBALAJRESIM"].ToString()) ? (byte[])productDetailDT.Rows[0]["AMBALAJRESIM"] : null);
            }
            return productDetail;
        }

        public static DataTable GetProductActiveIngredientList(string dbPath, int productFormId)
        {
            SQLiteDbManager dbManager = new SQLiteDbManager();
            var conn = dbManager.CreateConnection(dbPath);
            return SQLiteDbManager.ReadDataTableWithSqlStrings(conn, String.Format(SqlStrings.ilac_etkin_maddeler_list, productFormId));
        }

        public static string GetProductHtmlContent(string dbPath, int productFormId)
        {
            SQLiteDbManager dbManager = new SQLiteDbManager();
            var conn = dbManager.CreateConnection(dbPath);
            DataTable dt = SQLiteDbManager.ReadDataTableWithSqlStrings(conn, String.Format(SqlStrings.ilac_form_html_content, productFormId));

            string htmlContent = string.Empty;
            if (dt.Rows.Count > 0)
                htmlContent = dt.Rows[0].Field<string>("KUB");
            
            return htmlContent;
        }

        public static bool IsFavoriteProduct(string dbPath, int productFormId)
        {
            SQLiteDbManager dbManager = new SQLiteDbManager();
            var conn = dbManager.CreateConnection(dbPath);
            DataTable dt = SQLiteDbManager.ReadDataTableWithSqlStrings(conn, String.Format(SqlStrings.ilac_form_favori, productFormId));

            bool isfavorite = false;
            if (dt.Rows.Count > 0)
                isfavorite = (!String.IsNullOrEmpty(dt.Rows[0]["IS_FAVORITE"].ToString()) ? Convert.ToBoolean(dt.Rows[0]["IS_FAVORITE"]) : false);

            return isfavorite;
        }

        public static void FavoriteProductUpdate(string dbPath, int productFormId, bool isFavorite)
        {
            SQLiteDbManager dbManager = new SQLiteDbManager();
            var conn = dbManager.CreateConnection(dbPath);
            SQLiteDbManager.ReadDataTableWithSqlStrings(conn, String.Format(SqlStrings.ilac_form_favori_update, productFormId, Convert.ToByte( isFavorite)));
        }
    }
}
