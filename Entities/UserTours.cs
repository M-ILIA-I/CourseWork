using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class UserTours
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DepartureCountry { get; private set; }
        public string ArrivingCountry { get; private set; }
        public int Price { get; private set; }
    }
}
