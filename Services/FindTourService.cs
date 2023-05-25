using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class FindTourService
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

        public ObservableCollection<Tour> GetTours()
        {
            SQLiteConnection db = new SQLiteConnection(dbPath, Flags);
            if (db.GetTableInfo("Tour").Count == 0)
            {
                db.CreateTable<Tour>();
            }
            var a = from tours in db.Table<Tour>()
                    select tours;
            ObservableCollection<Tour> toursList = new ();
            foreach (var t in a)
            {
                toursList.Add(t);
            }
            return toursList;
        }
        public List<Tour> GetFilteredTours(string departureCountry, string arrivingCountry)
        {
            ObservableCollection<Tour> a = GetTours();
            var ts = from t in a
                     where t.departureCountry == departureCountry && t.arrivingCountry == arrivingCountry
                     select t;
            List<Tour> toursList = new();
            foreach (var t in ts)
            {
                toursList.Add(t);
            }
            return toursList;
        }

        public int GetToursCount()
        {
            SQLiteConnection db = new SQLiteConnection(dbPath, Flags);
            if (db.GetTableInfo("Tour").Count == 0)
            {
                db.CreateTable<Tour>();
            }

            var a = db.Table<Tour>().Count();
            return a;
        }

        public IEnumerable<Tour> GetUsersTour(string numbers)
        {
            if (numbers != null)
            {
                var a = numbers.Split(' ').ToList();
                var tours = GetTours();
                var ft = from t in tours
                         where a.Contains(t.Id.ToString())
                         select t;
                return ft;
            }
            else { return Enumerable.Empty<Tour>(); }
        }

        public IEnumerable<string> GetDepartureCountries()
        {
            var tours = GetTours();
            return from t in tours
                   select t.departureCountry;
        }
        public IEnumerable<string> GetArrivingCountries()
        {
            var tours = GetTours();
            return from t in tours
                   select t.arrivingCountry;
        }
    }
}
