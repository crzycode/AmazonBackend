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
    public class UsersController : ControllerBase
    {

        private readonly DataContext db;
        public UsersController(DataContext _db)
        {
            db = _db;
        }
        [HttpPost]
        public dynamic addusers(A_Users u)
        {
            db.users.Add(u);
            db.SaveChanges();
            return "success";
        }
        [HttpGet]
        public dynamic getusers()
        {
            var data = db.users.ToList();
            var json = JsonConvert.SerializeObject(data);

            return json;
        }
    }
}
