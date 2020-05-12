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
using System.Web.Optimization;

namespace Buiers
{
	public static class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{

			bundles.Add((new ScriptBundle("~/bundles/jquery")).Include("~/Scripts/jquery-{version}.js"));

			bundles.Add((new ScriptBundle("~/bundles/jqueryval")).Include("~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
			bundles.Add((new ScriptBundle("~/bundles/modernizr")).Include("~/Scripts/modernizr-*"));

			bundles.Add((new ScriptBundle("~/bundles/bootstrap")).Include("~/Scripts/bootstrap.js"));

			bundles.Add((new StyleBundle("~/Content/css")).Include("~/Content/bootstrap.css", "~/Content/site.css"));
		}
	}


}