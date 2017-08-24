using System.Threading;
using System.Web.Mvc;

namespace MakingFriends.Controllers
{
    /// <summary>
    /// 消息
    /// </summary>
    public class MsgController : Controller
    {
        /// <summary>
        /// 聊天
        /// </summary>
        /// <returns></returns>
        public ActionResult Chat()
        {
            return View();
        }

        /// <summary>
        /// 通讯录
        /// </summary>
        /// <returns></returns>
        public ActionResult Book()
        {
            return View();
        }

        /// <summary>
        /// 通知
        /// </summary>
        /// <returns></returns>
        public ActionResult Notify()
        {
            return View();
        }
    }
}