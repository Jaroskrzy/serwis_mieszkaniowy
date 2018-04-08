using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serwis_mieszkaniowy.Models
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public virtual string OwnerName { get; set; }
        public virtual Address Address { get; set;} 

        

    }
}
