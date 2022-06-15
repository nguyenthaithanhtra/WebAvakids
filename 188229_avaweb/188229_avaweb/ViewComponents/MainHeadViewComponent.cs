using avaweb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _188229_avaweb.ViewComponents
{
    public class MainHeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)

        {
            var productmodel = new ProductModel();
            int i = 0;
            while (true)
            {
                if (i >= 7)
                {
                    return Content("không có sản phẩm" + id);
                }
                else if (productmodel.ProductMain[i].ProductID == id) {
                    return View(productmodel.ProductMain[i]);
                }
                i++;

            }
            }
            

        }
       
    
    public class TitleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            var productmodel = new ProductModel();
            int i = 0;
            while (true)
            {
                if (i >= 7)
                {
                    return Content("không có sản phẩm" + id);
                }
                else if (productmodel.ProductMain[i].ProductID == id)
                {
                    return View(productmodel.ProductMain[i]);


                }
                i++;

            }

        }

    }
    public class OutstandingViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            int i = 0;
            var productmodel = new ProductModel();
            while (true)
            {
                if (i >= 7)
                {
                    return Content("không có sản phẩm" + id);
                }
                else if (productmodel.ProductMain[i].ProductID == id)
                {
                    return View(productmodel.ProductMain[i]);
                }
                i++;
            }
        }

    }
    public class ManualViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            var productmodel = new ProductModel();

            int i = 0;
            while (true)

            {
                if (i >= 7)
                {
                    return Content("không có sản phẩm" + id);
                }
                else if (productmodel.ProductMain[i].ProductID == id)
                {
                    return View(productmodel.ProductMain[i]);
                }
                i++;
            }
        }

    }
    public class OtherProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            var productmodel = new ProductModel();

            int i = 0;
            while (true)

            {
                if (i >= 7)
                {
                    return Content("không có sản phẩm" + id);
                }
                else if (productmodel.ProductMain[i].ProductID == id)
                {
                    return View(productmodel.ProductMain[i]);
                }
                i++;
            }
        }

    }
    public class DetailsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            var productmodel = new ProductModel();

            int i = 0;
            while (true)

            {
                if (i >= 7)
                {
                    return Content("không có sản phẩm" + id);
                }
                else if (productmodel.ProductMain[i].ProductID == id)
                {
                    return View(productmodel.ProductMain[i]);
                }
                i++;
            }
        }

    }
    public class TitleProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            var productmodel = new ProductModel();

            int i = 0;
            while (true)

            {
                if (i >= 7)
                {
                    return Content("không có sản phẩm" + id);
                }
                else if (productmodel.ProductMain[i].ProductID == id)
                {
                    return View(productmodel.ProductMain[i]);
                }
                i++;
            }
        }

    }
    public class CommentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            var productmodel = new ProductModel();

            int i = 0;
            while (true)

            {
                if (i >= 7)
                {
                    return Content("không có sản phẩm" + id);
                }
                else if (productmodel.ProductMain[i].ProductID == id)
                {
                    return View(productmodel.ProductMain[i]);
                }
                i++;
            }
        }

    }

}


