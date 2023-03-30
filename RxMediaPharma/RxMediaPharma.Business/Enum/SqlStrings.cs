namespace RxMediaPharma.Business.Enum
{
    public sealed class SqlStrings
    {
        public static string ilac_menu_list = "select * from ilac_menu_list";
        public static string ilac_detay = "select * from ilac_detay where ilac_form_id= {0}";
        public static string ilac_etkin_maddeler_list = "select * from ilac_etkin_maddeler_list where ilac_form_id= {0}";
        public static string ilac_ambalaj_resim = "select AMBALAJRESIM from ilac_ambalaj where ilac_form_id= {0}";
        public static string ilac_form_html_content = "select KUB from ilac_form where id = {0}";
        public static string ilac_form_favori = "select IS_FAVORITE from ilac_form where id = {0}";
        public static string ilac_form_favori_update = "update ilac_form set IS_FAVORITE = {1} where id = {0}";
    }
}
