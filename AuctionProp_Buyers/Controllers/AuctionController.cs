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
    public class AuctionController : Controller
    {
        // GET: Auction
        public ActionResult Index()
        {
            return View();
        }
    }
}
