using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Tour
    {
        public int Id { get; set; }
        public string departureDate { get; set; }
        public string arrivingDate { get; set; } 
        public int peopleQuantity { get; set; }
        public string departureCountry { get; set; }
        public string arrivingCountry { get; set; }
        public string transport { get; set; }
        public int price { get; set; }
    }
}
