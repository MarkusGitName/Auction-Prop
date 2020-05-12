//====================================================================================================
//The Free Edition of Instant C# limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================

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
using System.ComponentModel.DataAnnotations;

namespace Buiers
{
	public class ExternalLoginConfirmationViewModel
	{
		[Required]
		[Display(Name="Email")]
		public string Email {get; set;}
	}

	public class ExternalLoginListViewModel
	{
		public string ReturnUrl {get; set;}
	}

	public class SendCodeViewModel
	{
		public string SelectedProvider {get; set;}
		public ICollection<System.Web.Mvc.SelectListItem> Providers {get; set;}
		public string ReturnUrl {get; set;}
		public bool RememberMe {get; set;}
	}

	public class VerifyCodeViewModel
	{
		[Required]
		public string Provider {get; set;}

		[Required]
		[Display(Name="Code")]
		public string Code {get; set;}

		public string ReturnUrl {get; set;}

		[Display(Name="Remember this browser?")]
		public bool RememberBrowser {get; set;}

		public bool RememberMe {get; set;}
	}

	public class ForgotViewModel
	{
		[Required]
		[Display(Name="Email")]
		public string Email {get; set;}
	}

	public class LoginViewModel
	{
		[Required]
		[Display(Name="Email")]
		[EmailAddress]
		public string Email {get; set;}

		[Required]
		[DataType(DataType.Password)]
		[Display(Name="Password")]
		public string Password {get; set;}

		[Display(Name="Remember me?")]
		public bool RememberMe {get; set;}
	}

	public class RegisterViewModel
	{
		[Required]
		[EmailAddress]
		[Display(Name="Email")]
		public string Email {get; set;}

		[Required]
		[StringLength(100, ErrorMessage="The {0} must be at least {2} characters long.", MinimumLength=6)]
		[DataType(DataType.Password)]
		[Display(Name="Password")]
		public string Password {get; set;}

		[DataType(DataType.Password)]
		[Display(Name="Confirm password")]
		[Compare("Password", ErrorMessage="The password and confirmation password do not match.")]
		public string ConfirmPassword {get; set;}
	}

	public class ResetPasswordViewModel
	{
		[Required]
		[EmailAddress]
		[Display(Name="Email")]
		public string Email {get; set;}

		[Required]
		[StringLength(100, ErrorMessage="The {0} must be at least {2} characters long.", MinimumLength=6)]
		[DataType(DataType.Password)]
		[Display(Name="Password")]
		public string Password {get; set;}

		[DataType(DataType.Password)]
		[Display(Name="Confirm password")]
		[Compare("Password", ErrorMessage="The password and confirmation password do not match.")]
		public string ConfirmPassword {get; set;}

		public string Code {get; set;}
	}

	public class ForgotPasswordViewModel
	{

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
