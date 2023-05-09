using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    internal class FindTourService
    {
        static SQLiteOpenFlags Flags =
        // open the database in read/write mode
        SQLite.SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
        SQLite.SQLiteOpenFlags.Create |
        // enable multi-threaded database access
        SQLite.SQLiteOpenFlags.SharedCache;

        static string dbPath = @"D:\Coursework\CourseWork\DB\DB.db";
        public List<Tour> GetTours(string departureCountry, string arrivingCountry)
        {
            SQLiteConnection db = new SQLiteConnection(dbPath, Flags);
            var a = from tours in db.Table<Tour>()
                    where (tours.departureCountry == departureCountry && tours.arrivingCountry == arrivingCountry)
                    select tours;
            List<Tour> toursList = new List<Tour>();
            foreach(var t in a)
            {
                toursList.Add(t);
            }
            return toursList;
        }




    }
}
