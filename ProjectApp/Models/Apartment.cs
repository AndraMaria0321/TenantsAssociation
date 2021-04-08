using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WADproj.Models;

namespace ProjectWebApp.Models
{
    public class Apartment
    {
        public int ApartmenTId { get; set; }

        public int ApartmentNo { get; set; }

        public int UserId { get; set; }

        public int BuildingId { get; set; }

        public User User { get; set; }

        public Building Building { get; set; }

        public ICollection<Invoice> Invoice { get; set; }
    }
}
