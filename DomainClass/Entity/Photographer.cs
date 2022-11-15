using DomainClass.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClass.Entity
{
    public class Photographer : BaseEntityClass
    {
        public string? Name { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? QualityPhoto { get; set; }

        public string? SizePhoto { get; set; }

        public long UserRol { get; set; }



    }
}
