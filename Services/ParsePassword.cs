using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class ParsePassword : IParsePassword
    {

        public bool Parse(string password)
        {
            if (password.Equals(null))
                return false;
            
            else
                return true;
        }

    }
}
