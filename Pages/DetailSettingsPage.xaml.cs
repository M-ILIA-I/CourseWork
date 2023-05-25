namespace CourseWork.Pages;

public partial class DetailSettingsPage : ContentPage
{
	public DetailSettingsPage()
	{
		InitializeComponent();
	}

    private void LogOut(object sender, EventArgs e)
    {
		Preferences.Set("UserEmail", null);
		Shell.Current.GoToAsync("//Profile");
    }
}