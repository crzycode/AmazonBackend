using System.ComponentModel.DataAnnotations;

namespace Amazon.Models.Tables
{
    public class A_Comment
    {
        [Key]
        public int A_Comment_id { get; set; }
        public string A_Comments { get; set; }
        public int A_Comment_user_id { get; set; }
        public int A_Comment_Product_id { get; set; }


    }
}
