//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Data;
using System.Xml.Linq;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Caching;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.SessionState;
using System.Web.Security;
using System.Web.Profile;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Buiers
{
	public static class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

//INSTANT C# WARNING: Every field in a C# anonymous type initializer is immutable:
//ORIGINAL LINE: routes.MapRoute(name:="Default", url:="{controller}/{action}/{id}", defaults:= New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional})
			routes.MapRoute(name:"Default", url:"{controller}/{action}/{id}", defaults: new
			{
				controller = "Home",
				action = "Index",
				id = UrlParameter.Optional
			});
		}
	}
}