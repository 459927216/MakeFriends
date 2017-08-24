using System.Web.Mvc;

namespace MakingFriends.Controllers
{
    /// <summary>
    /// 插肩而过
    /// </summary>
    public class PersonController : Controller
    {
        /// <summary>
        /// 插肩而过
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            return View();
        }

        /// <summary>
        /// 查看个人信息
        /// </summary>
        /// <returns></returns>
        public ActionResult Details() {

            return View();
        }

        /// <summary>
        /// 留言
        /// </summary>
        /// <returns></returns>
        public ActionResult LeaveMsg() {

            return View();
        }

        /// <summary>
        /// 情感文章
        /// </summary>
        /// <returns></returns>
        public ActionResult Article() {

            return View();
        }

    }
}