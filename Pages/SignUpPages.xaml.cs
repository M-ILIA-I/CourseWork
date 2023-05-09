namespace CourseWork;

public partial class SignUpPages : ContentPage
{
    public SignUpPages()
    {
        InitializeComponent();
    }

    private async void TapGestureRecognizer_Tapped_For_SignIn(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//SignIn");
    }
}