using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ski_Report.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Ski_Report.Controllers
{
    public class HomeController : Controller
    {
        String LocalizedName;
        String EnglishName;

        //only create one instance of HttpClient and share among other parts of web app
        private static readonly HttpClient client = new HttpClient();

        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public async Task Request()
        {
            var responseString = await client.GetStringAsync("http://dataservice.accuweather.com/locations/v1/cities/search?apikey=aCaULCU0f5iSrt1eNLa2KA9DDTZe5ySQ&q=Boulder");
            dynamic userLoc = JsonConvert.DeserializeObject(responseString);

            setLocalizedName((String)userLoc[0].LocalizedName);
            setEnglishName((String)userLoc[0].EnglishName);
        }

        [HttpPost]
        public ActionResult Subscribe(SubscribeModel model)
        {

            var getWeather = Request();
            getWeather.Wait();

            if (ModelState.IsValid)
            {
                //TODO: SubscribeUser(model.Email);
            }
            var vm = new SubscribeModel();
            vm.Email = model.Email;

            ViewBag.Email = model.Email;
            ViewBag.EnglishName = this.EnglishName;
            ViewBag.LocalizedName = this.LocalizedName;
            return View("UploadView");
        }

        public void setLocalizedName(String name)
        {
            this.LocalizedName = name;
        }

        public void setEnglishName(String name)
        {
            this.EnglishName = name;
        }
    }
}

