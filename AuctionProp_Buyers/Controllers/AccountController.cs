using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using AuctionProp_Buyers.Models;
using Newtonsoft.Json;

namespace AuctionProp_Buyers.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> LogIn()
        {
            return View();
        }


        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async void Register(RegisterBindingModel model)
        {
            string ResponseString = "";
            HttpWebResponse response = null;
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://localhost:44381/api/Account/Register");
                request.Accept = "application/json"; //"application/xml"; 
                request.Method = "POST";

                JavaScriptSerializer jss = new JavaScriptSerializer();
                // serialize into json string 
                var myContent = jss.Serialize(model);

                var data = Encoding.ASCII.GetBytes(myContent);

                request.ContentType = "application/json";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                response = (HttpWebResponse)request.GetResponse();

                ResponseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    response = (HttpWebResponse)ex.Response;
                    ResponseString = "Some error occured: " + response.StatusCode.ToString();
                }
                else
                {
                    ResponseString = "Some error occured: " + ex.Status.ToString();
                }
            }
            if (response.StatusCode == HttpStatusCode.OK)
            {
                
            }
            else {
                

            }

            
        }


    }
}
