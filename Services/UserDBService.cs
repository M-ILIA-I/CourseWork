using Microsoft.VisualBasic.FileIO;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class UserDBService : IUserDBService
    {
        static SQLiteOpenFlags Flags =
        // open the database in read/write mode
        SQLite.SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
        SQLite.SQLiteOpenFlags.Create |
        // enable multi-threaded database access
        SQLite.SQLiteOpenFlags.SharedCache;

        //static string dbPath = @"D:\Coursework\CourseWork\DB\DB.db";
        static string dbPath = Path.Combine(Path.GetTempPath(), "DB.db");
        public IEnumerable<User> GetUsers() 
        {
            SQLiteConnection db = new SQLiteConnection(dbPath, Flags);
            List<User> lu = new List<User>();
            if (db.GetTableInfo("User").Count == 0)
            {
                db.CreateTable<User>();
            }
            var a = from users in db.Table<User>()
                    select users;
            
            return a.ToList();
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

        public void updateUser(User user)
        {
            SQLiteConnection db = new SQLiteConnection(dbPath, Flags);
            if (user != null)
            {
                db.Update(user);
            }
        }

        public User GetCurrentUSer()
        {
            var a = GetUsers();
            foreach(var b in a)
            {
                if (b.UserEmail == Preferences.Get("UserEmail", null))
                    return b;
                else if (Preferences.Get("UserEmail", null) == null)
                    return null;
            }
            return null;
        }

        public void AddUser(User user)
        {
            SQLiteConnection db = new SQLiteConnection(dbPath, Flags);
            db.Insert(user);
        }
        
        public void deleteData()
        {
            var a = GetCurrentUSer();
            string b = "";
            a.TourId = b;
            updateUser(a);
        }
    }
}
