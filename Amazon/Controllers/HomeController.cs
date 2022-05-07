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
            A_Products p = new A_Products();
            var data = db.Products.Find(id);
            dynamic image = data.A_Image;
            dynamic[] imagelist = image.Split('|');
          
            
             p.A_Product_id = data.A_Product_id;
            p.A_Product_name = data.A_Product_name;
            p.A_Category = data.A_Category;
            p.A_Price = data.A_Price;
            p.A_Model_number = data.A_Model_number;
            p.A_About = data.A_About;
            p.A_Product_specification = data.A_Product_specification;
            p.A_Tech_details = data.A_Tech_details;
            p.A_Product_weight = data.A_Product_weight;
            p.A_Product_dimensions = data.A_Product_dimensions;
            p.A_Image = imagelist[0];
            p.A_Varient = data.A_Varient;
            p.A_Product_url = data.A_Product_url;
        
       

            var jsonproduct = JsonConvert.SerializeObject(p);
            var jsonimage = JsonConvert.SerializeObject(imagelist);

            dynamic[] list = {
                 jsonproduct,
                 jsonimage


            };
            var productdata = JsonConvert.SerializeObject(list);
            return (productdata);
                

            

            




        }
    }
}
