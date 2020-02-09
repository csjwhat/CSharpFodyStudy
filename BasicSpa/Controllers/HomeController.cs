using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoLogger;
using forLoggerTest;

namespace BasicSpa.Controllers
{
    [Logger]
    public class HomeController : Controller
    {
        // ロガーの定義
        log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ActionResult Index()
        {
            logger.Debug("クラス内に書いたログ - HomeController Index");
            logger.Debug("コンストラクタの扱いを以下でテスト");

            TestConstructor testConstructor = new TestConstructor("pre test");

            return View();
        }

        public ActionResult About()
        {
            logger.Debug("クラス内に書いたログ - HomeController About");
            return View();
        }
    }
}