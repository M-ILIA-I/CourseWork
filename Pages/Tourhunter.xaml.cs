using CourseWork.Pages;
using CourseWork.ViewModel;

namespace CourseWork;

public partial class Tourhunter : ContentPage
{
    UserDBService us;
	public Tourhunter(FindToursViewModel vm, UserDBService US)
	{
		InitializeComponent();
		BindingContext = vm;
        us = US;
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
