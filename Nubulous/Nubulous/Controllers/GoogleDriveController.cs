using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace Nubulous.Controllers
{
    public class GoogleDriveController : Controller
    {
        // GET: GoogleDrive
        public ActionResult Index()
        {
            return View();
        }
    }
}