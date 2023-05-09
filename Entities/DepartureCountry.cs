using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    [Table ("DepartureCountries")]
    public class DepartureCountry : Country
    {
        public int Id { get; set; }
    }
}
