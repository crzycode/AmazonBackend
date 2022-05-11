using System.ComponentModel.DataAnnotations;

namespace Amazon.Models.Tables
{
    public class A_Review
    {
        [Key]
        public int A_Review_id { get; set; }
        public int A_Like { get; set; } = 0;
        public int A_View { get; set; } = 0;

        public int A_Review_product_id { get; set; }

        public int A_Review_user_id { get; set; }
    }
}
