using System.Collections.Generic;
using UniHealthWebSite.Models;

namespace UniHealthWebSite.Controllers
{
    internal class CMSEntitiesDBContext
    {
        internal IEnumerable<CityName> cities;

        public CMSEntitiesDBContext()
        {
        }

        public IEnumerable<CityName> Cities { get; internal set; }
    }
}