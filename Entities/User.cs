using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    [Table("User")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserPassword { get; set; }    
        public string TourId { get; set; }
        public string IconPath { get; set; }
        
    }
}
