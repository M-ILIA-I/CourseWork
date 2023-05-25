
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.ViewModel
{
    public partial class UserPageViewModel: ObservableObject
    {
        public string name { get; set; } = Preferences.Get("UserName", null);
        public string email { get; set; } = Preferences.Get("UserEmail", null);
        public string phoneNumber { get; set; } = Preferences.Get("UserPhoneNumber", null);

        User currentUser = new();
        public UserPageViewModel()
        {
            UserDBService us = new UserDBService();
            currentUser = us.GetCurrentUSer();
        }
    }
}
