using CourseWork.ViewModel;

namespace CourseWork.Pages;

public partial class ToursPage : ContentPage
{

	UserDBService us = new();
    public ToursPage(FindTourService vm, UserDBService Us)
	{ 
		InitializeComponent();
		cv.ItemsSource = vm.GetFilteredTours(Preferences.Get("DC","none"), Preferences.Get("AC", "none"));
		us = Us;
	}

    private async void Lol(object sender, EventArgs e)
    {
       
        string alert = await DisplayActionSheet("Are you shure?", "Yes", "No");
        if (alert == "Yes")
        {
            var user = us.GetCurrentUSer();  
            if (user.TourId != null)
            {
                var a = user.TourId.Split(' ').ToList();
                var b = (cv.SelectedItem as Tour).Id.ToString();
                if (!a.Contains(b))
                {
                    user.TourId += b + " ";
                    us.updateUser(user);
                }
            }
            else
            {
                var b = (cv.SelectedItem as Tour).Id.ToString();
                user.TourId += b + " ";
                us.updateUser(user);
            }
        }
    }
}