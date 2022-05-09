using Amazon.Models.DataContext;
using Amazon.Models.Tables;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;

namespace Amazon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly DataContext db;
        public HomeController(DataContext _db)
        {
            db = _db;
        }
        [HttpGet("{id}")]
        public dynamic getproduct(int id)
        {
            string msg;
            A_Products p = new A_Products();
            var data = db.Products.Find(id);
           if(data != null)
            {
                if(data.A_Product_id != null)
                {
                    p.A_Product_id = data.A_Product_id;
                }
                
                if (data.A_Product_name != null)
                {
                    p.A_Product_name = data.A_Product_name;
                }
                else
                {
                    p.A_Product_name = "Not Available";
                }
                if (data.A_Category != null)
                {
                    p.A_Category = data.A_Category;
                }
                else
                {
                    p.A_Category = "Not Available";
                }
                if (data.A_Price != null)
                {
                    p.A_Price = data.A_Price;
                }
                else
                {
                    p.A_Price = 0;
                }
                if (data.A_Model_number != null)
                {
                    p.A_Model_number = data.A_Model_number;
                }
                else
                {
                    p.A_Model_number = "Not Available";
                }
                if (data.A_About != null)
                {
                    p.A_About = data.A_About;
                }
                else
                {
                    p.A_About = "Not Available";
                }
                if (data.A_Product_specification != null)
                {
                    p.A_Product_specification = data.A_Product_specification;
                }
                else
                {
                    p.A_Product_specification = "Not Available";
                }
                if (data.A_Tech_details != null)
                {
                    p.A_Tech_details = data.A_Tech_details;
                }
                else
                {
                    p.A_Tech_details = "Not Available";
                }
                if (data.A_Product_weight != null)
                {
                    p.A_Product_weight = data.A_Product_weight;
                }
                else
                {
                    p.A_Product_weight = "Not Available";
                }
                if (data.A_Product_dimensions != null)
                {
                    p.A_Product_dimensions = data.A_Product_dimensions;
                }
                else
                {
                    p.A_Product_dimensions = "Not Available";
                }
                if (data.A_Image != null)
                {
                    p.A_Image = data.A_Image;
                }
                else
                {
                    p.A_Image = "Not Available";
                }
                if (data.A_Varient != null)
                {
                    p.A_Varient = data.A_Varient;
                }
                else
                {
                    p.A_Varient = "Not Available";
                }
                if (data.A_Product_url != null)
                {
                    p.A_Product_url = data.A_Product_url;

                }
                else
                {
                    p.A_Product_url = "Not Available";
                }

               
                
            }
            else {
                msg = "data is not available";
                return msg;
            
            }
            var jsonproduct = JsonConvert.SerializeObject(p);





            return (jsonproduct);
                

            

            




        }
    }
}
