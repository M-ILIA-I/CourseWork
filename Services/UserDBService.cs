using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class UserDBService : IUserDBService
    {
        static SQLiteOpenFlags Flags =
        // open the database in read/write mode
        SQLite.SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
        SQLite.SQLiteOpenFlags.Create |
        // enable multi-threaded database access
        SQLite.SQLiteOpenFlags.SharedCache;

        static string dbPath = @"D:\Coursework\CourseWork\DB\DB.db";
        public IEnumerable<User> GetUsers() 
        {
            SQLiteConnection db = new SQLiteConnection(dbPath, Flags);
            return from users in db.Table<User>()
                   select users;
        }

        public List<string> GetEmails()
        {
            var users = from em in GetUsers()
                        select em;

            List<string> emails = new List<string>();
            foreach (var user in users)
            {
                emails.Add(user.UserEmail);
            }
            return emails;
        }
    }
}
