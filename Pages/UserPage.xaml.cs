using CourseWork.Pages;

namespace CourseWork;

public partial class UserPage : ContentPage
{
	public UserPage()
	{
		InitializeComponent();
	}

    private async void VisitProfile(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(DetailUserPage));
    }

    private async void VisitSettings(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(DetailSettingsPage));
    }

    private async void ShowTours(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(DetailUserToursPage));
    }
}