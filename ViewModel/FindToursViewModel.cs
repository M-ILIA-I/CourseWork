using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.ViewModel
{
    public partial class FindToursViewModel : ObservableObject
    {
        //[ObservableProperty]
        public ObservableCollection<Tour> tours { get; set; } = new();
        public ObservableCollection<string> DepartureCountries { get; set; }
        public ObservableCollection<string> ArrivingCountries { get; set; }


        FindTourService findTourService = new FindTourService();
        public FindToursViewModel()
        {
            
            DepartureCountries = new ObservableCollection<string>(findTourService.GetDepartureCountries().ToHashSet());
            ArrivingCountries = new ObservableCollection<string>(findTourService.GetArrivingCountries().ToHashSet());
            var data = findTourService.GetTours();
            tours.Clear();
            foreach (Tour tour in data)
            {
                tours.Add(tour);
            }
        }
    }
}
