using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using adminApp.Models;
using System.Net.Http;
using Nancy.Json;

namespace adminApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }
        public async Task<ActionResult> Gender()
        {
            HttpClient client = new HttpClient();
            string json1 = await client.GetStringAsync("http://springdevops:8080/genderMongo");
            Gender[] genderList = new JavaScriptSerializer().Deserialize<Gender[]>(json1);
            ViewBag.genders = new List<Gender>();
            ViewBag.genders.Add(genderList[0]);
            ViewBag.genders.Add(genderList[1]);


            return View();
        }

        public async Task<ActionResult> Age()
        {
            HttpClient client = new HttpClient();
            string json2 = await client.GetStringAsync("http://springdevops:8080/ageMongo");
            Age[] ageList = new JavaScriptSerializer().Deserialize<Age[]>(json2);
            ViewBag.ages = new List<Age>();
            ViewBag.ages.Add(ageList[0]);
            ViewBag.ages.Add(ageList[1]);
            ViewBag.ages.Add(ageList[2]);
            ViewBag.ages.Add(ageList[3]);
            ViewBag.ages.Add(ageList[4]);
            ViewBag.ages.Add(ageList[5]);

            return View();
        }

        public async Task<ActionResult> Count()
        {
            HttpClient client = new HttpClient();
            string json2 = await client.GetStringAsync("http://springdevops:8080/countMongo");
            Count[] countList = new JavaScriptSerializer().Deserialize<Count[]>(json2);

            ViewBag.counts = new List<Count>();
            ViewBag.counts.Add(countList[0]);
            ViewBag.counts.Add(countList[1]);
            ViewBag.counts.Add(countList[2]);
            ViewBag.counts.Add(countList[3]);
            ViewBag.counts.Add(countList[4]);
            return View();
        }

        public async Task<ActionResult> Top()
        {
            HttpClient client = new HttpClient();
            string json2 = await client.GetStringAsync("http://springdevops:8080/topMongo");
            Top[] topList = new JavaScriptSerializer().Deserialize<Top[]>(json2);

            ViewBag.tops = new List<Top>();
            ViewBag.tops.Add(topList[0]);
            ViewBag.tops.Add(topList[1]);
            ViewBag.tops.Add(topList[2]);
            ViewBag.tops.Add(topList[3]);
            ViewBag.tops.Add(topList[4]);
            return View();
        }
    }
}
