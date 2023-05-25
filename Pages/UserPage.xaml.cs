using CourseWork.Pages;

namespace CourseWork;

public partial class UserPage : ContentPage
{
	public UserPage()
    { 
		InitializeComponent();
        if (Preferences.Get("UserEmail", null) == null)
        {
            Shell.Current.GoToAsync(nameof(Profile));
        }
        
    }

    private async void VisitProfile(object sender, EventArgs e)
    {
        if (Preferences.Get("UserEmail", null) == "ilyamir1@mail.ru")
            AdminButton.IsVisible = true;
        else
            AdminButton.IsVisible = false;
        await Shell.Current.GoToAsync(nameof(DetailUserPage));
    }

    private async void VisitSettings(object sender, EventArgs e)
    {
        if (Preferences.Get("UserEmail", null) == "ilyamir1@mail.ru")
            AdminButton.IsVisible = true;
        else
            AdminButton.IsVisible = false;
        await Shell.Current.GoToAsync(nameof(DetailSettingsPage));
    }

    private async void ShowTours(object sender, EventArgs e)
    {
        if (Preferences.Get("UserEmail", null) == "ilyamir1@mail.ru")
            AdminButton.IsVisible = true;
        else
            AdminButton.IsVisible = false;
        await Shell.Current.GoToAsync(nameof(DetailUserToursPage));
    }

    private void GoToAdminPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AdminPage));
    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        if (Preferences.Get("UserEmail", null) == "ilyamir1@mail.ru")
            AdminButton.IsVisible = true;
        else
            AdminButton.IsVisible = false;
    }
}