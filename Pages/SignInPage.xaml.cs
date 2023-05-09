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

    private void SignInClicked(object sender, EventArgs e)
    {
        string emailException = "Wrong email reference";
        string existException = "This user are don't exists";
        UserDBService userDBService = new();
        ParseEmail parseEmail = new();
        ParsePassword parsePassword = new();
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
            exceptionLabel.Text = "";
        }

        if (parsePassword.Parse(Password.Text))
            exceptionPassword.Text = "Exception";
        else
            exceptionPassword.Text = "Succes";

        Shell.Current.GoToAsync(nameof(UserPage));
        
    }

}