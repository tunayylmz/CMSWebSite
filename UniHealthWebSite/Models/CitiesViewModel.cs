using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniHealthWebSite.Models;

namespace UniHealthWebSite.Models
{
    public class CitiesViewModel
    {
        public IEnumerable<SelectListItem> Cities { get; set; }
        public IEnumerable<string> SelectedCities { get; set; }
    }
}