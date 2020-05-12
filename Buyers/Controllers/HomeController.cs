//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using System.Web.SessionState;
using System.Web.Security;
using System.Web.Profile;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Buiers
{
	public class HomeController : System.Web.Mvc.Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewData("Message") = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewData("Message") = "Your contact page.";

			return View();
		}

		public ActionResult FAQ()
		{
			ViewData("Message") = "Your FAQ page.";

			return View();
		}

		public ActionResult Properties()
		{
			ViewData("Message") = "Your Properties page.";

			return View();
		}


	}

}