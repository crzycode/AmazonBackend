using Amazon.Models.DataContext;
using Amazon.Models.Tables;
using DurableTask.Core.Common;
using iText.StyledXmlParser.Jsoup.Nodes;
using LinqToTwitter.Common.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;

namespace Amazon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly DataContext db;
        public ReviewController(DataContext _db)
        {
            db = _db;
        }
        [HttpPost]

        
        public dynamic givelike(A_Review like)

        {
           


            var data = (from l in db.reviews
                        where (l.A_Review_product_id == like.A_Review_product_id)
                        &&
                        (l.A_Review_user_id == like.A_Review_user_id)
                        select l).ToList();
            /*var data = db.reviews.FromSqlRaw("select * from reviews where A_Review_product_id =" + like.A_Review_product_id + " and A_Review_user_id =" + like.A_Review_user_id + "").ToList();*/
            /* dynamic like = r.A_Like;*/

            if (data.Count == 0)
            {

                db.reviews.Add(like);
                db.SaveChanges();
                var totallike = db.reviews.Where(d => d.A_Review_product_id == like.A_Review_product_id).Sum(d => d.A_Like);
                var productdata = (from g in db.Products
                                   where (g.A_Product_id == like.A_Review_product_id)
                                   select g).ToList();

                A_Products p = new A_Products();
                productdata[0].A_Total_like = totallike;
                db.SaveChanges();
                return "data Added";
            }
            else
            {
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i].A_Like == 0)
                    {
                        data[i].A_Like = 1;
                        db.SaveChanges();
                        var totallike = db.reviews.Where(d => d.A_Review_product_id == like.A_Review_product_id).Sum(d => d.A_Like);
                        var productdata = (from g in db.Products
                                           where (g.A_Product_id == like.A_Review_product_id)
                                           select g).ToList();

                        A_Products p = new A_Products();
                        productdata[0].A_Total_like = totallike;
                        db.SaveChanges();
                        return "You have Liked";

                    }
                    if (data[i].A_Like == 1)
                    {
                        data[i].A_Like = 0;
                        db.SaveChanges();
                        var totallike = db.reviews.Where(d => d.A_Review_product_id == like.A_Review_product_id).Sum(d => d.A_Like);
                        var productdata = (from g in db.Products
                                           where (g.A_Product_id == like.A_Review_product_id)
                                           select g).ToList();

                        A_Products p = new A_Products();
                        productdata[0].A_Total_like = totallike;
                        db.SaveChanges();
                        return "You have Unliked";
                    }
                }

            }
            


            return "success";
          
        }
        [HttpPut]
        public dynamic views(A_Review view)
        {

            var data = (from l in db.reviews
                        where (l.A_Review_product_id == view.A_Review_product_id)
                        &&
                        (l.A_Review_user_id == view.A_Review_user_id)
                        select l).ToList();
            /*var data = db.reviews.FromSqlRaw("select * from reviews where A_Review_product_id ="+view.A_Review_product_id+" and A_Review_user_id ="+view.A_Review_user_id+"").ToList();*/
            if (data.Count == 0)
            {
                view.A_View = 1;
                db.reviews.Add(view);
                db.SaveChanges();

            }
            else
            {
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i].A_Review_user_id == view.A_Review_user_id && data[i].A_Review_product_id == view.A_Review_product_id)
                    {
                        data[i].A_View = data[i].A_View + 1;
                        db.SaveChanges();
                    }
                    else
                    {


                        view.A_View = 1;


                        db.reviews.Add(view);
                        db.SaveChanges();

                    }

                }


            }
            var totalview = db.reviews.Where(d => d.A_Review_product_id == view.A_Review_product_id).Sum(d => d.A_View);
            var productdata = (from g in db.Products
                               where (g.A_Product_id == view.A_Review_product_id)
                               select g).ToList();

            A_Products p = new A_Products();
            productdata[0].A_Total_view = totalview;
            db.SaveChanges();

            return "hey";
            
        }

    }
}


