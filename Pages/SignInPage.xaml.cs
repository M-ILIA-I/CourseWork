namespace CourseWork;

public partial class SignInPage : ContentPage
{
    public SignInPage()
    {
        InitializeComponent();
    }

    private async void TapGestureRecognizer_Tapped_For_SignUP(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignUp");
    }

    private async void SignInClicked(object sender, EventArgs e)
    {
        string emailException = "Wrong email reference";
        string existException = "This user are don't exists";
        UserDBService userDBService = new();
        ParseEmail parseEmail = new();
        ParsePassword parsePassword = new();
        var users = userDBService.GetUsers();
        var emails = userDBService.GetEmails();
        if (!parseEmail.ParseUserEmail(Email.Text))
        {
            exceptionLabel.Text = emailException;
        }
        else if (!emails.Contains(Email.Text))
        {
            exceptionLabel.Text = existException;
        }
        else
        {
            if (!parsePassword.Parse(Password.Text))
                exceptionPassword.Text = "Exception";
            else
            {
                foreach(User u in users)
                {
                    if(u.UserEmail == Email.Text)
                    {
                        Preferences.Set("UserName", u.UserName);
                        Preferences.Set("UserEmail", u.UserEmail);
                        Preferences.Set("UserPhoneNumber", u.UserPhoneNumber);
                    }    
                }
                await Shell.Current.GoToAsync(nameof(UserPage));
            }
        }

        
       

        
        
    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {

    }
}