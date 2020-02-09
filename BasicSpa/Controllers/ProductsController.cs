using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoLogger;

namespace BasicSpa.Controllers
{
    [Logger]
    public class ProductsController : Controller
    {
        // ロガーの定義
        log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // GET: Products
        public ActionResult Index()
        {
            logger.Debug("クラス内に書いたログ - Index");
            return View();
        }


        // GET: Products/NewItem
        public ActionResult NewItem()
        {
            logger.Debug("クラス内に書いたログ - NewItem");
            return View();
        }
    }
}