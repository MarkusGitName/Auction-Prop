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

using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Buiers
{
	[Authorize]
	public class ManageController : Controller
	{
		public ManageController()
		{
		}

		private ApplicationSignInManager _signInManager;
		private ApplicationUserManager _userManager;

		public ManageController(ApplicationUserManager appUserManager, ApplicationSignInManager appSignInManager)
		{
			UserManager = appUserManager;
			SignInManager = appSignInManager;
		}

		public ApplicationSignInManager SignInManager
		{
			get
			{
				return (_signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>());
			}
			private set
			{
				_signInManager = value;
			}
		}

		public ApplicationUserManager UserManager
		{
			get
			{
				return (_userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>());
			}
			private set
			{
				_userManager = value;
			}
		}

		//
		// GET: /Manage/Index
		public async Task<ActionResult> Index(ManageMessageId? message)
		{
			ViewData["StatusMessage"] = (message == ManageMessageId.ChangePasswordSuccess) ? "Your password has been changed." : ((message == ManageMessageId.SetPasswordSuccess) ? "Your password has been set." : ((message == ManageMessageId.SetTwoFactorSuccess) ? "Your two-factor authentication provider has been set." : ((message == ManageMessageId.Error) ? "An error has occurred." : ((message == ManageMessageId.AddPhoneSuccess) ? "Your phone number was added." : ((message == ManageMessageId.RemovePhoneSuccess) ? "Your phone number was removed." : "")))));

			var userId = User.Identity.GetUserId();
			var model = new IndexViewModel()
			{
				HasPassword = HasPassword(),
				PhoneNumber = await UserManager.GetPhoneNumberAsync(userId),
				TwoFactor = await UserManager.GetTwoFactorEnabledAsync(userId),
				Logins = await UserManager.GetLoginsAsync(userId),
				BrowserRemembered = await AuthenticationManager.TwoFactorBrowserRememberedAsync(userId)
			};
			return View(model);
		}

		//
		// POST: /Manage/RemoveLogin
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> RemoveLogin(string loginProvider, string providerKey)
		{
			ManageMessageId? message = null;
			var result = await UserManager.RemoveLoginAsync(User.Identity.GetUserId(), new UserLoginInfo(loginProvider, providerKey));
			if (result.Succeeded)
			{
				var userInfo = await UserManager.FindByIdAsync(User.Identity.GetUserId());
				if (userInfo != null)
				{
					await SignInManager.SignInAsync(userInfo, isPersistent:false, rememberBrowser:false);
				}
				message = ManageMessageId.RemoveLoginSuccess;
			}
			else
			{
				message = ManageMessageId.Error;
			}
			return RedirectToAction("ManageLogins", new {message});
		}

		//
		// GET: /Manage/AddPhoneNumber
		public ActionResult AddPhoneNumber()
		{
			return View();
		}

		//
		// POST: /Manage/AddPhoneNumber
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> AddPhoneNumber(AddPhoneNumberViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}
			// Generate the token and send it
			var code = await UserManager.GenerateChangePhoneNumberTokenAsync(User.Identity.GetUserId(), model.Number);
			if (UserManager.SmsService != null)
			{
				var message = new IdentityMessage()
				{
					Destination = model.Number,
					Body = "Your security code is: " + Convert.ToString(code)
				};
				await UserManager.SmsService.SendAsync(message);
			}
//INSTANT C# WARNING: Every field in a C# anonymous type initializer is immutable:
//ORIGINAL LINE: Return RedirectToAction("VerifyPhoneNumber", New With { .PhoneNumber = model.Number })
			return RedirectToAction("VerifyPhoneNumber", new {PhoneNumber = model.Number});
		}

		//
		// POST: /Manage/EnableTwoFactorAuthentication
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> EnableTwoFactorAuthentication()
		{
			await UserManager.SetTwoFactorEnabledAsync(User.Identity.GetUserId(), true);
			var userInfo = await UserManager.FindByIdAsync(User.Identity.GetUserId());
			if (userInfo != null)
			{
				await SignInManager.SignInAsync(userInfo, isPersistent:false, rememberBrowser:false);
			}
			return RedirectToAction("Index", "Manage");
		}

		//
		// POST: /Manage/DisableTwoFactorAuthentication
		[HttpPost]
		[ValidateAntiForgeryToken]

//====================================================================================================
//End of the allowed output for the Free Edition of Instant C#.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-instant-csharp.html
//====================================================================================================
