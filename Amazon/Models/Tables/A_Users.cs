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
        [DataType(DataType.Password)]   
        public string A_Password { get; set; }

        public DateTime A_Created {

            set {
                dynamic date = DateTime.Now.ToString("dddd,dd MMMM yyy:hh-mm-tt");
                if (value == null)
                {
                    this.A_Created = date;
                }
                else
                {
                    this.A_Created = value; 
                }
            

            }
            get
            {
                return this.A_Created;
            }
        } 

        [DefaultValue(0)]
        public string A_Isactive { get; set; }
    }
}
