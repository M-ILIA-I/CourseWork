using CourseWork.Pages;
using CourseWork.ViewModel;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CourseWork;

public partial class Search : ContentPage
{
    FindTourService fts;
    public ObservableCollection<Tour> tours;

    public Search(FindToursViewModel vm, FindTourService Fts)
	{
		InitializeComponent();
        BindingContext = vm;
        fts = Fts;
    }

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
		int value = (int)e.NewValue;
		DaysLAbel.Text = String.Format("Numbers of days {0}", value);
    }

    private void AdultSlider(object sender, ValueChangedEventArgs e)
    {
        int value = (int)e.NewValue;
        AdultLAbel.Text = String.Format("Numbers of adult persons {0}", value);
    }

    private void ChildSlider(object sender, ValueChangedEventArgs e)
    {
        int value = (int)e.NewValue;
        ChildLAbel.Text = String.Format("Numbers of younkeys {0}", value);
    }

    private void url(object sender, EventArgs e)
    {
        Uri uri = new Uri("https://traveltriangle.com/blog/best-summer-holiday-destinations-in-the-world/");
        Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
    }

    private async void FindTours(object sender, EventArgs e)
    {
        Preferences.Set("DC", DeparturePicker.SelectedItem.ToString());
        Preferences.Set("AC", ResortPicker.SelectedItem.ToString());
        await Shell.Current.GoToAsync(nameof(ToursPage));
    }
}

