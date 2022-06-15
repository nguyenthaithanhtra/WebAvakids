using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using avaweb.Models;

namespace avaweb.Controllers
{
    public class webavaController : Controller
    {
        public IActionResult Index()
        {
            var productModel = new ProductModel();
            
            ViewBag.Hide = "Đồ chơi";
            ViewBag.Hidehu = "Đồ chơi Lego";

           

            //var Product = new Product();
            return View(productModel);
           
        }
        public IActionResult Sanpham(int Page=1 )
        {
            
            ViewBag.Hide = "Đồ chơi";
            ViewBag.Hidehu = "Đồ chơi Lego";

            ViewBag.Page = Page;
            return View();
        }
     
    }
   

}

