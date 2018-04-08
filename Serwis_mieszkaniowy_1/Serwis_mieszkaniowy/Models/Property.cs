using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serwis_mieszkaniowy.Models
{
    public class Property:Address
    {
        public int surface { get; set; }
        public int rent { get; set; }
        public int NumberOfBed { get; set; }
        public string Description { get; set; }
        public new virtual Address Address { get; set; }
        public new virtual Owner  Owner { get; set; }
        new public string OwnerName { get; set; }
        new public string AddressLocation { get; set; }
        public bool fridge { get; set; }
        public bool garden { get; set; }
        public bool balcon { get; set; }
        public enum Type { House,Flat};
    }
}
