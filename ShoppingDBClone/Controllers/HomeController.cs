using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingDBClone.Models;

namespace ShoppingDB.Controllers
{
    public class HomeController : Controller
    {
        ShoppingContext db = new ShoppingContext();
        // GET: Shopping
        public ActionResult Index(int id = 1)
        {

            int activePage = id; //目前所在頁

            int pageRows = 3;   //每頁幾筆資料

            int totalRows = db.Clothings.Count();   //計算總筆數

            //計算Page頁數
            int Pages = 0;
            if (totalRows % pageRows == 0)
            {
                Pages = totalRows / pageRows;
            }
            else
            {
                Pages = (totalRows / pageRows) + 1;
            }

            int startRow = (activePage - 1) * pageRows;  //起始記錄Index

            List<Clothing> clothing = db.Clothings.OrderBy(x => x.Id).Skip(startRow).Take(pageRows).ToList();

            ViewData["Active"] = id;    //Active頁碼
            ViewData["Pages"] = Pages;  //頁數

            return View(clothing);
        }


        public ActionResult Men()
        {
            ViewData["Active"] = 2;
            ViewData["TopBanner"] = "MaleTopBanner.jpg";
            List<Clothing> clothing = db.Clothings.Where(x => x.Target == "male").ToList();
            return View(clothing);
        }

        public ActionResult Women()
        {
            ViewData["Active"] = 3;
            ViewData["TopBanner"] = "FemaleTopBanner.jpg";
            List<Clothing> clothing = db.Clothings.Where(x => x.Target == "female").ToList();
            return View(clothing);
        }

        public ActionResult Child()
        {
            ViewData["Active"] = 4;
            ViewData["TopBanner"] = "ChildTopBanner.jpg";
            List<Clothing> clothing = db.Clothings.Where(x => x.Target == "child").ToList();
            return View(clothing);
        }

        public ActionResult Shoes()
        {
            ViewData["Active"] = 5;
            ViewData["TopBanner"] = "ChildTopBanner.jpg";
            List<Shoes> shoes = db.Shoes.ToList();

            return View(shoes);
        }



    }
}