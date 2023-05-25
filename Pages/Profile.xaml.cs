    

namespace CourseWork;

public partial class Profile : ContentPage
{
	public Profile()
	{
        if(Preferences.Get("UserEmail", null) != null)
        {
            Shell.Current.GoToAsync(nameof(UserPage));
        }
		InitializeComponent();
	}

    private void SignInButton(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//SignIn");
    }

    private void SignUpButton(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//SignUp");
    }

}