using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.ViewModel
{
    public class UserToursViewModel
    {
        public ObservableCollection<Tour> tours { get; set; } = new();

        FindTourService findTourService = new FindTourService();
        UserDBService userDBService = new UserDBService();
        public UserToursViewModel()
        {
            var user = userDBService.GetCurrentUSer();
            var ts = findTourService.GetUsersTour(user.TourId);
            tours = new ObservableCollection<Tour>(ts.Cast<Tour>());
        }
    }
}
