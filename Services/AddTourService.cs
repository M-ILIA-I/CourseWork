using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Services
{
    public class AddTourService
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

        public void AddTour(Tour tour)
        {
            SQLiteConnection db = new SQLiteConnection(dbPath, Flags);
            FindTourService fts = new();
            if (!fts.GetTours().ToList<Tour>().Contains(tour))
                db.Insert(tour);
        }
    }
}
