using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MakingFriends.Controllers
{
    public class SearchController : Controller
    {

        /// <summary>
        /// 搜索条件
        /// </summary>
        /// <returns></returns>
        public ActionResult ConSearch() {

            return View();
        }

        /// <summary>
        /// 所搜结果列表
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }


    }
}