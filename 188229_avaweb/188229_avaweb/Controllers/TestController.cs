using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _188229_avaweb.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*// GET: TestController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TestController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TestController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TestController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TestController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TestController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
        //public string Stringout(int id, string firstname, string lastname )
        public string Stringout(int id, Test test )
        {
            
            return ($"hello ,my id :{id} -Myfulname:{test.firstname}{test.lastname}");
        }
        //hiển thị dang JSON
        public IActionResult Jsonout(int id, Test test)
        {


            var obj = new { Id = id, Test = test, };
            return Json(obj);
        }


    }
    public class Test
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
    }
}
