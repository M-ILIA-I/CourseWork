using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    [Table ("ResortCountries")]
    public class ResortCountry
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Capital { get; set; }
    }
}
