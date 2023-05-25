namespace CourseWork;

public partial class SignUpPages : ContentPage
{
    UserDBService us;
    public SignUpPages(UserDBService Us)
    {
        InitializeComponent();
        us = Us;
    }

    private async void TapGestureRecognizer_Tapped_For_SignIn(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignIn");
    }

    private void SignUp(object sender, EventArgs e)
    {
        ParsePhoneNumber parsePhoneNumber = new();
        ParseEmail parseEmail = new();
        var users = us.GetEmails();
        if (users.Contains(email.Text))
            emEror.Text = "this email is already in use";
        else if (!parseEmail.ParseUserEmail(email.Text))
            emEror.Text = "you have entered an incorrect email";
        else if (parsePhoneNumber.Parse(phoneNum.Text))
            emEror.Text = "uncorrect phone number";
        else
        {
            User user = new User();
            user.UserName = Name.Text;
            user.UserEmail = email.Text;
            user.UserPassword = password.Text;
            user.UserPhoneNumber = phoneNum.Text;
            us.AddUser(user);
            Preferences.Set("UserName", Name.Text);
            Preferences.Set("UserEmail", email.Text);
            Preferences.Set("UserPhoneNumber", phoneNum.Text);
            Shell.Current.GoToAsync(nameof(UserPage));
        }

        
    }
}