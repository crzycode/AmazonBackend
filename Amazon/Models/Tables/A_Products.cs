using System.ComponentModel.DataAnnotations;

namespace Amazon.Models.Tables
{
    public class A_Products
    {
        [Key]
        public int A_Product_id { get; set; }
        public string A_Product_name { get; set; }
        public string A_Category { get; set; }
        public double A_Price { get; set; }
        public string A_Quantity { get; set; }
        public string A_Model_number { get; set; }
        public string A_About { get; set; }
        public string A_Product_specification { get; set; }
        public string A_Tech_details { get; set; }
        public string A_Product_weight { get; set; }
        public string A_Product_dimensions { get; set; }
        public string A_Image { get; set; }
        public string A_Varient { get; set; }
        public string A_Product_url { get; set; }
        public int A_Total_like { get; set; }
        public int A_Total_view { get; set; }

    }
}
