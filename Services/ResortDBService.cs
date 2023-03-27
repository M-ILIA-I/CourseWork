using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class ResortDBService
    {
        static SQLiteOpenFlags Flags =
        // open the database in read/write mode
        SQLite.SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
        SQLite.SQLiteOpenFlags.Create |
        // enable multi-threaded database access
        SQLite.SQLiteOpenFlags.SharedCache;

        static string dbPath = @"D:\Coursework\CourseWork\DB\DB.db";
        public IEnumerable<ResortCountry> GetResortCountries()
        {
            SQLiteConnection db = new SQLiteConnection(dbPath, Flags);

            return from countries in db.Table<ResortCountry>()
                   select countries;
        }

        public List<string> GetResortCapitals()
        {
            List<string> capitals = new List<string>();

            foreach (ResortCountry dc in GetResortCountries())
            {
                capitals.Add(dc.Capital);
            }
            return capitals;
        }
    }
}
