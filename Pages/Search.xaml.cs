using CourseWork.Pages;
using System.Diagnostics;

namespace CourseWork;

public partial class Search : ContentPage
{
	public Search()
	{
		InitializeComponent();
	}

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
		int value = (int)e.NewValue;
		DaysLAbel.Text = String.Format("Numbers of days {0}", value);
    }

    private void PickerPulingData(object sender, EventArgs e)
    {
        ResortDBService resortDBService = new ResortDBService();
        DepartureDBService departureDBService = new DepartureDBService();

        ResortPicker.ItemsSource = resortDBService.GetResortCapitals();
        DeparturePicker.ItemsSource = departureDBService.GetDepartureCapitals();
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
        FindTourService FTS = new FindTourService();    
        List<Tour> tours = FTS.GetTours(DeparturePicker.SelectedItem.ToString(), ResortPicker.SelectedItem.ToString());
        await Shell.Current.GoToAsync(nameof(ToursPage));
    }
}

