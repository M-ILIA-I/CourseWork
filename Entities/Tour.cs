using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    [Table ("Tour")]
    public class Tour
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string departureDate { get; set; }
        public string arrivingDate { get; set; }
        public int peopleQuantity { get; set; }
        public string departureCountry { get; set; }
        public string arrivingCountry { get; set; }
        public string transport { get; set; }
        public string price { get; set; }
        public Tour()
        { }
        
    }
}
