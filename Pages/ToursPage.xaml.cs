namespace CourseWork.Pages;

public partial class ToursPage : ContentPage
{
	List<Tour> tours = new List<Tour>();
	public ToursPage()
	{
		InitializeComponent();
		FindTourService FTS = new FindTourService();
		
	}
}