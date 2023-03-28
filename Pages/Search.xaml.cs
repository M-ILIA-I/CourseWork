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
        ChildLAbel.Text = String.Format("Numbers of children {0}", value);
    }
}

