using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Services
{
    public interface IDepartureDBService
    {
        public IEnumerable<DepartureCountry> GetDepartureCountries();
        public List<string> GetDepartureCapitals();
    }
}
