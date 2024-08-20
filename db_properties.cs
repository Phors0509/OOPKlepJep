using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOP
{

    internal class DBCON
    {
        private static string USER = "phors";
        private static string PASSWORD = "123";
        private static string SERVER = "DESKTOP-OQQFRMB";
        private static string DB = "phorsSu15";
        public static string db_address = $"SERVER={SERVER};" +
                                 $"DATABASE={DB};" +
                                 $"USER ID={USER};" +
                                 $"PASSWORD={PASSWORD}";
    }
    internal class db_properties : DBCON
    {
        public string student_all = "SELECT " +
                                "[student_code] as 'Code Berk'," +
                                "[first_name] as 'First Berk'," +
                                "[last_name] as 'Last Berk'," +
                                "[dob] as 'Date of Berk'," +
                                "[groups] as 'Group'," +
                                "[promote] as 'Promote'," +
                                "[field] as 'Field'," +
                                "[year_study] as 'Year Study'," +
                                "[phone] as 'Phone'," +
                                "[email] as 'Email'," +
                                "[address] as 'Address' " +
                                "FROM tbl_student";



        public string db_command;
        public string db_execute;
        public string class_all = "SELECT " +
                        "name as 'Class Name'," +
                        "floor as 'Floor'," +
                        "des as 'Description'" +
                        " FROM tbl_class;";



        public string POST_SAVE_DATA_TO_TABLE_CLASS = "INSERT INTO tbl_class ([name],[floor],[des]) " +
                                     "VALUES(@name,@floor,@des)";
    }
    internal class CLSItem
    {
        public static string SELECT_BRAND = "SELECT [brand_name] FROM " + "production.brands";
        public static string SELECT_CATEGORY = "SELECT [category_name] FROM " + "production.categories";

        public static string SAVE_CAT = "INSERT INTO production.categories (" +
                            "[category_name], [category_code], [category_des]) " +
                            "VALUES(@category_name, @category_code, @category_des)";



        public static string SAVE_BRAND = "INSERT INTO production.brand (" +
                                            "[brand_name]," + "[brand_code]," + "[brand_des]," +
                                            "VALUES(@brand_name," + "@brand_code,@brand_des)";




    }
    internal class CLSStock
    {
        public static string select_stock = "SELECT pp.product_name, " +
         "pc.category_name, " +
         "pb.brand_name, " +
         "pp.model_year, " +
         "pp.list_price, " +
         "ps.quantity " +
         "FROM production.products pp " +
         "JOIN production.stocks ps " +
         "ON pp.product_id = ps.product_id " +
         "JOIN production.categories pc " +
         "ON pc.category_id = pp.category_id " +
         "JOIN production.brands pb " +
         "ON pb.brand_id = pp.brand_id";

        public static string select_brand = "SELECT pp.product_name, " +
             "pc.category_name, " +
             "pb.brand_name, " +
             "pp.model_year, " +
            "pp.list_price, " +
             "ps.quantity " +
             "FROM production.products pp " +
             "JOIN production.stocks ps " +
             "ON pp.product_id = ps.product_id " +
             "JOIN production.categories pc " +
             "ON pc.category_id = pp.category_id " +
             "JOIN production.brands pb " +
             "ON pb.brand_id = pp.brand_id " +
             "WHERE pb.brand_name = @BrandName";

        public static string select_category = "SELECT pp.product_name, " +
        "pc.category_name, " +
        "pb.brand_name, " +
        "pp.model_year, " +
           "pp.list_price, " +

        "ps.quantity " +
        "FROM production.products pp " +
        "JOIN production.stocks ps " +
        "ON pp.product_id = ps.product_id " +
        "JOIN production.categories pc " +
        "ON pc.category_id = pp.category_id " +
        "JOIN production.brands pb " +
        "ON pb.brand_id = pp.brand_id " +
        "WHERE pc.category_name = @CategoryName";

        public static string select_brand_and_category = "SELECT pp.product_name, " +
           "pc.category_name, " +
           "pb.brand_name, " +
           "pp.model_year, " +
           "pp.list_price, " +
           "ps.quantity " +
           "FROM production.products pp " +
           "JOIN production.stocks ps " +
           "ON pp.product_id = ps.product_id " +
           "JOIN production.categories pc " +
           "ON pc.category_id = pp.category_id " +
           "JOIN production.brands pb " +
           "ON pb.brand_id = pp.brand_id " +
           "WHERE pb.brand_name = @BrandName AND pc.category_name = @CategoryName";

    }


}


