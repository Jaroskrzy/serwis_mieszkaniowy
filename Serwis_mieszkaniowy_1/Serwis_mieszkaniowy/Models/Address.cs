using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serwis_mieszkaniowy.Models
{
    public class Address : Owner
    {
        public int AddressId { get; set; }
        public virtual string AddressLocation { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual Property  Property { get; set; }
    }
}
