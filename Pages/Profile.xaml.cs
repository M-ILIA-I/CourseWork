    

namespace CourseWork;

public partial class Profile : ContentPage
{
	public Profile()
	{
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