using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    interface IUserDBService
    {
        public IEnumerable<User> GetUsers();

        public List<string> GetEmails();
        
    }
}
