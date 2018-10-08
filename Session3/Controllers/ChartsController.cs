using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session3.Controllers
{
    public class ChartsController : Controller
    {
        // GET: Charts
        public ActionResult Index()
        {
            var countries = new ChartViewModel
            {
                CountryVisitses = new List<CountryVisits>
                {
                    new CountryVisits
                    {
                       country = "Malaysia",
                       visits = 3200
                    },
                    new CountryVisits
                    {
                        country = "Indonesia",
                        visits = 7200
                    },
                    new CountryVisits
                    {
                        country = "China",
                        visits = 3300
                    }
                }
            };
            return View(countries);
        }
    }

    public class ChartViewModel
    {
        public List<CountryVisits> CountryVisitses { get; set; }
    }

    public class CountryVisits
    {
        public string country { get; set; }
        public int visits { get; set; }
    }
}