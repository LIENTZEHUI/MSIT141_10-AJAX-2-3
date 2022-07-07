using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MSIT141_10_AJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT141_10_AJAX.Controllers
{
    public class ApiController : Controller
    {
        private readonly DemoContext _context;
        private readonly IWebHostEnvironment _hostenvironment;
        public ApiController(DemoContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _hostenvironment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Index(Member user)
        {
            //System.Threading.Thread.Sleep(5000); //停止5秒鐘

            //return Content("Ajax, 你好!!","text/plain", System.Text.Encoding.UTF8);
            if (String.IsNullOrEmpty(user.Name))
            {
                user.Name = "無名氏";
            }
            return Content($"{user.Name}你好", "text/plain", System.Text.Encoding.UTF8);
        }


        //讀取所有城市的資料
        public IActionResult City()
        {
            var cities = _context.Addresses.Select(a => a.City).Distinct();
            return Json(cities);
        }

        //根據城市名稱讀出鄉鎮區的資料
        public IActionResult Districts(string city)
        {
            var districts = _context.Addresses.Where(a => a.City == city).Select(a => a.SiteId).Distinct();
            return Json(districts);
        }

        //根據鄉鎮區的資料讀出路名
        public IActionResult Roads(string district)
        {
            var roads = _context.Addresses.Where(a => a.SiteId == district).Select(a => a.Road);
            return Json(roads);
        }


    }
}
