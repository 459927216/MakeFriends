using Core.Service;
using System.Web.Mvc;

namespace MakingFriends.Controllers
{
    /// <summary>
    /// 插肩而过
    /// </summary>
    public class HomeController : Controller
    {

        public string Test()
        {
            var test = new Test();
            return test.Query();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}