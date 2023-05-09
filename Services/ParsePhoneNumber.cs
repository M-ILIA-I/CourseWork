using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CourseWork
{
    class ParsePhoneNumber : IParsePhoneNumber
    {

        public bool Parse(string number)
        {
            Regex regex = new Regex(@"^/+375(29|33)[0-9]{7}");
            return true;
        }
    }
}
