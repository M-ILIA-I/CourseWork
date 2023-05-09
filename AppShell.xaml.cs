using CourseWork.Pages;

namespace CourseWork;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(UserPage), typeof(UserPage));
		Routing.RegisterRoute(nameof(ToursPage), typeof(ToursPage));
        Routing.RegisterRoute(nameof(DetailUserPage), typeof(DetailUserPage));
        Routing.RegisterRoute(nameof(DetailSettingsPage), typeof(DetailSettingsPage));
        Routing.RegisterRoute(nameof(DetailUserToursPage), typeof(DetailUserToursPage));
    }
}
