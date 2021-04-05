using MVC_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Test.Controllers
{
    public class HomeController : Controller
    {
 

        public ActionResult Index()
        {
            DateTime date = DateTime.Now;
            //Student data = new Student();
            //List<Student> list = new List<Student>();
            //list.Add(new Student("1", "小明", 80));
            //list.Add(new Student("2", "小華", 70));
            //list.Add(new Student("3", "小英", 60));
            //list.Add(new Student("4", "小李", 50));
            //list.Add(new Student("5", "小張", 40));

            ViewBag.Date = date;
            //ViewBag.Student = data;
            //ViewBag.List = list;

            Student data = new Student("1","小名",80);

            return View(data);
        }
        public ActionResult Hello()
        {

            ViewData["Hello"] = "Hello World ";
            ViewBag.MVC = "Hello MVC";


            return View();

        }


    }
}