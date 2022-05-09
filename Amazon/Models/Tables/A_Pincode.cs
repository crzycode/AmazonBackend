using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Amazon.Models.Tables
{
    
    public class A_Pincode
    {
        [Key]
        public int A_UID { get; set; }
        public int A_Zipcode { get; set; }
        public string A_Country { get; set; }
        public string A_State { get; set; }
        public string A_City { get; set; }
        public string A_Area { get; set; }
        public string A_District { get; set; }
        public int A_Phone_code { get; set; }
        public string A_Iso2 { get; set; }
        public int A_Isactive { get; set; } = 1;
    }
}
