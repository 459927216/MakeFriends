using System.Web.Mvc;

namespace MakingFriends.Controllers
{
    /// <summary>
    /// 我
    /// </summary>
    public class MyController : Controller
    {
        /// <summary>
        /// 个人中心
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}