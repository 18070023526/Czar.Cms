using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sample01.Models;

namespace sample01.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var tests = new List<Test>();
            for(int i=0;i<12;i++)
            {
                var test = new Test { 工作证号 = "123", 姓名 = "账单",性别="男",登陆名="admin",办公电话 ="111111" };
                tests.Add(test);
            }
            return View(new TestViewMode { Tests=tests});
        }

        public IActionResult index2()
        {
            ViewBag.Message = "你好";
            ViewBag.Date = DateTime.Now;
            return View();
        }

        public IActionResult index3()
        {
            string message = "我是你爸爸！";
            return new ContentResult { Content = message };
        }

    }
}