using System.Collections.Generic;
using UniHealthWebSite.Models;

namespace UniHealthWebSite.Controllers
{
    internal class CMSEntitiesDBContext
    {
        public CMSEntitiesDBContext()
        {
        }

        public IEnumerable<CityName> Cities { get; internal set; }
    }
}