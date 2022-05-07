using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Amazon.Models.Tables
{
    public class A_Users
    {


        [Key]
        public int A_User_id { get; set; }
        public string A_Name { get; set; }
        public string A_Email_add { get; set; }
      
        public Int64 A_Phone_number { get; set; } = 0;

        [DataType(DataType.Password)]
        public string A_Password { get; set; }

        public string A_Created { get; set; } = DateTime.Now.ToString("dddd,dd MMMM yyy:hh-mm-tt");

        
        public int A_Isactive { get; set; } = 1;    
    }
}
