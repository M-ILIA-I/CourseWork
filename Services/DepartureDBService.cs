using CourseWork.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class DepartureDBService : IDepartureDBService
    {
        static SQLiteOpenFlags Flags =
        // open the database in read/write mode
        SQLite.SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
        SQLite.SQLiteOpenFlags.Create |
        // enable multi-threaded database access
        SQLite.SQLiteOpenFlags.SharedCache;

        static string dbPath = @"D:\Coursework\CourseWork\DB\DB.db";
        public IEnumerable<DepartureCountry> GetDepartureCountries()
        {
            SQLiteConnection db = new SQLiteConnection(dbPath, Flags);

            return from countries in db.Table<DepartureCountry>()
                   select countries;
        }

        public List<string> GetDepartureCapitals()
        {
            List<string> capitals = new List<string>();

            foreach (DepartureCountry dc in GetDepartureCountries())
            {
                capitals.Add(dc.Capital);
            }
            return capitals;
        }
    }
}
