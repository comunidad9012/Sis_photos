using ApplicationsServices.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Filters
{
    public class ClientResponseFilter : ParameterResponse

    {
        public string? NameClient { get; set; }
        public string? NameLastClient { get; set; }
    }
}
