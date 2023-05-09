using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class ParseUserName : IParseUserName
    {

        public bool Parse(string username)
        {
            if(username.Length == 0)
                return false;
            else
                return true;
        }
    }
}
