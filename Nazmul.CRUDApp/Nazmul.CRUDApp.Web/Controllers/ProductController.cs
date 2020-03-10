using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nazmul.CRUDApp.Web.Models;

namespace Nazmul.CRUDApp.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductDAL productDAL = new ProductDAL();
        public IActionResult Index()
        {
            List<ProductsInfo> productList = new List<ProductsInfo>();
            productList = productDAL.GetAllProduct().ToList();
            return View(productList);
        }
    }
}