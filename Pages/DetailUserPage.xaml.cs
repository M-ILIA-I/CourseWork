
using CourseWork.ViewModel;

namespace CourseWork.Pages;

public partial class DetailUserPage : ContentPage
{
    public DetailUserPage(UserPageViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
	}
    
}