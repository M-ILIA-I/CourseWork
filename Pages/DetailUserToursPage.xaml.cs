using CourseWork.ViewModel;

namespace CourseWork.Pages;

public partial class DetailUserToursPage : ContentPage
{
    UserDBService us;
    FindTourService findTourService;
	public DetailUserToursPage(UserToursViewModel vm, UserDBService US, FindTourService fs)
	{
		InitializeComponent();
		BindingContext = vm;
        us = US;
        findTourService = fs;
	}
    private async void DeleteOrder(object sender, EventArgs e)
    {
        if (cv.SelectedItem != null)
        {
            string alert = await DisplayActionSheet("Are you shure?", "Yes", "No");
            if (alert == "Yes")
            {
                var user = us.GetCurrentUSer();
                if (user.TourId != null)
                {
                    var a = user.TourId.Split(' ').ToList();
                    var b = (cv.SelectedItem as Tour).Id.ToString();
                    a.Remove(b);
                    user.TourId = string.Join(" ",a);
                    var d = 0;
                    us.updateUser(user);
                    await Shell.Current.GoToAsync(nameof(UserPage));
                }
            }
        }
    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        cv.ItemsSource = findTourService.GetUsersTour(us.GetCurrentUSer().TourId);
    }
}